using System;
using System.Collections.Generic;
using System.Text;

namespace GameKviti
{
    abstract public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
    }
}
