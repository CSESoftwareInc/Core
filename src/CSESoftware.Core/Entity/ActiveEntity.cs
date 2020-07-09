namespace CSESoftware.Core.Entity
{
    public abstract class ActiveEntity<T> : EntityWithId<T>, IActiveEntity<T>
    {
        public bool IsActive { get; set; } = true;
    }
}