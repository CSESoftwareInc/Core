using System;
using System.Globalization;

namespace CSESoftware.Core.Entity
{
    public abstract class EntityWithId<T> : IEntityWithId<T>
    {
        public T Id { get; set; }
        object IEntityWithId.Id
        {
            get => Id;
            set => Id = (T)Convert.ChangeType(value, typeof(T), new CultureInfo("en-US"));
        }
    }
}