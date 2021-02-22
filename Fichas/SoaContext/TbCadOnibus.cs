using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadOnibus
    {
        public TbCadOnibus()
        {
            TbCadAlocacaoonibusOnibus = new HashSet<TbCadAlocacaoonibusOnibus>();
            TbCadOnibusSaida = new HashSet<TbCadOnibusSaida>();
        }

        public long CodOnibus { get; set; }
        public string DesOnibus { get; set; }
        public int? NumPoltronas { get; set; }
        public string DesEmpresa { get; set; }
        public string DesRepresentante { get; set; }
        public string DesTelefone { get; set; }
        public string DesDdd { get; set; }
        public string FlgAtivo { get; set; }
        public string DesImagem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadAlocacaoonibusOnibus> TbCadAlocacaoonibusOnibus { get; set; }
        public virtual ICollection<TbCadOnibusSaida> TbCadOnibusSaida { get; set; }
    }
}
