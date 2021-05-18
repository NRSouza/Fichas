using System;
using System.Collections.Generic;
using Fichas.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class MensagensDoTerceiro
    {
        public Message MessageId { get; set; }
        public string Msg { get; set; }
        public DateTime CreateAt { get; set; }
        public Terceiros To { get; set; }
        public Acampante From { get; set; }
        public DateTime? ToSee { get; set; }
    }
}
