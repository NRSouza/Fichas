using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fichas.Models;
using Microsoft.EntityFrameworkCore;
using Fichas.SoaContext;

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
        [HttpGet]
        public async Task<IActionResult> Ficha(int CodResponsavel, int CodAcampante)
        {
            if (CodResponsavel == 0){
                CodResponsavel = 408013; 
            }
            if (CodAcampante == 0) {
                CodAcampante = 411703; 
            }

            Ficha F = new Ficha();

            //CHECA SE A PESSOA JA POSSUI FICHA
            Responsavel R = await _context.Responsavel.Where(e=>e.codResponsavel == CodResponsavel).FirstOrDefaultAsync();
            Acampante A = await _context.Acampante.Where(e=>e.codPessoa == CodAcampante).FirstOrDefaultAsync();
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
                if(acamp == null)
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
                    ViewBag.Dat = "Ultima alteração - " + F.DatAtt.ToString("dd/MM/yyyy h:mm tt");
                    ViewBag.acamp = acamp;
                }
            }
            return View(F);
        }
        [HttpPost]
        public async Task<IActionResult> Ficha(Ficha Ficha,string respID , string acampID)
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
                if (acamp.Responsavel.ID == resp.ID)
                {
                    Ficha.Responsavel = resp;
                    Ficha.Acampante = acamp;
                    Ficha.Acampante.FichaRespondida = true;
                    Ficha.DatAtt = DateTime.Now;
                    ViewBag.ok = "Ficha cadastrada com Sucesso!";
                    ViewBag.Dat = "Ultima alteração - "+Ficha.DatAtt.ToString("dd/MM/yyyy h:mm tt");

                    _context.Ficha.Add(Ficha);
                }
                else{ 
                    ViewBag.error = "Houve um erro ao processar sua solicitação tente novamente.";
                }
            }else {
                Ficha.Responsavel = resp;
                Ficha.Acampante = acamp;
                Ficha.Acampante.FichaRespondida = true;
                Ficha.DatAtt = DateTime.Now;
                _context.Ficha.Add(Ficha);
                _context.Ficha.Remove(F);
                ViewBag.Dat = "Ultima alteração - " + Ficha.DatAtt.ToString("dd/MM/yyyy h:mm tt");

                ViewBag.ok = "Ficha alterada com sucesso!";
            }

            await _context.SaveChangesAsync();     
            return View(Ficha);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
