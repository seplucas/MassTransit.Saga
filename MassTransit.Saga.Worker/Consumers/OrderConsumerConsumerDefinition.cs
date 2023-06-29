namespace Company.Consumers
{
    using MassTransit;

    public class OrderConsumerConsumerDefinition :
        ConsumerDefinition<OrderConsumerConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<OrderConsumerConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}