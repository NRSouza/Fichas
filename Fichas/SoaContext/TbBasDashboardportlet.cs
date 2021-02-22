using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasDashboardportlet
    {
        public int CodDashboardportlet { get; set; }
        public int CodDashboard { get; set; }
        public int? CodUsuario { get; set; }
        public string DesConfiguracoes { get; set; }
    }
}
