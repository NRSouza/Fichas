using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fichas.Models;
using Fichas.ViewModel;
using Microsoft.EntityFrameworkCore;
using Fichas.SoaContext;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore.Internal;

namespace Fichas.Controllers
{
    public class BackofficeController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly DB_PRD_NRContext _SOAContext;
        private readonly ILogger<BackofficeController> _logger;

        public BackofficeController(ILogger<BackofficeController> logger,
            Data.ApplicationDbContext context,
            DB_PRD_NRContext SOAContext)
        {
            _context = context;
            _SOAContext = SOAContext;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> AcampantesLista(AcampantesLista A)
        {
            AcampantesLista AList = new AcampantesLista();
            AList.ListAcampante = await _context.Acampante.Where(e => e.codAcampante != null).OrderBy(x => x.Nome).ToListAsync();
            if (A.Acampante.Nome != null)
            {
                AList.ListAcampante = AList.ListAcampante.Where(e => e.Nome.ToUpper().Contains(A.Acampante.Nome.ToUpper())).ToList();
            } else if (A.Acampante.codAcampante != null)
            {
                AList.ListAcampante = AList.ListAcampante.Where(e => e.codAcampante == A.Acampante.codAcampante).ToList();
            } else if (A.Acampante.Equipe != null)
            {
                AList.ListAcampante = AList.ListAcampante.Where(e => e.Equipe == A.Acampante.Equipe).ToList();
            }
            else if (A.Acampante.Unidade != null)
            {
                AList.ListAcampante = AList.ListAcampante.Where(e => e.Unidade == A.Acampante.Unidade).ToList();
            }

            return View(AList);
        }
        [HttpGet]
        public async Task<IActionResult> AcampantesLista(string? retorno)
        {
            AcampantesLista AList = new AcampantesLista();
            AList.ListAcampante = await _context.Acampante.Where(e => e.codAcampante != null).OrderBy(x => x.Nome).ToListAsync();

            if (retorno != null)
            {
                ViewBag.RetornoTrue = retorno;
            }
            return View(AList);
        }
        //public async Task<IActionResult> SemAmigos()
        //{
        //    var AcampGeral = await _context.Acampante.AsNoTracking().ToListAsync();
        //    var RGeral = await _context.Responsavel.AsNoTracking().ToListAsync();
        //    List<AcampanteSemAmigos> Alist = new List<AcampanteSemAmigos>();
        //    AcampGeral.ForEach(e => {
        //        if (e.Amigos == null){
        //            AcampanteSemAmigos acamp = new AcampanteSemAmigos() {
        //                codAcampante = e.codAcampante,
        //                DesPacote = e.DesPacote,
        //                Nome = e.Nome,
        //                Equipe = e.Equipe,
        //                Unidade = e.Unidade,
        //                Responsavel = e.Responsavel
        //            };
        //            Alist.Add(acamp);
        //        }
        //    });
        //    Alist = Alist.OrderBy(x => x.Nome).ToList();
        //    return View(Alist);
        //}
        public async Task<IActionResult> SemAmigos()
        {
            var Alist = await _context.Acampante.AsNoTracking().ToListAsync();
            var AcampGeral = await _context.Acampante.AsNoTracking().ToListAsync();
            var AmigosGeral = await _context.Amigos.AsNoTracking().Select(e => e.Acampante).ToListAsync();
            Alist.RemoveAll(x => AmigosGeral.Exists(y => y.codAcampante == x.codAcampante));
            Alist = Alist.OrderBy(x => x.Nome).ToList();
            return View(Alist);
        }
        public async Task<IActionResult> RelatorioDramin()
        {
            List<Acampante> AcampantesAutorizados = await _context.Ficha.Where(e => e.Dramin == true || e.Vonal == true).Select(e => e.Acampante).ToListAsync();
            List<Ficha> Fichas = await _context.Ficha.AsNoTracking().ToListAsync();
            List<Ficha> Lista = new List<Ficha>();

            foreach (var item in AcampantesAutorizados)
            {
                Lista.Add(new Ficha()
                {
                    Acampante = item,
                    Vonal = await _context.Ficha.Where(e => e.Acampante == item).Select(e => e.Vonal).FirstOrDefaultAsync(),
                    Dramin = await _context.Ficha.Where(e => e.Acampante == item).Select(e => e.Dramin).FirstOrDefaultAsync()
                });
            }

            Lista = Lista.OrderBy(x => x.Acampante.Nome).ToList();
            return View(Lista);
        }
        public async Task<IActionResult> RelatorioKosher()
        {
            List<Acampante> AcampantesAutorizados = await _context.Ficha.Where(e => e.WeDoKosher == true || e.FreeKosher == true).Select(e => e.Acampante).ToListAsync();
            List<Ficha> Fichas = await _context.Ficha.AsNoTracking().ToListAsync();
            List<Ficha> Lista = new List<Ficha>();

            foreach (var item in AcampantesAutorizados)
            {
                Lista.Add(new Ficha()
                {
                    Acampante = item,
                    WeDoKosher = await _context.Ficha.Where(e => e.Acampante == item).Select(e => e.WeDoKosher).FirstOrDefaultAsync(),
                    FreeKosher = await _context.Ficha.Where(e => e.Acampante == item).Select(e => e.FreeKosher).FirstOrDefaultAsync()
                });
            }

            Lista = Lista.OrderBy(x => x.Acampante.Nome).ToList();
            return View(Lista);
        }
        public async Task<IActionResult> RelatorioBeliche()
        {
            List<Acampante> AcampantesAutorizados = await _context.Ficha.Where(e => e.BelicheInferior == true).Select(e => e.Acampante).ToListAsync();
            List<Ficha> Fichas = await _context.Ficha.AsNoTracking().ToListAsync();
            List<Ficha> Lista = new List<Ficha>();

            foreach (var item in AcampantesAutorizados)
            {
                Lista.Add(new Ficha()
                {
                    Acampante = item,
                    BelicheInferior = await _context.Ficha.Where(e => e.Acampante == item).Select(e => e.BelicheInferior).FirstOrDefaultAsync()
                });
            }

            Lista = Lista.OrderBy(x => x.Acampante.Nome).ToList();
            return View(Lista);
        }
        
        public async Task<IActionResult> AttDados()
        {
            var AcampanteGeral = await _context.Acampante.AsNoTracking().ToListAsync();
            var ResponsaveisGeral = await _context.Responsavel.AsNoTracking().ToListAsync();
            var PacotesAtivos = await _SOAContext.TbCadPacote.Where(e => e.FlgAtivo == "S").Select(e => e.CodPacote).ToListAsync();
            var Reservas = await _SOAContext.TbCadPessoapapelreserva.Where(e => e.FlgStatus == "F").ToListAsync();
            var IdAcampanteGeral = await _SOAContext.TbCadPessoaidacampante.AsNoTracking().ToListAsync();
            var fichaDat = await _SOAContext.TbCadPessoaficha.AsNoTracking().ToListAsync();
            var pessoaGeral = await _SOAContext.TbCadPessoa.AsNoTracking().ToListAsync();

            var ReservasAtivas = new List<TbCadPessoapapelreserva>();

            Reservas.ForEach(e =>
            {
                if (PacotesAtivos.Contains(e.CodPacote))
                {
                    ReservasAtivas.Add(e);
                }
            });
            foreach (var item in ReservasAtivas)
            {
                var acamp = AcampanteGeral.Where(e => e.codPessoa == item.CodPessoa).FirstOrDefault();
                if (acamp != null)
                {
                    acamp.codPacote = (int)item.CodPacote;
                    _context.Update(acamp);
                    await _context.SaveChangesAsync();
                }
            }
            foreach (var item in IdAcampanteGeral)
            {
                var acamp = AcampanteGeral.Where(e => e.codPessoa == item.CodPessoa).FirstOrDefault();
                if (acamp != null)
                {
                    acamp.codAcampante = item.CodPessoaidacampante.ToString();
                    _context.Update(acamp);
                    await _context.SaveChangesAsync();
                }
            }
            foreach (var item in pessoaGeral)
            {
                var resp = ResponsaveisGeral.Where(e => e.codResponsavel == item.CodPessoa).FirstOrDefault();
                if (resp != null)
                {
                    resp.Email = item.DesEmaillogin.ToString();
                    _context.Update(resp);
                    await _context.SaveChangesAsync();
                }
            }
            foreach (var item in fichaDat)
            {
                var acamp = AcampanteGeral.Where(e => e.codPessoa == item.CodPessoa).FirstOrDefault();
                if (acamp != null)
                {
                    acamp.DatNascto = item.DatNascto;
                    _context.Update(acamp);
                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction("AcampantesLista");
        }
        public async Task<IActionResult> EditaEquipe(Guid AcampID) 
        {
            Acampante A = await _context.Acampante.Where(e => e.ID == AcampID).FirstOrDefaultAsync();
            
            return View(A);
        }
        public async Task<IActionResult> DefinirEquipe(Acampante A)
        {
            Acampante Acamp = await _context.Acampante.Where(e => e.ID == A.ID).FirstOrDefaultAsync();
            Acamp.Equipe = A.Equipe;
            _context.Acampante.Update(Acamp);
            await _context.SaveChangesAsync();

            return RedirectToAction("AcampantesLista");
        }
        [HttpGet]
        public IActionResult Importar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Importar(IFormFile planilha)
        {
            try
            {
                string fileName = planilha.FileName;
                var filePath = Path.GetFullPath("Uploads\\" + fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await planilha.CopyToAsync(stream);
                }

                var Acamp = await Acampante.ReadImportExcel(fileName);
                var AcampGeral = await _context.Acampante.AsNoTracking().ToListAsync();

                foreach (var item in Acamp)
                {
                    var AttAcamp = AcampGeral.Where(e => e.codAcampante == item.codAcampante).FirstOrDefault();
                    if(AttAcamp != null)
                    {
                        AttAcamp.DesPacote = item.DesPacote;
                        AttAcamp.Equipe = item.Equipe;
                        AttAcamp.Unidade = item.Unidade;
                        _context.Acampante.Update(AttAcamp);

                    }
                }

                await _context.SaveChangesAsync();
                string retorno = "Equipes atualizadas";
                return RedirectToAction("AcampantesLista", new {retorno=retorno });
            }
            catch (Exception e)
            {
                ViewBag.Retorno = e.Message;
            } 

            return View();
        }
        public async Task<IActionResult> MsgsAcampante(Guid Acamp)
        {
            Acampante A = await _context.Acampante.Where(e => e.ID == Acamp).FirstOrDefaultAsync();
            List<Message> M = await _context.Message.Where(e => e.To == Acamp).ToListAsync();
            List<MensagensDoAcampante> Inbox = new List<MensagensDoAcampante>();
            var T = await _context.Terceiros.AsNoTracking().ToListAsync();

            ViewBag.Nome = A.Nome;

            foreach(var i in M)
            {
                var Terceiro = T.Where(e => e.ID == i.From).FirstOrDefault();

                Inbox.Add(new MensagensDoAcampante()
                {
                    MessageId = i,
                    To = A,
                    From = Terceiro,
                    CreateAt = i.CreateAt,
                    Msg = i.Msg,
                    ToSee = i.ToSee
                    });
            }    
            return View(Inbox);
        }
        public async Task<IActionResult> ImpressaoLote1()
        {
            //lista de não lidas
            List<Message> M = await _context.Message.Where(e=>e.ToSee == null).ToListAsync();
            List<Acampante> A = await _context.Acampante.Where(e=>e.FlgImpressao && e.Unidade == "1").ToListAsync();
            List<Terceiros> T = await _context.Terceiros.AsNoTracking().ToListAsync();
            List<Message> ParaImpressao = new List<Message>();
            List<ImpressaoLote>  Lista = new List<ImpressaoLote>();
            foreach (var item in M)
            {
                if (A.Select(e => e.ID).Contains(item.To))
                {
                    ParaImpressao.Add(item);
                }
            }
            foreach (var item in ParaImpressao)
            {
                Acampante acamp = A.Where(e => e.ID == item.To).FirstOrDefault();
                Terceiros terc = T.Where(e => e.ID == item.From).FirstOrDefault();
                var ParaImpressao1 = new ImpressaoLote() {
                    Message = item,
                    Acampante = acamp,
                    Terceiro = terc
                };
                Lista.Add(ParaImpressao1);
                item.ToSee = DateTime.Now;
                _context.Message.Update(item);
            }
            await _context.SaveChangesAsync();
            return View(Lista);
        }
        public async Task<IActionResult> ImprimirIndividual(Guid MessageId)
        {
            Message M = await _context.Message.Where(e => e.ID == MessageId).FirstOrDefaultAsync();
            Acampante A = await _context.Acampante.Where(e => e.ID == M.To).FirstOrDefaultAsync();
            Terceiros T = await _context.Terceiros.Where(e => e.ID == M.From).FirstOrDefaultAsync();
            ImpressaoLote Impressao = new ImpressaoLote()
            {
                Message = M,
                Acampante = A,
                Terceiro = T
            };

            return View(Impressao);
        }
        public async Task<IActionResult> ImpressaoLote2()
        {
            //lista de não lidas
            List<Message> M = await _context.Message.Where(e => e.ToSee == null).ToListAsync();
            List<Acampante> A = await _context.Acampante.Where(e => e.FlgImpressao && e.Unidade == "2").ToListAsync();
            List<Terceiros> T = await _context.Terceiros.AsNoTracking().ToListAsync();
            List<Message> ParaImpressao = new List<Message>();
            List<ImpressaoLote> Lista = new List<ImpressaoLote>();
            foreach (var item in M)
            {
                if (A.Select(e => e.ID).Contains(item.To))
                {
                    ParaImpressao.Add(item);
                }
            }
            foreach (var item in ParaImpressao)
            {
                Acampante acamp = A.Where(e => e.ID == item.To).FirstOrDefault();
                Terceiros terc = T.Where(e => e.ID == item.From).FirstOrDefault();
                var ParaImpressao2 = new ImpressaoLote()
                {
                    Message = item,
                    Acampante = acamp,
                    Terceiro = terc
                };
                Lista.Add(ParaImpressao2);
                item.ToSee = DateTime.Now;
                _context.Message.Update(item);
            }
            await _context.SaveChangesAsync();
            return View(Lista);
        }
    }
}