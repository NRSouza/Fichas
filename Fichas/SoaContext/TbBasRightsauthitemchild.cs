using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasRightsauthitemchild
    {
        public long CodRightsauthitemchild { get; set; }
        public string DesRelacoes { get; set; }
        public string DesPermissoes { get; set; }

        public virtual TbBasRightsauthitem DesRelacoesNavigation { get; set; }
    }
}
