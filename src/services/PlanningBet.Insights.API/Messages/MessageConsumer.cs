using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace PlanningBet.Insights.API.Messages
{
    public class MessageConsumer : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;

        public MessageConsumer()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin"
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare("teste-fila", false, false, false, null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (channel, evt) =>
            {
                var content = Encoding.UTF8.GetString(evt.Body.ToArray());
                var teste = JsonSerializer.Deserialize<TesteModel>(content);
                //MeuMetodo.GetAwaiter().GetResult();
                _channel.BasicAck(evt.DeliveryTag, false);
            };

            _channel.BasicConsume("teste-fila", false, consumer);
            return Task.CompletedTask;
        }
    }

    public class TesteModel
    {
        public long Id { get; set; }
        public string NameTeste { get; set; }
        public DateTime MessageCreated { get; set; }
    }

}
