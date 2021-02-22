using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaficha
    {
        public long CodPessoaficha { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodEstadocivil { get; set; }
        public byte? CodRacacor { get; set; }
        public int? CodNacionalidade { get; set; }
        public long? CodTipocamiseta { get; set; }
        public string DesApelido { get; set; }
        public DateTime? DatNascto { get; set; }
        public string CodSexo { get; set; }
        public string DesNomesolteiro { get; set; }
        public string DesEmailparticular { get; set; }
        public string DesEmailcomercial { get; set; }
        public byte? NumQtdefilhos { get; set; }
        public byte? DesPeso { get; set; }
        public byte? DesAltura { get; set; }
        public string DesObs { get; set; }
        public string FlgVeterano { get; set; }
        public string FlgFalecido { get; set; }
        public string FlgEmailmktparticular { get; set; }
        public string FlgEmailmktcomercial { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSmsSistema { get; set; }

        public virtual TbBasEstadocivil CodEstadocivilNavigation { get; set; }
        public virtual TbBasNacionalidade CodNacionalidadeNavigation { get; set; }
        public virtual TbBasRacacor CodRacacorNavigation { get; set; }
    }
}
