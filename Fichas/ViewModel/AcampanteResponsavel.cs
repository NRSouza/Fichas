using Fichas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class AcampanteResponsavel
    {
        public Acampante Acampante { get; set; }
        public Responsavel Responsavel { get; set; }
        public string NomAcampante { get; set; }
        public string NomResponsavel { get; set; }
        public long? CodAcampante { get; set; }
        public long? CodResponsavel { get; set; }
        public bool FichaRespondida { get; set; }
        public string Telefone { get; set; }
    }
}
