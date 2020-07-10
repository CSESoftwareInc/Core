using System;

namespace CSESoftware.Core.Entity
{
    public interface IModifiedEntity<T> : IEntityWithId<T>
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
