using PlanningBet.Leagues.API.Entities;
using PlanningBet.Leagues.API.Repositories;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace PlanningBet.Leagues.API.Messages
{
    public class MessageConsumer : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;
        LeaguesRepository _repository;

        public MessageConsumer(LeaguesRepository repository)
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
            _channel.QueueDeclare("leagues", false, false, false, null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (channel, evt) =>
            {
                var content = Encoding.UTF8.GetString(evt.Body.ToArray());
                var message = JsonSerializer.Deserialize<LeagueMessage>(content);

                ProcessLeagues(message.Leagues.ToList()).GetAwaiter().GetResult();

                _channel.BasicAck(evt.DeliveryTag, false);
            };

            _channel.BasicConsume("leagues", false, consumer);
            return Task.CompletedTask;
        }

        private async Task ProcessLeagues(List<League> leagues)
        {
            foreach (var league in leagues)
                await _repository.CreateOrUpdate(league);
        }
    }
}
