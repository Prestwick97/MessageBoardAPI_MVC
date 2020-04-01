// using System;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoardClient.Models;
using System.ComponentModel;
using System;

namespace MessageBoardClient.Controllers
{
  public class MessagesController : Controller
  {
    public IActionResult Index()
    {
      var allMessages = Message.GetMessages();
      return View(allMessages);
    }

    public IActionResult Groups()
    {
      var allMessages = Message.GetMessages().OrderBy(message => message.Group);
      return View(allMessages);
    }
    public IActionResult Create()
    {
      var allMessages = Message.GetMessages().OrderBy(message => message.Group);
      return View(allMessages);
    }

    [HttpPost]
    public IActionResult Create(Message message)
    {
      Console.WriteLine(message);

      foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(message))
      {
        string name = descriptor.Name;
        object value = descriptor.GetValue(message);
        Console.WriteLine("{0}={1}", name, value);
      }
      Message.Post(message);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var message = Message.GetDetails(id);
      return View(message);
    }

    public IActionResult GroupMessages(string groupName)
    {
      var groupMessages = Message.GetGroupMessages(groupName);
      return View(groupMessages);
    }
  }
}