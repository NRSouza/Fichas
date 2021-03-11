using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Ficha : Entity
    {
        public Responsavel Responsavel { get; set; }
        public Acampante Acampante { get; set; }
        [Required]
        public Double Peso { get; set; }
        [Required]
        public Double Altura { get; set; }
        public string Tip_Sanguineo { get; set; }
        public string Convenio { get; set; }
        public string Nome_Pediatra_Contato { get; set; }
        public bool Nadar { get; set; }
        public bool Boia { get; set; }
        public bool Acomp_Psicologico { get; set; }
        public string Motivo_Acomp_Psicologico { get; set; }
        public bool Vacinas_Validas { get; set; }
        public bool Alopatia { get; set; }
        public bool Homeopatia { get; set; }
        public bool H1N1{ get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Dat_H1N1 { get; set; }
        public bool MenigiteC { get; set; }
        public bool Covid { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Dat_Covid { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Dat_MenigiteC { get; set; }
        public bool BelicheInferior { get; set; }
        public bool Aparelho_Dental { get; set; }
        public bool Dramin { get; set; }
        public bool Vonal { get; set; }
        public string Orientacao_Febre { get; set; }
        public string Orientacao_Barriga { get; set; }
        public string Orientacao_Cabeca { get; set; }
        public string Orientacao_Ouvido { get; set; }
        public string Orientacao_Colica { get; set; }
        public string Orientacao_Garganta { get; set; }
        public bool Diabetes { get; set; }
        public string Tratamento_Diabetes { get; set; }
        public bool Convulsao { get; set; }
        public string Tratamento_Convulsao { get; set; }
        public bool Asma { get; set; }
        public string Tratamento_Asma { get; set; }
        public bool Bronquite { get; set; }
        public string Tratamento_Bronquite { get; set; }
        public bool Infeccao_Recente { get; set; }
        public bool Enurese_Noturna { get; set; }
        public bool Sonambulismo { get; set; }
        public bool RestricaoAttFisica { get; set; }
        public string Obs_RestricaoAttFisica { get; set; }
        [Required]
        public string Alergia_Medicamento { get; set; }
        public string Obs_Alergia_Medicamento { get; set; }
        [Required]
        public string Necessidade_Especial { get; set; }
        public string Obs_Necessidade_Especial { get; set; }
        public bool Restricao_Alimentar { get; set; }
        public string Obs_Restricao_Alimentar { get; set; }
        public bool Medo_Fobia { get; set; } 
        public string Obs_Medo_Fobia { get; set; } 
        public string OcorrenciaMedica { get; set; } 
        public string Obs_Geral { get; set; }
        public DateTime DatAtt { get; set; }
        public bool Autorizacao_Atividades { get; set; }
        public string Obs_Autorizacao_Atividades { get; set; }

        public enum Talvez
        {
            [Description("Sim")]
            Sim,
            [Description("Não sei")]
            Não_sei
        }
        public enum Selecione
        {
            [Display(Name = "Sim")]
            Sim,
            [Display(Name = "Não")]
            Não
        }
     

    }
}
