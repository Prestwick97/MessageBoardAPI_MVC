// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoardClient.Models;

namespace MessageBoardClient.Controllers
{
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
        var allMessages = Message.GetMessages();
        return View(allMessages);
        }
    }

    
}