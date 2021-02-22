using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscPagamento
    {
        public TbCadEscPagamento()
        {
            TbCadEscBoleto = new HashSet<TbCadEscBoleto>();
        }

        public long CodEscPagamento { get; set; }
        public long? CodEscResponsavel { get; set; }
        public long? CodEscAluno { get; set; }
        public long? CodPedido { get; set; }
        public string NumCartao { get; set; }
        public string NumTid { get; set; }
        public string NumTransacao { get; set; }
        public int? NumParcela { get; set; }
        public decimal? ValParcela { get; set; }
        public decimal? ValTotal { get; set; }
        public decimal? ValAproi { get; set; }
        public string FlgAproi { get; set; }
        public string FlgGateway { get; set; }
        public string FlgStatus { get; set; }
        public string DesDetalhes { get; set; }
        public DateTime? DatPagto { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string NumNsu { get; set; }
        public string NumCartao2 { get; set; }
        public string NumTid2 { get; set; }
        public string NumTransacao2 { get; set; }
        public int? NumParcela2 { get; set; }
        public decimal? ValParcela2 { get; set; }
        public decimal? ValCartao1 { get; set; }
        public decimal? ValCartao2 { get; set; }
        public string FlgGateway2 { get; set; }
        public string NumNsu2 { get; set; }
        public string FlgBoleto { get; set; }
        public long? CodCupomItem { get; set; }
        public DateTime? DatUtilizacaoCupom { get; set; }
        public string FlgDiferenca { get; set; }

        public virtual TbCadCupomItem CodCupomItemNavigation { get; set; }
        public virtual TbCadEscPessoa CodEscAlunoNavigation { get; set; }
        public virtual TbCadEscPessoa CodEscResponsavelNavigation { get; set; }
        public virtual ICollection<TbCadEscBoleto> TbCadEscBoleto { get; set; }
    }
}
