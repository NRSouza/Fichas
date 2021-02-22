using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservaCarga
    {
        public TbCadPessoapapelreservaCarga()
        {
            TbCadInscricaoCarga = new HashSet<TbCadInscricaoCarga>();
        }

        public long CodPessoapapelreserva { get; set; }
        public long? CodPessoapapel { get; set; }
        public byte? CodUnidadenr { get; set; }
        public long? CodPacote { get; set; }
        public long? CodMidia { get; set; }
        public byte? CodGrauparentescoresponsavel { get; set; }
        public long? CodResponsavel { get; set; }
        public string DesObs { get; set; }
        public DateTime? DatCadastro { get; set; }
        public DateTime? DatValidade { get; set; }
        public string DesIp { get; set; }
        public string FlgStatus { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public DateTime? DatLimiteinscricao { get; set; }
        public DateTime? DatKitcorreio { get; set; }
        public long? CodPessoa { get; set; }

        public virtual TbBasGrauparentesco CodGrauparentescoresponsavelNavigation { get; set; }
        public virtual TbBasMidia CodMidiaNavigation { get; set; }
        public virtual TbCadPacoteCarga CodPacoteNavigation { get; set; }
        public virtual TbCadPessoa CodResponsavelNavigation { get; set; }
        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadInscricaoCarga> TbCadInscricaoCarga { get; set; }
    }
}
