using System;
using System.Collections.Generic;
using System.Linq;
using Fichas.Models;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class AcampanteSemAmigos
    {
        public string? codAcampante { get; set; }
        public Responsavel Responsavel { get; set; }
        public string DesPacote { get; set; }
        public string Nome { get; set; }
        public string Equipe { get; set; }
        public string Unidade { get; set; }
    }
}
