using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
