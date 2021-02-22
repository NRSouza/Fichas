using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagamentoParcela
    {
        public TbCadPagamentoParcela()
        {
            TbCadBoleto = new HashSet<TbCadBoleto>();
        }

        public long CodPagamentoParcela { get; set; }
        public long? CodPagamento { get; set; }
        public long? CodPagamentoCondmeio { get; set; }
        public int? NumParcela { get; set; }
        public decimal? ValParcela { get; set; }
        public DateTime? DatParcela { get; set; }
        public string NumBoleto { get; set; }
        public int? CodBanco { get; set; }
        public int? CodAgencia { get; set; }
        public string DesEmitente { get; set; }
        public string DesContacorrente { get; set; }
        public string DesNumero { get; set; }
        public string NumBoletoNossonumero { get; set; }
        public string DesAgencia { get; set; }
        public string DesObservacao { get; set; }
        public string DesAnexo { get; set; }

        public virtual TbCadPagamento CodPagamentoNavigation { get; set; }
        public virtual ICollection<TbCadBoleto> TbCadBoleto { get; set; }
    }
}
