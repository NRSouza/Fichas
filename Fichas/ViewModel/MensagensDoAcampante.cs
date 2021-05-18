using System;
using System.Collections.Generic;
using System.Linq;
using Fichas.Models;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class MensagensDoAcampante
    {
        public Message MessageId { get; set; }
        public string Msg { get; set; }
        public DateTime CreateAt { get; set; }
        public Acampante To { get; set; }
        public Terceiros From { get; set; }
        public DateTime? ToSee { get; set; }
    }
}
