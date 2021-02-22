using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacoteonibus20160324
    {
        public TbCadPacoteonibus20160324()
        {
            TbCadPacoteonibusPoltrona20160324 = new HashSet<TbCadPacoteonibusPoltrona20160324>();
        }

        public long CodPacoteonibus { get; set; }
        public long? CodOnibus { get; set; }
        public long? CodPacote { get; set; }
        public string FlgExibeportal { get; set; }
        public string FlgOperacao { get; set; }

        public virtual ICollection<TbCadPacoteonibusPoltrona20160324> TbCadPacoteonibusPoltrona20160324 { get; set; }
    }
}
