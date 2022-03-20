namespace Implement_RabbitMQ.Interface
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message);
    }
}
