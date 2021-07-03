using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fichas.Models;
using Fichas.ViewModel;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Fichas.SoaContext;
using System.IO;

namespace Fichas.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly DB_PRD_NRContext _SOAContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            Data.ApplicationDbContext context,
            DB_PRD_NRContext SOAContext)
        {
            _context = context;
            _SOAContext = SOAContext;
            _logger = logger;
        }

        public async Task<bool> Adicionar(Ficha f)
        {
            _context.Ficha.Add(f);

            await _context.SaveChangesAsync();

            return true;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> UpdFlgWhats(int id, bool flg)
        {
            var acampante = await _context.Acampante.Where(e => e.codPessoa == id).FirstOrDefaultAsync();
            acampante.FlgWhatsApp = flg;
            try
            {
                _context.Update(acampante);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var msg = e.Message;
                return msg;
            }

            return "ok";
        }
        public async Task<IActionResult> ImprimirFichaIndividual(int CodResponsavel, int CodAcampante)
        {
            Responsavel R = await _context.Responsavel.Where(e => e.codResponsavel == CodResponsavel).FirstOrDefaultAsync();
            Acampante A = await _context.Acampante.Where(e => e.codPessoa == CodAcampante).FirstOrDefaultAsync();
            Ficha F = new Ficha();
            F = await _context.Ficha.Where(e => e.Responsavel == R && e.Acampante == A).FirstOrDefaultAsync();

            return View(F);

        }
        public async Task<IActionResult> ExportarExcelFicha()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("RelatorioFicha");
                var currentRow = 1;

                // REGION HEADER
                worksheet.Cell(currentRow, 1).Value = "NomeResponsavel";
                worksheet.Cell(currentRow, 2).Value = "NomeAcampante";
                worksheet.Cell(currentRow, 3).Value = "Pacote";
                worksheet.Cell(currentRow, 4).Value = "Msg Enviada?";
                worksheet.Cell(currentRow, 5).Value = "Ficha Preenchida?";
                worksheet.Cell(currentRow, 6).Value = "Celular";
                // END REGION

                var Pacotes = await _SOAContext.TbCadPacote.Where(e => e.FlgAtivo == "S").Select(e => e.CodPacote).ToListAsync();
                var Reservas = await _SOAContext.TbCadPessoapapelreserva.Where(e => e.FlgStatus == "F").ToListAsync();
                var ReservasAtivas = new List<TbCadPessoapapelreserva>();
                var grid = new AcampanteResponsavel();
                var GridList = new List<AcampanteResponsavel>();

                Reservas.ForEach(e =>
                {
                    if (Pacotes.Contains(e.CodPacote))
                    {
                        ReservasAtivas.Add(e);

                        AcampanteResponsavel ar = new AcampanteResponsavel
                        {
                            CodResponsavel = e.CodResponsavel,
                            CodAcampante = e.CodPessoa,
                        };

                        GridList.Add(ar);
                    }
                });

                // HORA DA CAGADA
                var pessoasGeral = await _SOAContext.TbCadPessoa.AsNoTracking().ToListAsync();
                var telefoneGeral = await _SOAContext.TbCadPessoafichatelefone.AsNoTracking().ToListAsync();
                var AcampFicha = await _context.Acampante.AsNoTracking().ToListAsync();

                //Acampante Acamp = await _context.Acampante.Where(e=>e.codPessoa == )
                var acpGeral = await _context.Acampante.AsNoTracking().ToListAsync();
                foreach (var item in GridList)
                {
                    var tel = telefoneGeral.Where(x => x.CodPessoa == item.CodResponsavel && x.CodTipotelefone == 1).FirstOrDefault();
                    var acp = pessoasGeral.Where(x => x.CodPessoa == item.CodAcampante).FirstOrDefault();
                    var resp = pessoasGeral.Where(x => x.CodPessoa == item.CodResponsavel).FirstOrDefault();
                    var ficharesp = acpGeral.Where(x => x.codPessoa == item.CodAcampante).FirstOrDefault();
                    var Whats = AcampFicha.Where(x => x.codPessoa == item.CodAcampante).FirstOrDefault();

                    item.ExisteAcampante = Whats == null ? false : true;



                    item.NomAcampante = acp.NomPessoa;
                    item.DesPacote = ficharesp is null ? null : ficharesp.DesPacote;
                    item.FichaRespondida = ficharesp is null ? false : ficharesp.FichaRespondida;
                    item.FlgWhatsApp = item.ExisteAcampante == false ? false : Whats.FlgWhatsApp;
                    item.Telefone = tel.DesDdd + tel.NumTelefone;
                    item.NomResponsavel = resp.NomPessoa;
                }
                var Lista = GridList.OrderBy(o => o.NomAcampante).ToList();
                foreach (var item in Lista)
                {
                    currentRow++;

                    worksheet.Cell(currentRow, 1).Value = item.NomResponsavel;
                    worksheet.Cell(currentRow, 2).Value = item.NomAcampante;
                    worksheet.Cell(currentRow, 3).Value = item.DesPacote;
                    worksheet.Cell(currentRow, 4).Value = item.FlgWhatsApp;
                    worksheet.Cell(currentRow, 5).Value = item.FichaRespondida;
                    worksheet.Cell(currentRow, 6).Value = item.Telefone;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "RelatorioFicha.xlsx");
                }
            }
        }
        public async Task<IActionResult> FichasPorPacote(string pacote)
        {
            List<Acampante> AcampantesAutorizados = await _context.Acampante.Where(e => e.DesPacote == pacote).ToListAsync();
            List<Ficha> Fichas = await _context.Ficha.AsNoTracking().ToListAsync();
            List<Ficha> Lista = new List<Ficha>();

            foreach (var item in AcampantesAutorizados)
            {
                Ficha F =  await _context.Ficha.Where(e => e.Acampante.ID == item.ID).FirstOrDefaultAsync();
                if(F != null) { 
                    F.Acampante = item;
                    Lista.Add(F);
                }
            }

            Lista = Lista.OrderBy(x => x.Acampante.Nome).ToList();
            return View(Lista);
        }
        [HttpGet]
        public async Task<IActionResult> Backoffice(string AuthToken)
        {
            if (AuthToken == "a7e47f6b5973c52cd00bf6fe257dae8de77810167df7a9d67ef898de29f21d86")
            {
                //var SoaAcampantes = await _SOAContext.TbCadPessoa.Where(e => e.FlgAtivo == "S").FirstOrDefaultAsync();
                var Pacotes = await _SOAContext.TbCadPacote.Where(e => e.FlgAtivo == "S").Select(e => e.CodPacote).ToListAsync();
                var Reservas = await _SOAContext.TbCadPessoapapelreserva.Where(e => e.FlgStatus == "F").ToListAsync();
                var ReservasAtivas = new List<TbCadPessoapapelreserva>();
                var grid = new AcampanteResponsavel();
                var GridList = new List<AcampanteResponsavel>();

                Reservas.ForEach(e =>
               {
                   if (Pacotes.Contains(e.CodPacote)) {
                       ReservasAtivas.Add(e);

                       AcampanteResponsavel ar = new AcampanteResponsavel
                       {
                           CodResponsavel = e.CodResponsavel,
                           CodAcampante = e.CodPessoa,
                       };

                       GridList.Add(ar);
                   }
               });

                // HORA DA CAGADA
                var pessoasGeral = await _SOAContext.TbCadPessoa.AsNoTracking().ToListAsync();
                var telefoneGeral = await _SOAContext.TbCadPessoafichatelefone.AsNoTracking().ToListAsync();
                var AcampFicha = await _context.Acampante.AsNoTracking().ToListAsync();

                //Acampante Acamp = await _context.Acampante.Where(e=>e.codPessoa == )
                var acpGeral = await _context.Acampante.AsNoTracking().ToListAsync();
                foreach (var item in GridList)
                {
                    var tel = telefoneGeral.Where(x => x.CodPessoa == item.CodResponsavel && x.CodTipotelefone == 1).FirstOrDefault();
                    var acp = pessoasGeral.Where(x => x.CodPessoa == item.CodAcampante).FirstOrDefault();
                    var resp = pessoasGeral.Where(x => x.CodPessoa == item.CodResponsavel).FirstOrDefault();
                    var ficharesp = acpGeral.Where(x => x.codPessoa == item.CodAcampante).FirstOrDefault();
                    var Whats = AcampFicha.Where(x => x.codPessoa == item.CodAcampante).FirstOrDefault();

                    item.ExisteAcampante = Whats == null ? false : true;

                    item.NomAcampante = acp.NomPessoa;
                    item.DesPacote = ficharesp is null ? null : ficharesp.DesPacote;
                    item.FichaRespondida = ficharesp is null ? false : ficharesp.FichaRespondida;
                    item.FlgWhatsApp = item.ExisteAcampante == false ? false : Whats.FlgWhatsApp;
                    item.Telefone = tel.DesDdd + tel.NumTelefone;
                    item.NomResponsavel = resp.NomPessoa;
                }
                GridList = GridList.OrderBy(o => o.DesPacote).ToList();

                // FIM DA HORA DA CAGADA

                return View(GridList);
            }
            else
            {
                return Ok();
            }

        }
        public async Task<IActionResult> SelecionaPacote()
        {
            List<string> pacotes = await _context.Acampante.Where(e => e.DesPacote != null).Select(e=>e.DesPacote).Distinct().ToListAsync();

            return View(pacotes);
        }
        public async Task<IActionResult> ImprimirLoteFicha()
        {
            List<Ficha> FichaGeral = await _context.Ficha.AsNoTracking().ToListAsync();
            var AcampGeral = await _context.Ficha.AsNoTracking().ToListAsync();

            foreach(var item in FichaGeral)
            {
                Acampante Acamp = _context.Ficha.Where(e => e.ID == item.ID).Select(i=>i.Acampante).FirstOrDefault();
                item.Acampante = Acamp;
            }

            var F = FichaGeral.OrderBy(e => e.Acampante.Nome).ToList();
            return View(F);
        }
        [HttpGet]
        public async Task<IActionResult> Ficha(int CodResponsavel, int CodAcampante)
        {
            Ficha F = new Ficha();

            if (CodResponsavel != 0) {


                //CHECA SE A PESSOA JA POSSUI FICHA
                Responsavel R = await _context.Responsavel.Where(e => e.codResponsavel == CodResponsavel).FirstOrDefaultAsync();
                Acampante A = await _context.Acampante.Where(e => e.codPessoa == CodAcampante).FirstOrDefaultAsync();
                var SoaResp = await _SOAContext.TbCadPessoa.Where(e => e.CodPessoa == CodResponsavel).FirstOrDefaultAsync();
                var SoaAcamp = await _SOAContext.TbCadPessoa.Where(e => e.CodPessoa == CodAcampante).FirstOrDefaultAsync();
                var SoaCodAcamp = await _SOAContext.TbCadPessoaidacampante.Where(e => e.CodPessoa == CodAcampante).FirstOrDefaultAsync();
                ViewBag.Dat = "";

                //se o responsavel NAO EXISTE consequentemente o Acampante também não existe
                if (R == null)
                {
                    //Cria o Responsavel e o Acampante
                    Responsavel resp = new Responsavel();
                    resp.codResponsavel = CodResponsavel;
                    resp.Nome = SoaResp.NomPessoa;

                    Acampante acamp = new Acampante();
                    acamp.codPessoa = CodAcampante;
                    acamp.Nome = SoaAcamp.NomPessoa;
                    acamp.codAcampante = SoaCodAcamp == null ? null : SoaCodAcamp.CodPessoaidacampante.ToString();

                    if (SoaCodAcamp == null)
                    {
                        acamp.codAcampante = null;
                    }
                    else
                    {
                        acamp.codAcampante = SoaCodAcamp.CodPessoaidacampante.ToString();
                    }
                    acamp.Responsavel = resp;

                    F.Responsavel = resp;
                    F.Acampante = acamp;

                    _context.Responsavel.Add(resp);
                    _context.Acampante.Add(acamp);
                    await _context.SaveChangesAsync();

                    ViewBag.resp = resp;
                    ViewBag.acamp = acamp;
                }
                else
                {
                    //se o responsavel foi criado ele possui um acampante
                    Acampante acamp = await _context.Acampante.Where(e => e.Responsavel == R && e.codPessoa == CodAcampante).FirstOrDefaultAsync();
                    //caso se trate de um segundo acampante, cria-lo
                    if (acamp == null)
                    {
                        Acampante NovoAcamp = new Acampante();
                        NovoAcamp.codPessoa = CodAcampante;
                        NovoAcamp.Nome = SoaAcamp.NomPessoa;
                        NovoAcamp.codAcampante = SoaCodAcamp == null ? null : SoaCodAcamp.CodPessoaidacampante.ToString();
                        NovoAcamp.Responsavel = R;
                        F.Responsavel = R;
                        F.Acampante = NovoAcamp;

                        _context.Acampante.Add(NovoAcamp);
                        ViewBag.resp = R;
                        ViewBag.acamp = NovoAcamp;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        F = await _context.Ficha.Where(e => e.Acampante == acamp).FirstOrDefaultAsync();
                        ViewBag.resp = R;
                        //ViewBag.Dat = "Ultima alteração - " + F.DatAtt.ToString("dd/MM/yyyy h:mm tt");
                        ViewBag.acamp = acamp;
                    }
                }
            }
            else
            {
                return Ok();
            }

            return View(F);
        }
        [HttpPost]
        public async Task<IActionResult> Ficha(Ficha Ficha, string respID, string acampID)
        {
            //verifica se o acampante é dependente desse responsavel
            Acampante acamp = await _context.Acampante.Where(e => e.ID.ToString() == acampID).FirstOrDefaultAsync();
            Responsavel resp = await _context.Responsavel.Where(e => e.ID.ToString() == respID).FirstOrDefaultAsync();
            Ficha F = await _context.Ficha.Where(e => e.Acampante == acamp).FirstOrDefaultAsync();
            ViewBag.resp = resp;
            ViewBag.acamp = acamp;
            ViewBag.ok = "";
            ViewBag.error = "";
            ViewBag.Dat = "";

            if (F == null)
            {
                Ficha.Responsavel = resp;
                Ficha.Acampante = acamp;
                Ficha.Acampante.FichaRespondida = true;
                Ficha.DatAtt = DateTime.Now;
                ViewBag.ok = "Ficha cadastrada com sucesso!";
                ViewBag.Dat = "Última alteração - " + Ficha.DatAtt.ToString("dd/MM/yyyy h:mm tt");

                _context.Ficha.Add(Ficha);
            } else {
                Ficha.Responsavel = resp;
                Ficha.Acampante = acamp;
                Ficha.Acampante.FichaRespondida = true;
                Ficha.DatAtt = DateTime.Now;
                _context.Ficha.Add(Ficha);
                _context.Ficha.Remove(F);
                ViewBag.Dat = "Última alteração - " + Ficha.DatAtt.ToString("dd/MM/yyyy h:mm tt");

                ViewBag.ok = "Ficha alterada com sucesso!";
            }

            await _context.SaveChangesAsync();

            await AtualizaDados(acamp);

            return View(Ficha);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task AtualizaDados(Acampante acamp) 
        {
            var fichaDat = await _SOAContext.TbCadPessoaficha.Where(e => e.CodPessoa.ToString() == acamp.codPessoa.ToString()).FirstOrDefaultAsync();
            var IdAcampanteGeral = await _SOAContext.TbCadPessoaidacampante.Where(e=>e.CodPessoa.ToString() == acamp.codPessoa.ToString()).FirstOrDefaultAsync();
            if(IdAcampanteGeral != null)
            {
                acamp.codAcampante = IdAcampanteGeral.CodPessoaidacampante.ToString();
            }
            acamp.DatNascto = fichaDat.DatNascto;
            _context.Update(acamp);
            await _context.SaveChangesAsync();

        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
