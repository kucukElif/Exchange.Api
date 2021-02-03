using Exchange.Api;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyService service;
        public HomeController()
        {
            service = new CurrencyService();
        }
        //get Currency
        public async Task<IActionResult> Index()
        {
            var result = await service.GetToday();
            return View();
        }
    }
}
