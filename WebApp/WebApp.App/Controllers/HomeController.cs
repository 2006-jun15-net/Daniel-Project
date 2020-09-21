using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.App.Models;
using WebApp.Library.Ciphers;

namespace WebApp.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Shift_Cipher _shift_Cipher;
        public HomeController(ILogger<HomeController> logger, Shift_Cipher shift_Cipher)
        {
            _shift_Cipher = shift_Cipher ?? throw new ArgumentNullException(nameof(shift_Cipher));
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Encode(TextBoxValue text)
        {
            string Cipher = text.Cipher(text.Key);
            
            //Shift_Cipher
            //if (Cipher[0] == 'A')
           // {
                int shift = text.Shift_Cipher_Number(Cipher);

                //add logic for repeat of the cypher
                string nkey = Cipher;
                string _value = _shift_Cipher.Encode(text.Value, shift);
                nkey += $"A{shift}";
            // }

            //temp
            nkey = text.Key + "A4";
            //finish
            var newText = new TextBoxValue() { Value = _value, Key = nkey };
            ModelState.Clear();

            return View("Index", newText);
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
