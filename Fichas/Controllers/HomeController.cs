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
        public async Task<IActionResult> Ficha(int CodResponsavel = 405808,
            int CodAcampante = 410749)
        {
            Ficha F = new Ficha();

            //CHECA SE A PESSOA JA POSSUI FICHA
            Responsavel R = await _context.Responsavel.Where(e=>e.codResponsavel == CodResponsavel).FirstOrDefaultAsync();
            Acampante A = await _context.Acampante.Where(e=>e.codPessoa == CodAcampante).FirstOrDefaultAsync();
            var SoaResp = await _SOAContext.TbCadPessoa.Where(e => e.CodPessoa == CodResponsavel).FirstOrDefaultAsync();
            var SoaAcamp = await _SOAContext.TbCadPessoa.Where(e => e.CodPessoa == CodAcampante).FirstOrDefaultAsync();
            var SoaCodAcamp = await _SOAContext.TbCadPessoaidacampante.Where(e => e.CodPessoa == CodAcampante).FirstOrDefaultAsync();
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
                _context.Ficha.Add(F);
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
                    _context.Ficha.Add(F);
                    ViewBag.resp = R;
                    ViewBag.acamp = NovoAcamp;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    F = await _context.Ficha.Where(e => e.Acampante == acamp).FirstOrDefaultAsync();
                    ViewBag.resp = R;
                    ViewBag.acamp = acamp;
                }
            }

            return View(F);
        }
        [HttpPost]
        public async Task<IActionResult> Ficha(Ficha Ficha)
        {


            _context.Ficha.Update(Ficha);
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
