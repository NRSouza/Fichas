using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasRightsauthassignment
    {
        public int CodRightsauthassignment { get; set; }
        public string NomItem { get; set; }
        public int CodUsuario { get; set; }
        public string DesRegranegocio { get; set; }
        public string DesDados { get; set; }

        public virtual TbBasRightsauthitem NomItemNavigation { get; set; }
    }
}
