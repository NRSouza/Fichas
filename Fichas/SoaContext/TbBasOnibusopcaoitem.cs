using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasOnibusopcaoitem
    {
        public long CodOnibusopcaoitem { get; set; }
        public long? CodOnibus { get; set; }
        public byte? CodOnibusitem { get; set; }

        public virtual TbBasOnibusitem CodOnibusitemNavigation { get; set; }
    }
}
