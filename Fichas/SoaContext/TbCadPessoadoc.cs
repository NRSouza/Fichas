using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoadoc
    {
        public long CodPessoadoc { get; set; }
        public long? CodPessoa { get; set; }
        public string FlgRg { get; set; }
        public string NumRg { get; set; }
        public string DesRgorgao { get; set; }
        public string DesRguf { get; set; }
        public DateTime? DatRgemissao { get; set; }
        public byte? CodTiporg { get; set; }
        public string FlgCpf { get; set; }
        public string NumCpf { get; set; }
        public string FlgCertidao { get; set; }
        public string NumCertidao { get; set; }
        public string FlgTit { get; set; }
        public string NumTit { get; set; }
        public string DesTitsecao { get; set; }
        public string DesTitzona { get; set; }
        public DateTime? DatTitemissao { get; set; }
        public string DesTituf { get; set; }
        public string FlgPis { get; set; }
        public string NumPis { get; set; }
        public DateTime? DatPisemissao { get; set; }
        public int? CodPisbanco { get; set; }
        public int? CodPisagencia { get; set; }
        public string FlgCtps { get; set; }
        public string NumCtps { get; set; }
        public string DesCtpsserie { get; set; }
        public DateTime? DatCtpsemissao { get; set; }
        public string DesCtpsuf { get; set; }
        public string FlgCnh { get; set; }
        public string NumCnh { get; set; }
        public string DesCnhcateg { get; set; }
        public DateTime? DatCnhvalidade { get; set; }
        public string FlgPassaporte { get; set; }
        public string NumPassaporte { get; set; }
        public int? CodPais { get; set; }
        public DateTime? DatPassemissao { get; set; }
        public DateTime? DatPassvalidade { get; set; }
        public string FlgVisto { get; set; }
        public string NumVisto { get; set; }
        public DateTime? DatVistoemissao { get; set; }
        public DateTime? DatVistovalidade { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasAgencia CodPisagenciaNavigation { get; set; }
        public virtual TbBasBanco CodPisbancoNavigation { get; set; }
    }
}
