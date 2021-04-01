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

namespace Fichas.Controllers
{
    public class MessageController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly DB_PRD_NRContext _SOAContext;
        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger,
            Data.ApplicationDbContext context,
            DB_PRD_NRContext SOAContext)
        {
            _context = context;
            _SOAContext = SOAContext;
            _logger = logger;
        }

        public IActionResult Index()
        {            
            return View();
        }
        public async Task<JsonResult> BuscaAcamp(string Cod, string Dat)
        {
            var DatNascto = DateTime.Parse(Dat);
            var acamp = await _context.Acampante.Where(e => e.codAcampante == Cod && e.DatNascto == DatNascto).FirstOrDefaultAsync();
            
            return Json(acamp);
        }
        public async Task<IActionResult> EnviaMsgParaAcampante(Message M)
        {
            M.CreateAt = DateTime.Now;
            M.ToSee = null;
            M.From = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");
            var pessoasGeral = await _SOAContext.TbCadPessoa.AsNoTracking().ToListAsync();

            //_context.Message.Add(M);
            //await _context.SaveChangesAsync();

            return View("Index");
        }
    }
}
