using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasMidiassociais
    {
        public TbBasMidiassociais()
        {
            TbCadPessoamidiasocial = new HashSet<TbCadPessoamidiasocial>();
        }

        public int CodMidiasocial { get; set; }
        public string NomMidiasocial { get; set; }
        public string DesUrl { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPessoamidiasocial> TbCadPessoamidiasocial { get; set; }
    }
}
