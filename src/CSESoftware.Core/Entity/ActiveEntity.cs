namespace CSESoftware.Core.Entity
{
    public abstract class ActiveEntity<T> : EntityWithId<T>, IActiveEntity<T>
    {
        public bool IsActive { get; set; } = true;

        public override void CreateSetup()
        {
            IsActive = true;
            base.CreateSetup();
        }

        public override void UpdateSetup()
        {
            base.UpdateSetup();
        }
    }
}
