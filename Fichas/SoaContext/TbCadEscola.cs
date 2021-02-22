using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscola
    {
        public TbCadEscola()
        {
            TbCadEscolacontato = new HashSet<TbCadEscolacontato>();
            TbCadEscolaendereco = new HashSet<TbCadEscolaendereco>();
        }

        public long CodEscola { get; set; }
        public long? CodTipoescola { get; set; }
        public int? CodPais { get; set; }
        public string NomEscola { get; set; }
        public string NomFantasia { get; set; }
        public string DesCnpj { get; set; }
        public string DesLogradouro { get; set; }
        public string DesLogradouroNumero { get; set; }
        public string DesComplemento { get; set; }
        public string DesCep { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
        public string DesDdd { get; set; }
        public string NumTelefone { get; set; }
        public string DesContato { get; set; }
        public string DesDddCelular { get; set; }
        public string NumCelular { get; set; }
        public string DesContatoCelular { get; set; }
        public string DesEmail { get; set; }
        public string DesSite { get; set; }
        public string DesIp { get; set; }
        public DateTime? DatCadastro { get; set; }
        public string FlgAtivo { get; set; }
        public string FlgOrigemcadastro { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime DatAtualizacao { get; set; }

        public virtual TbBasPais CodPaisNavigation { get; set; }
        public virtual TbBasTipoescola CodTipoescolaNavigation { get; set; }
        public virtual ICollection<TbCadEscolacontato> TbCadEscolacontato { get; set; }
        public virtual ICollection<TbCadEscolaendereco> TbCadEscolaendereco { get; set; }
    }
}
