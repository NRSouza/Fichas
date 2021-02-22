using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscPessoa2
    {
        public long CodEscPessoa { get; set; }
        public int? CodCategoriaSistema { get; set; }
        public string NomPessoa { get; set; }
        public string DesEmail { get; set; }
        public DateTime? DatNascto { get; set; }
        public string NumCpf { get; set; }
        public string NumRg { get; set; }
        public string NumTelefoneCelular { get; set; }
        public string NumTelefoneResidencial { get; set; }
        public string NumTelefoneComercial { get; set; }
        public string DesContato { get; set; }
        public string DesCep { get; set; }
        public string DesLogradouro { get; set; }
        public string DesNumero { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesComplemento { get; set; }
        public string DesUf { get; set; }
        public string CodSexo { get; set; }
        public string FlgAtivo { get; set; }
        public string FlgAtivoSistema { get; set; }
        public DateTime? DatCadastro { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string DesCodigoAcesso { get; set; }
    }
}
