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
        private bool? salvo;

        public MessageController(ILogger<MessageController> logger,
            Data.ApplicationDbContext context,
            DB_PRD_NRContext SOAContext)
        {
            _context = context;
            _SOAContext = SOAContext;
            _logger = logger;
        }

        public async Task<IActionResult> IndexTerceiros(bool?salvo=null)
        {
            Guid IdLogado = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");
            MessageAcampante AmigosLogado = new MessageAcampante();
            List<AmigosDoTerceiro> ListaTerceiros = await _context.Amigos.Where(e => e.Terceiros.ID == IdLogado).OrderBy(y => y.Acampante.Nome).Select(x => new AmigosDoTerceiro {
                Acampante = x.Acampante,
                Terceiros = x.Terceiros
            }).ToListAsync();

            List<Message> NaoLidas = await _context.Message.Where(e => e.To == IdLogado && e.ToSee==null).ToListAsync();

            MessageAcampante ListaDeAmigosDoTerceiro = new MessageAcampante();
            ListaDeAmigosDoTerceiro.AmigosDoTerceiro = ListaTerceiros;
            ListaDeAmigosDoTerceiro.NaoLidas = NaoLidas;

            if (salvo != null)
            {
                ViewBag.retorno = (bool)salvo ? "Mensagem enviada com sucesso!" : "Houve um erro ao enviar sua mensagem, tente novamente mais tarde";
                ViewBag.style = (bool)salvo ? "green" : "red";
            }

            return View(ListaDeAmigosDoTerceiro);
        }
        public IActionResult AddAmigoTerceiro()
        {
            return View();
        }

        public async Task<JsonResult> BuscaAcamp(string Cod, string Dat)
        {
            var DatNascto = Dat.Split("/");
            int Day = int.Parse(DatNascto[0]);
            int Month = int.Parse(DatNascto[1]);
            
            var acamp = await _context.Acampante.Where(e => e.codAcampante == Cod && e.DatNascto.Value.Day == Day && e.DatNascto.Value.Month == Month).FirstOrDefaultAsync();

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
            try{

                _context.Message.Add(M);
                await _context.SaveChangesAsync();
                salvo = true;
            }
            catch (Exception)
            {
                salvo = false;
            }

            return RedirectToAction("IndexTerceiros", new { salvo = salvo });
        }
        public async Task<IActionResult> InboxTerceiros(Guid A)
        {
            Terceiros TerceiroLogado = new Terceiros();
            var idLogado = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");
            TerceiroLogado = await _context.Terceiros.Where(e => e.ID == idLogado).FirstOrDefaultAsync();
            List<Message> MessagesTerceiro = await _context.Message.Where(e => e.To == TerceiroLogado.ID).ToListAsync();
            List<MensagensDoTerceiro> Inbox = new List<MensagensDoTerceiro>();
            var msgGeral = await _context.Message.AsNoTracking().ToListAsync();

            var acampGeral = await _context.Acampante.AsNoTracking().ToListAsync();

            foreach (var item in MessagesTerceiro)
            {
                if(item.From == A)
                {
                    var Acamp = acampGeral.Where(e => e.ID == A).FirstOrDefault();
                    var msg = msgGeral.Where(e => e.ID == item.ID).FirstOrDefault();

                    Inbox.Add(new MensagensDoTerceiro()
                    {
                        MessageId = msg,
                        To = TerceiroLogado,
                        From = Acamp,
                        CreateAt = item.CreateAt,
                        Msg=item.Msg,
                        ToSee = item.ToSee
                    });
                }
            }
            return View(Inbox);
        }
        public async Task<IActionResult> VisualizaMsg(Guid MessageId)
        {

            Message mensagem = await _context.Message.Where(e=>e.ID==MessageId).FirstOrDefaultAsync();
            mensagem.ToSee = DateTime.Now;
            _context.Message.Update(mensagem);
            await _context.SaveChangesAsync();
            return View(mensagem);
        }
        public async Task<IActionResult> OutboxTerceiros(Guid A)
        {
            Terceiros TerceiroLogado = new Terceiros();
            var idLogado = Guid.Parse("FFF5A43F-D45C-4725-8CCA-C45DADF122E4");
            TerceiroLogado = await _context.Terceiros.Where(e => e.ID == idLogado).FirstOrDefaultAsync();
            List<Message> MessagesAcampante = await _context.Message.Where(e => e.From == TerceiroLogado.ID).ToListAsync();
            List<MensagensDoAcampante> Outbox = new List<MensagensDoAcampante>();

            var acampGeral = await _context.Acampante.AsNoTracking().ToListAsync();
            var msgGeral = await _context.Message.AsNoTracking().ToListAsync();
            foreach (var item in MessagesAcampante)
            {
                if (item.To == A)
                {
                    var Acamp = acampGeral.Where(e => e.ID == A).FirstOrDefault();
                    var msg = msgGeral.Where(e => e.ID == item.ID).FirstOrDefault();
                    Outbox.Add(new MensagensDoAcampante()
                    {
                        MessageId= msg,
                        To = Acamp,
                        From = TerceiroLogado,
                        CreateAt = item.CreateAt,
                        Msg = item.Msg,
                        ToSee = item.ToSee
                    });
                }
            }
            return View(Outbox);
        }
    }
}
