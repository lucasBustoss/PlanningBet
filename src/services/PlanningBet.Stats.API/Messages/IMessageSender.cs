using PlanningBet.Core.Integration;

namespace PlanningBet.Stats.API.Messages
{
    public interface IMessageSender
    {
        void SendMessage<T>(BaseMessage baseMessage, string queueName);
    }
}
