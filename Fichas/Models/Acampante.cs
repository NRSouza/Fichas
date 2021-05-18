using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Acampante : Entity
    {
        public int codPessoa { get; set; }
        public string? codAcampante { get; set; }
        public Responsavel Responsavel { get; set; }
        public int? codPacote { get; set; }
        public string Nome { get; set; }
        public bool FichaRespondida { get; set; }
        public bool FlgWhatsApp { get; set; }
        public bool FlgImpressao { get; set; }
        public int Equipe { get; set; }
        public DateTime? DatNascto { get; set; }
    }
}
