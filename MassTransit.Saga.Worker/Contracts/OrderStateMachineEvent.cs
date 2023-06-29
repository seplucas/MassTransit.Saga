namespace Contracts
{
    using System;

    public record OrderStateMachineEvent
    {
        public Guid CorrelationId { get; init; }
        public string Value { get; init; }
    }
}