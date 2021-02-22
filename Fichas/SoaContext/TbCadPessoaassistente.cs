using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaassistente
    {
        public TbCadPessoaassistente()
        {
            TbCadPessoaassistenteDisponibilidade = new HashSet<TbCadPessoaassistenteDisponibilidade>();
        }

        public long CodPessoaassistente { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodGrauescolaridade { get; set; }
        public string DesObsfoto { get; set; }
        public string NomPai { get; set; }
        public string DesProfissaopai { get; set; }
        public string NomMae { get; set; }
        public string DesProfissaomae { get; set; }
        public string DesInstituicaoPrimeirograu { get; set; }
        public string DesInstituicaoSegundograu { get; set; }
        public string DesInstituicaoSuperior { get; set; }
        public string DesCurso { get; set; }
        public string DesSemestre { get; set; }
        public string DesAnoletivo { get; set; }
        public string DesPeriodo { get; set; }
        public string DesHobbies { get; set; }
        public string DesComoconhecenr { get; set; }
        public string DesIndicadopor { get; set; }
        public string DesInteresse { get; set; }
        public string DesMotivoreprovacao { get; set; }
        public string DesNumeroinss { get; set; }
        public string DesAcompanhamento { get; set; }
        public string DesOcupacoes { get; set; }
        public string DesOutroEsporte { get; set; }
        public string DesOutroMusica { get; set; }
        public string DesOutroArte { get; set; }
        public string FlgHabilitacao { get; set; }
        public string FlgCarro { get; set; }
        public string FlgConhecenr { get; set; }
        public string FlgIndicacao { get; set; }
        public string FlgContratado { get; set; }
        public string FlgReprovado { get; set; }
        public string FlgEntrevistado { get; set; }
        public string FlgEnviarsenha { get; set; }
        public DateTime? DatTerminoPrimeirograu { get; set; }
        public DateTime? DatTerminoSegundograu { get; set; }
        public DateTime? DatTerminoSuperior { get; set; }
        public DateTime? DatConhecenr { get; set; }
        public DateTime? DatEnviosenha { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string DesAgencia { get; set; }
        public string DesContacorrente { get; set; }

        public virtual ICollection<TbCadPessoaassistenteDisponibilidade> TbCadPessoaassistenteDisponibilidade { get; set; }
    }
}
