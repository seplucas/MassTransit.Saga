namespace Company.StateMachines
{
    using Contracts;
    using MassTransit;

    public class OrderStateMachineStateMachine :
        MassTransitStateMachine<OrderStateMachineState> 
    {
        public OrderStateMachineStateMachine()
        {
            InstanceState(x => x.CurrentState, Created);

            Event(() => OrderStateMachineEvent, x => x.CorrelateById(context => context.Message.CorrelationId));

            Initially(
                When(OrderStateMachineEvent)
                    .Then(context => context.Instance.Value = context.Data.Value)
                    .TransitionTo(Created)
            );

            SetCompletedWhenFinalized();
        }

        public State Created { get; private set; }

        public Event<OrderStateMachineEvent> OrderStateMachineEvent { get; private set; }
    }
}