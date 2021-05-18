using Fichas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class Inbox
    {
        public Message MessageId { get; set; }
        public string Msg { get; set; }
        public DateTime CreateAt { get; set; }
        public string ToNome { get; set; }
        public string FromNome { get; set; }
        public string? ToSee { get; set; }
    }
}
