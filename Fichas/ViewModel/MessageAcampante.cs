using System;
using Fichas.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.ViewModel
{
    public class MessageAcampante
    {
        public Guid Id { get; set; }
        public string Msg { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid To { get; set; }
        public Guid From { get; set; }
        public DateTime ToSee { get; set; }
        public string CodAcampante { get; set; }
        public string DatNascto { get; set; }
        public List<AmigosDoTerceiro> AmigosDoTerceiro{ get; set; }
        public List<Message> NaoLidas{ get; set; }
    }
}
