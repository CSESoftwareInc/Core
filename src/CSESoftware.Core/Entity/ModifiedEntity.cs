using System;

namespace CSESoftware.Core.Entity
{
    public abstract class ModifiedEntity<T> : EntityWithId<T>, IModifiedEntity<T>
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        public override void CreateSetup()
        {
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
            base.CreateSetup();
        }

        public override void UpdateSetup()
        {
            ModifiedDate = DateTime.UtcNow;
            base.UpdateSetup();
        }
    }
}
