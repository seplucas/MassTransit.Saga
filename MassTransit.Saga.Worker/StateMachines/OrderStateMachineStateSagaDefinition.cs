namespace Company.StateMachines
{
    using MassTransit;

    public class OrderStateMachineStateSagaDefinition :
        SagaDefinition<OrderStateMachineState>
    {
        protected override void ConfigureSaga(IReceiveEndpointConfigurator endpointConfigurator, ISagaConfigurator<OrderStateMachineState> sagaConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
            endpointConfigurator.UseInMemoryOutbox();
        }
    }
}