using System;
using System.Collections.Generic;
using System.Linq;
using Fichas.Models;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class ImpressaoLote
    {
        public Acampante Acampante { get; set; }
        public Message Message { get; set; }
        public Terceiros Terceiro { get; set; }
    }
}
