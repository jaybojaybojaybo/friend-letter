using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;
using System.Collections.Generic;

namespace FriendLetter.Controllers
      {
        public class HomeController : Controller
        {
          [Route("/letter")]
          public ActionResult Letter()
          {
            return View();
          }
          [Route("/journal")]
          public ActionResult journal()
          {
            return View();
          }
          [Route("/greeting_card")]
          public ActionResult GreetingCard()
          {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Hello", myLetterVariable);
          }
          [Route("/")]
           public ActionResult Form()
           {
             return View();
           }
        }
      }
