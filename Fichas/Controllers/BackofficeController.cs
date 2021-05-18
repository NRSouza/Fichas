//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using Fichas.Models;
//using Fichas.ViewModel;
//using Microsoft.EntityFrameworkCore;
//using Fichas.SoaContext;

//namespace Fichas.Controllers
//{
//    public class BackofficeController : Controller
//    {
//        private readonly Data.ApplicationDbContext _context;
//        private readonly DB_PRD_NRContext _SOAContext;
//        private readonly ILogger<BackofficeController> _logger;

//        public BackofficeController(ILogger<BackofficeController> logger,
//            Data.ApplicationDbContext context,
//            DB_PRD_NRContext SOAContext)
//        {
//            _context = context;
//            _SOAContext = SOAContext;
//            _logger = logger;
//        }
//        public async Task<IActionResult> AcampantesLista()
//        {
//            List<Acampante> A = await _context.Acampante.Where(e => e.codAcampante != null).OrderBy(x => x.Nome).ToListAsync();

//            return View(A);
//        }
//        public async Task<IActionResult> EditaEquipe(Guid AcampID) 
//        {
//            Acampante A = await _context.Acampante.Where(e => e.ID == AcampID).FirstOrDefaultAsync();
            
//            return View(A);
//        }
//        public async Task<IActionResult> DefinirEquipe(Acampante A)
//        {
//            Acampante Acamp = await _context.Acampante.Where(e => e.ID == A.ID).FirstOrDefaultAsync();
//            Acamp.Equipe = A.Equipe;
//            _context.Acampante.Update(Acamp);
//            await _context.SaveChangesAsync();

//            return RedirectToAction("AcampantesLista");
//        }
//        public async Task<IActionResult> MsgsAcampante(Guid Acamp)
//        {
//            Acampante A = await _context.Acampante.Where(e => e.ID == Acamp).FirstOrDefaultAsync();
//            List<Message> M = await _context.Message.Where(e => e.To == Acamp).ToListAsync();
//            List<MensagensDoAcampante> Inbox = new List<MensagensDoAcampante>();
//            //TerceirosGeral
//            var T = await _context.Terceiros.AsNoTracking().ToListAsync();

//            ViewBag.Nome = A.Nome;

//            foreach(var i in M)
//            {
//                var Terceiro = T.Where(e => e.ID == i.From).FirstOrDefault();

//                Inbox.Add(new MensagensDoAcampante()
//                {
//                    MessageId = i,
//                    To = A,
//                    From = Terceiro,
//                    CreateAt = i.CreateAt,
//                    Msg = i.Msg,
//                    ToSee = i.ToSee
//                    });
//            }    
//            return View(Inbox);
//        }
//        //public async Task<IActionResult> ImpressaoLote()
//        //{
//            //List<Acampante> A = await _context.Acampante.Where(e => e.FlgImpressao == true).OrderBy(x => x.Nome).ToListAsync();
//            //var T = await _context.Terceiros.AsNoTracking().ToListAsync();
//            //var msgGeral = await _context.Message.AsNoTracking().ToListAsync();
//            //List<Message> M = await _context.Message.Where(e => e.To == Acamp).ToListAsync();
//            //List<MensagensDoAcampante> Inbox = new List<MensagensDoAcampante>();
//            ////TerceirosGeral

//            //foreach (var i in M)
//            //{
//            //    var Terceiro = T.Where(e => e.ID == i.From).FirstOrDefault();

//            //    Inbox.Add(new MensagensDoAcampante()
//            //    {
//            //        MessageId = i,
//            //        To = A,
//            //        From = Terceiro,
//            //        CreateAt = i.CreateAt,
//            //        Msg = i.Msg,
//            //        ToSee = i.ToSee
//            //    });
//            //}
//            //return View(A);
//        //}
//    }
//}