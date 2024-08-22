using Microsoft.AspNetCore.Mvc;
using Messages.Models;
namespace Messages.Controllers
{
    public class MessageController : Controller
    {

        // Lista estática para armazenar as mensagens
        private static List<Message> messages = new List<Message>();

        public IActionResult Index()
        {
            return View();
        }

         [HttpGet]
        public IActionResult Info()
        {
            return View(messages);
        } 

        [HttpPost]
        public IActionResult Index(Message message)
        {
            message.Date = DateTime.Now;
            // Adiciona a nova mensagem à lista
            messages.Add(message);

            // Passa a lista de mensagens para a view
            return View(messages);
        }
    }
}