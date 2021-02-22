using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasRightsauthitem
    {
        public TbBasRightsauthitem()
        {
            TbBasRights = new HashSet<TbBasRights>();
            TbBasRightsauthassignment = new HashSet<TbBasRightsauthassignment>();
            TbBasRightsauthitemchild = new HashSet<TbBasRightsauthitemchild>();
        }

        public long CodRightsauthitem { get; set; }
        public string NomItem { get; set; }
        public int CodTipo { get; set; }
        public string DesItem { get; set; }
        public string DesRegranegocio { get; set; }
        public string DesDados { get; set; }

        public virtual ICollection<TbBasRights> TbBasRights { get; set; }
        public virtual ICollection<TbBasRightsauthassignment> TbBasRightsauthassignment { get; set; }
        public virtual ICollection<TbBasRightsauthitemchild> TbBasRightsauthitemchild { get; set; }
    }
}
