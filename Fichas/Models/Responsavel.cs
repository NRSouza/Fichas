using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Responsavel : Entity
    {
        public Guid ID { get; set; }
        public int codResponsavel { get; set; }
        public string Nome { get; set; }
        public bool FichaRespondida { get; set; }
    }
}
