using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbRptLogCartaoSistema
    {
        public string Sistema { get; set; }
        public string Funcionalidade { get; set; }
        public string Acao { get; set; }
        public string Portador { get; set; }
        public string Email { get; set; }
        public string Cartao { get; set; }
        public int? Parcelas { get; set; }
        public decimal? ValorParcela { get; set; }
        public decimal? ValorTotal { get; set; }
        public string Tid { get; set; }
        public string Transacao { get; set; }
        public string Status { get; set; }
        public string Gateway { get; set; }
        public string QtdCartao { get; set; }
        public string Ip { get; set; }
        public string Escola { get; set; }
        public long? CodPedido { get; set; }
        public string Evento { get; set; }
        public int? Usuario { get; set; }
        public DateTime? Data { get; set; }
        public string Hora { get; set; }
    }
}
