using System;

namespace CSESoftware.Core.Entity
{
    public abstract class ModifiedEntity<T> : EntityWithId<T>, IModifiedEntity<T>
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}