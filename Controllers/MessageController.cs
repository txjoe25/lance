using System;

using Microsoft.AspNetCore.Mvc;
using Joe.Factories;
using Joe.Models;

namespace Joe.Controllers
{
    public class MessageController : Controller
    {
        private readonly MessageFactory _messageFactory;
        
        public MessageController(MessageFactory messageFactory)
        {
            _messageFactory = messageFactory;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        [Route("GuestBook")]
           public IActionResult Add(Message model)
        {
           
           
            if(ModelState.IsValid)
            {
                 Console.WriteLine(model.Name);
                 Console.WriteLine("  Thanks for the Note!  ");
                _messageFactory.Add(model);
                
                return RedirectToAction("GuestBook", model); 
            }
            ViewBag.Errors = ModelState.Values;
            return View("Index");
        }
        [HttpGet]
        [Route("GuestBook")]
        public IActionResult GuestBook()
        {
            var user = _messageFactory.GetUserById();
            var allmessages = _messageFactory.All();
            ViewBag.allmessages = allmessages;
            return View();
        }
       
    }
}
