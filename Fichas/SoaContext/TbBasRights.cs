using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasRights
    {
        public int CodRights { get; set; }
        public string NomItem { get; set; }
        public int CodTipo { get; set; }
        public int ValOrdem { get; set; }

        public virtual TbBasRightsauthitem NomItemNavigation { get; set; }
    }
}
