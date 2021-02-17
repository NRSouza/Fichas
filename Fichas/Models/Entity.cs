using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Entity
    {
        public Guid ID{ get; set; }

        public Entity()
        {
            ID= Guid.NewGuid();
        }
    }
}
