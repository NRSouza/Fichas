﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Ficha : Entity
    {
        public Guid ID { get; set; } 
        public Responsavel Responsavel { get; set; }
        public Acampante Acampante { get; set; }
        public Double Peso { get; set; }
        public Double Altura { get; set; }
        public string Tip_Sanguineo { get; set; }
        public string Convenio { get; set; }
        public string Nome_Pediatra_Contato { get; set; }
        public bool Nadar { get; set; }
        public bool Boia { get; set; }
        public bool Acomp_Psicologico { get; set; }
        public string Motivo_Acomp_Psicologico { get; set; }
        public bool Vacinas_Validas { get; set; }
        public bool H1N1{ get; set; }
        public DateTime Dat_H1N1 { get; set; }
        public bool MenigiteC { get; set; }
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
        public bool Convulsao { get; set; }
        public bool Asma { get; set; }
        public bool Bronquite { get; set; }
        public bool Infeccao_Recente { get; set; }
        public bool Enurese_Noturna { get; set; }
        public bool Sonambulismo { get; set; }
        public bool RestricaoAttFisica { get; set; }
        public string Obs_RestricaoAttFisica { get; set; }
        public bool Alergia_Medicamento { get; set; }
        public string Obs_Alergia_Medicamento { get; set; }
        public bool Necessidade_Especial { get; set; }
        public string Obs_Necessidade_Especial { get; set; }
        public bool Restricao_Alimentar { get; set; }
        public string Obs_Restricao_Alimentar { get; set; }
        public bool Medo_Fobia { get; set; } 
        public string Obs_Medo_Fobia { get; set; } 
        public string OcorrenciaMedica { get; set; } 
        public string Obs_Geral { get; set; }

    }
}