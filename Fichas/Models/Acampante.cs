using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data;
using System.IO;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;

namespace Fichas.Models
{
    public class Acampante : Entity
    {
        public int codPessoa { get; set; }
        public string? codAcampante { get; set; }
        public Responsavel Responsavel { get; set; }
        public int? codPacote { get; set; }
        public string DesPacote { get; set; }
        public string Nome { get; set; }
        public bool FichaRespondida { get; set; }
        public bool FlgWhatsApp { get; set; }
        public bool FlgImpressao { get; set; }
        public string Equipe { get; set; }
        public string Unidade { get; set; }
        public DateTime? DatNascto { get; set; }
        public List<Amigos> Amigos { get; set; }

        public async static Task<List<Acampante>> ReadImportExcel(string fileName)
        {
            var t = Task.Run(() =>
            {
                var xmlFile = Path.Combine(Environment.CurrentDirectory, "Uploads\\" + fileName);
                var wb = new XLWorkbook(xmlFile);
                var ws = wb.Worksheet("Base");

                var firstRowUsed = ws.FirstRowUsed();
                var categoryRow = firstRowUsed.RowUsed();
                categoryRow = categoryRow.RowBelow();

                var firstPossibleAddress = ws.Row(firstRowUsed.RowNumber()).FirstCell().Address;
                var lastPossibleAddress = ws.LastCellUsed().Address;

                var produtosRange = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();
                var produtosTable = produtosRange.AsTable();

                var dataList = new List<string[]>
                {
                    produtosTable.DataRange.Rows()
                        .Select(produtoRow => produtoRow.Field("Código").GetString())
                        .ToArray(),
                    produtosTable.DataRange.Rows()
                        .Select(produtoRow => produtoRow.Field("Acampante").GetString())
                        .ToArray(),
                    produtosTable.DataRange.Rows()
                        .Select(produtoRow => produtoRow.Field("Equipe").GetString())
                        .ToArray(),
                    produtosTable.DataRange.Rows()
                        .Select(produtoRow => produtoRow.Field("Pacote").GetString())
                        .ToArray(),
                    produtosTable.DataRange.Rows()
                        .Select(produtoRow => produtoRow.Field("Unidade").GetString())
                        .ToArray(),
                };

                List<Acampante> A = new List<Acampante>();

                for (int i = 0; dataList[0].Count() > i; i++)
                {
                    Acampante a = new Acampante
                    {
                        codAcampante = dataList[0][i],
                        Nome = dataList[1][i],
                        Equipe = dataList[2][i],
                        DesPacote = dataList[3][i],
                        Unidade = dataList[4][i]
                    };
                    A.Add(a);
                };

                return A;
            });

            return await t;

        }
    }
}
