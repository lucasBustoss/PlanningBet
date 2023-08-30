using Microsoft.EntityFrameworkCore;
using PlanningBet.Teams.API.Database;
using PlanningBet.Teams.API.Entities;
using PlanningBet.Teams.API.Repositories;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace PlanningBet.Teams.API.Messages
{
    public class MessageConsumer : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;
        TeamsRepository _repository;

        public MessageConsumer(TeamsRepository repository)
        {
            _repository = repository;

            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin"
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare("teams", false, false, false, null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (channel, evt) =>
            {
                var content = Encoding.UTF8.GetString(evt.Body.ToArray());
                var message = JsonSerializer.Deserialize<TeamMessage>(content);

                ProcessTeams(message.Teams.ToList()).GetAwaiter().GetResult();

                _channel.BasicAck(evt.DeliveryTag, false);
            };

            //_channel.BasicConsume("teams", false, consumer);
            return Task.CompletedTask;
        }

        private async Task ProcessTeams(List<Team> teams)
        {
            foreach (var team in teams)
                await _repository.CreateOrUpdate(team);
        }
    }
}
