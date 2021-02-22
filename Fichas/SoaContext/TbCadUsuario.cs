using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadUsuario
    {
        public TbCadUsuario()
        {
            TbCadEmails = new HashSet<TbCadEmails>();
            TbCadRepresentanteagencia = new HashSet<TbCadRepresentanteagencia>();
            TbCadTemporadaequipeFoto = new HashSet<TbCadTemporadaequipeFoto>();
            TbCadTemporadaequipePessoas = new HashSet<TbCadTemporadaequipePessoas>();
        }

        public int CodIdUsuario { get; set; }
        public byte CodUnidadenr { get; set; }
        public byte CodDepto { get; set; }
        public byte CodVisibilidade { get; set; }
        public string NomUsuario { get; set; }
        public string DesSenha { get; set; }
        public string DesEmail { get; set; }
        public string DesFoto { get; set; }
        public string FlgAtivo { get; set; }
        public DateTime? DatValidadeSenha { get; set; }
        public string DesIp { get; set; }
        public DateTime? DatCadastro { get; set; }
        public DateTime? DatUltimoLogon { get; set; }
        public string FlgExpirada { get; set; }
        public string DesIdioma { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadEmails> TbCadEmails { get; set; }
        public virtual ICollection<TbCadRepresentanteagencia> TbCadRepresentanteagencia { get; set; }
        public virtual ICollection<TbCadTemporadaequipeFoto> TbCadTemporadaequipeFoto { get; set; }
        public virtual ICollection<TbCadTemporadaequipePessoas> TbCadTemporadaequipePessoas { get; set; }
    }
}
