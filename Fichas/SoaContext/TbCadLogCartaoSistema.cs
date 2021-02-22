using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadLogCartaoSistema
    {
        public long CodLogCartaoSistema { get; set; }
        public string DesSistema { get; set; }
        public string DesFuncionalidade { get; set; }
        public string DesAcao { get; set; }
        public string DesPortador { get; set; }
        public string DesEmail { get; set; }
        public string NumCartao { get; set; }
        public int? NumParcela { get; set; }
        public decimal? ValParcela { get; set; }
        public decimal? ValTotal { get; set; }
        public string NumTid { get; set; }
        public string NumTransacao { get; set; }
        public byte? CodStatus { get; set; }
        public string FlgGateway { get; set; }
        public string DesIp { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string NumNsu { get; set; }
        public string QtdCartao { get; set; }
    }
}
