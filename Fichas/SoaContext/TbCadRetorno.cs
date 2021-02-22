using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadRetorno
    {
        public TbCadRetorno()
        {
            TbCadRetornoConteudo = new HashSet<TbCadRetornoConteudo>();
        }

        public long CodRetorno { get; set; }
        public string DesArquivoretorno { get; set; }
        public DateTime? DatRetorno { get; set; }
        public string DesRegistro { get; set; }
        public string CbTipoOperacao { get; set; }
        public string CbIdTipoOperacao { get; set; }
        public string CbIdTipoServico { get; set; }
        public string CbTipoServico { get; set; }
        public string CbAgenciaCedente { get; set; }
        public string CbDvAgenciaCedente { get; set; }
        public string CbContaCedente { get; set; }
        public string CbDvContaCedente { get; set; }
        public string CbConvenio { get; set; }
        public string CbNomeCedente { get; set; }
        public string CbCodNomeBanco { get; set; }
        public string CbDataGravacao { get; set; }
        public string CbSequencialRet { get; set; }
        public string CbNumeroConvenio { get; set; }
        public string CbSequencialReg { get; set; }
        public string DesRegistroRodape { get; set; }
        public string RdCobSimplesQtdTitulos { get; set; }
        public string RdCobSimplesVlrTotal { get; set; }
        public string RdCobSimplesNumAviso { get; set; }
        public string RdCobVincQtdTitulos { get; set; }
        public string RdCobVincValorTotal { get; set; }
        public string RdCobVincNumAviso { get; set; }
        public string RdCobCaucQtdTitulos { get; set; }
        public string RdCobCaucVlrTotal { get; set; }
        public string RdCobCaucNumAviso { get; set; }
        public string RdCobDescQtdTitulos { get; set; }
        public string RdCobDescVlrTotal { get; set; }
        public string RdCobDescNumAviso { get; set; }
        public string RdCobVendorQtdTitulos { get; set; }
        public string RdCobVendorVlrTotal { get; set; }
        public string RdCobVendorNumAviso { get; set; }
        public string RdSequencialReg { get; set; }

        public virtual ICollection<TbCadRetornoConteudo> TbCadRetornoConteudo { get; set; }
    }
}
