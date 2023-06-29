namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class OrderConsumerConsumer :
        IConsumer<OrderConsumer>
    {
        public Task Consume(ConsumeContext<OrderConsumer> context)
        {
            return Task.CompletedTask;
        }
    }
}