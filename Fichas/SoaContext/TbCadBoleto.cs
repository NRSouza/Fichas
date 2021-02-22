using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadBoleto
    {
        public long CodBoleto { get; set; }
        public long? CodPagamentoParcela { get; set; }
        public long? CodRemessa { get; set; }
        public long? CodRetorno { get; set; }
        public string DesCedente { get; set; }
        public string DesClienteNome { get; set; }
        public string DesClienteEndereco { get; set; }
        public string DesClienteEnderecoComp { get; set; }
        public string DesClienteBairro { get; set; }
        public string DesClienteCidade { get; set; }
        public string DesClienteEstado { get; set; }
        public string DesClienteCep { get; set; }
        public string DesClienteCpfCnpj { get; set; }
        public string NumAgenciaCodcedente { get; set; }
        public string NumNossonumero { get; set; }
        public string NumDocumento { get; set; }
        public string NumContrato { get; set; }
        public string NumCarteiraCompleto { get; set; }
        public string NumCarteira { get; set; }
        public string NumVariacaocarteira { get; set; }
        public string NumLinhadigitavel { get; set; }
        public decimal? ValDocumento { get; set; }
        public decimal? ValDesconto { get; set; }
        public decimal? ValOutrasdeducoes { get; set; }
        public decimal? ValMulta { get; set; }
        public decimal? ValOutrosacrescimos { get; set; }
        public decimal? ValCobrado { get; set; }
        public DateTime? DatDocumento { get; set; }
        public DateTime? DatVencimento { get; set; }
        public string DesPdf { get; set; }
        public string DesInstrucaocliente { get; set; }
        public string DesInstrucaocaixa { get; set; }

        public virtual TbCadPagamentoParcela CodPagamentoParcelaNavigation { get; set; }
    }
}
