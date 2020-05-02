using System;

namespace CSESoftware.Core
{
    public abstract class BaseDomainEvent
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}