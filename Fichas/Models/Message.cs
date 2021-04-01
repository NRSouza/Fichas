using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Msg { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid To { get; set; }
        public Guid From { get; set; }
        public DateTime? ToSee { get; set; }
    }
}
