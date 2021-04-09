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

        public async Task<IActionResult> IndexTerceiros()
        {
            Guid IdLogado = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");
            MessageAcampante AmigosLogado = new MessageAcampante();
            List<AmigosDoTerceiro> ListaTerceiros = await _context.Amigos.Where(e => e.Terceiros.ID == IdLogado).OrderBy(y=>y.Acampante.Nome).Select(x => new AmigosDoTerceiro {
                Acampante = x.Acampante,
                Terceiros = x.Terceiros
            }).ToListAsync();
            MessageAcampante ListaDeAmigosDoTerceiro = new MessageAcampante();
            ListaDeAmigosDoTerceiro.AmigosDoTerceiro = ListaTerceiros;


            //AmigosLogado.Amigos = ListaTerceiros.Count > 0 ? ListaTerceiros : ListaAcampante;

            return View(ListaDeAmigosDoTerceiro);
        }
        public async Task<JsonResult> BuscaAcamp(string Cod, string Dat)
        {
            var DatNascto = DateTime.Parse(Dat);
            var acamp = await _context.Acampante.Where(e => e.codAcampante == Cod && e.DatNascto == DatNascto).FirstOrDefaultAsync();

            return Json(acamp);
        }
        public async Task<IActionResult> AddAmigo(MessageAcampante F)
        {
            F.From = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");

            Amigos A = new Amigos();
            Acampante Acamp = await _context.Acampante.Where(e => e.ID == F.To).FirstOrDefaultAsync();
            Terceiros T = await _context.Terceiros.Where(e => e.ID == F.From).FirstOrDefaultAsync();

            A.Acampante = Acamp;
            A.Terceiros = T;
            _context.Amigos.Add(A);
            await _context.SaveChangesAsync();

            return RedirectToAction("IndexTerceiros");
        }
        public async Task<IActionResult> TerceiroSendMsg(MessageAcampante msgform) 
        {
            Terceiros TerceiroLogado = new Terceiros();
            TerceiroLogado.ID = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");

            Message M = new Message();
            M.CreateAt = DateTime.Now;
            M.From = TerceiroLogado.ID;
            M.Msg = msgform.Msg;
            M.To = msgform.To;

            _context.Message.Add(M);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("IndexTerceiros");
        }
        public async Task<IActionResult> InboxTerceiros()
        {
            Terceiros TerceiroLogado = new Terceiros();
            TerceiroLogado.ID = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");
            List<Message> Inbox= await _context.Message.Where(e => e.To == TerceiroLogado.ID).ToListAsync();
            //List<MensagensDoTerceiro> Inbox = new List<MensagensDoTerceiro>();

            //MessagesTerceiro.ForEach(x =>
            //{
            //    Inbox.Add(new MensagensDoTerceiro() { 
            //        To = x.to.,
            //        From=x.From
            //    } );
            //});
            return View(Inbox);
        }
        //[HttpPost]
        //public async Task<IActionResult> Inbox()
        //{

        //}
    }
}
