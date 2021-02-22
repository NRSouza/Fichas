using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbTempEscEvento20180219
    {
        public long CodEscTmpEvento { get; set; }
        public long? CodPedido { get; set; }
        public long? CodEscola { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string CodEvento { get; set; }
        public string DesEvento { get; set; }
        public string DesEscola { get; set; }
        public string DesInformacoesAdicionais { get; set; }
        public string DesContrato { get; set; }
        public string DesOrganizadores { get; set; }
        public string DesCorpoemailOrganizadores { get; set; }
        public string DesAnexoOrganizadores { get; set; }
        public byte? QtdParcelamento { get; set; }
        public byte? MesParcelamento { get; set; }
        public int? AnoParcelamento { get; set; }
        public byte? QtdParcelamentoRegressivo { get; set; }
        public byte? MesParcelamentoRegressivo { get; set; }
        public int? AnoParcelamentoRegressivo { get; set; }
        public byte? QtdParcelamentoFixo { get; set; }
        public byte? MesParcelamentoFixo { get; set; }
        public int? AnoParcelamentoFixo { get; set; }
        public decimal? ValNr { get; set; }
        public decimal? ValEscola { get; set; }
        public int? NumTotalVagas { get; set; }
        public string FlgBloquear { get; set; }
        public int? QtdBloquearDia { get; set; }
        public string FlgAtivar { get; set; }
        public DateTime? DatAtivar { get; set; }
        public DateTime? DatEntrada { get; set; }
        public DateTime? DatSaida { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgEnvioOrganizadores { get; set; }
        public long? CodRepresentante { get; set; }
        public string DesRepresentante { get; set; }
        public string FlgEmitenteSapiens { get; set; }
        public decimal? ValBoleto { get; set; }
        public string FlgExibeBoleto { get; set; }
        public string FlgExibeCartao { get; set; }
        public string FlgCupom { get; set; }
        public string DesImgQrcode { get; set; }
        public string FlgAppCelular { get; set; }
        public string CodEscUrl { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
    }
}
