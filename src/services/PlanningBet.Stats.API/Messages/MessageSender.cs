using PlanningBet.Core.Integration;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace PlanningBet.Stats.API.Messages
{
    public class MessageSender : IMessageSender
    {
        private readonly string _hostName;
        private readonly string _password;
        private readonly string _userName;
        private IConnection _connection;

        public MessageSender()
        {
            _hostName = "localhost";
            _userName = "admin"; 
            _password = "admin";
        }

        public void SendMessage<T>(BaseMessage message, string queueName)
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password,
            };

            _connection = factory.CreateConnection();
            using var channel = _connection.CreateModel();
            channel.QueueDeclare(queueName, false, false, false, null);
            byte[] body = GetMessageAsByteArray<T>(message);
            channel.BasicPublish("", queueName, null, body);
        }

        private byte[] GetMessageAsByteArray<T>(BaseMessage message)
        {
            message.MessageCreated = DateTime.Now;
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize<T>((T)(object)message, options);

            var body = Encoding.UTF8.GetBytes(json);
            return body;
        }
    }
}
