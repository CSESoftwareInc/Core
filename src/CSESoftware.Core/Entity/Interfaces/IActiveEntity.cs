namespace CSESoftware.Core.Entity
{
    public interface IActiveEntity<T> : IEntityWithId<T>
    {
        bool IsActive { get; set; }
    }
}
