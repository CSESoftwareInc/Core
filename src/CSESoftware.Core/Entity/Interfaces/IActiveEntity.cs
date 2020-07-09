namespace CSESoftware.Core.Entity
{
    public interface IActiveEntity : IEntityWithId
    {
        bool IsActive { get; set; }
    }

    public interface IActiveEntity<T> : IActiveEntity
    {
        new T Id { get; set; }
    }
}