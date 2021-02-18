using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fichas.Models;
using Microsoft.EntityFrameworkCore;


namespace Fichas.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly ModelsSoa.SOAContext _SOAContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            Data.ApplicationDbContext context,
            ModelsSoa.SOAContext SOAContext)
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
        public IActionResult Ficha(int cod_responsavel, int cod_acampante)
        {
            Ficha F = new Ficha();
            //var soaPessoa = await _SOAContext.Tb_Cad_Pessoa.ToListAsync(); //teste
            Acampante acamp = new Acampante();
            Responsavel resp = new Responsavel();
            acamp.codPessoa = cod_acampante;
            resp.codResponsavel = cod_responsavel;
            resp.Nome = "NOME RESPONSAVEL";
            acamp.Nome = "NOME ACAMPANTE";

            ViewBag.resp = resp;
            ViewBag.acamp = acamp;

            return View(F);
        }
        [HttpPost]
        public async Task<IActionResult> Ficha(Ficha Ficha)
        {
            string ViewResult;
            Acampante acamp = new Acampante();
            Responsavel resp = new Responsavel();
            resp.Nome = "NOME RESPONSAVEL";
            acamp.Nome = "NOME ACAMPANTE";

            ViewBag.resp = resp;
            ViewBag.acamp = acamp;
            try
            {
                _context.Ficha.Add(Ficha);
                await _context.SaveChangesAsync();
                ViewResult = "Success";

            }
            catch (Exception e)
            {
                string Message = e.Message;
                ViewBag.erro = Message;
                ViewResult = "Error";

            }

            return View(ViewResult);
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
