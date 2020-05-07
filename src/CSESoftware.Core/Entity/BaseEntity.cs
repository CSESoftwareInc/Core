using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSESoftware.Core.Entity
{
    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        object IBaseEntity.Id
        {
            get => Id;
            set => Id = (T)Convert.ChangeType(value, typeof(T), new CultureInfo("en-US"));
        }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}