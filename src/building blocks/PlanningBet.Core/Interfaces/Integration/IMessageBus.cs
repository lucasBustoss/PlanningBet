using PlanningBet.Core.Integration;

namespace PlanningBet.Core.Interfaces.Integration
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage message, string queueName);
    }
}
