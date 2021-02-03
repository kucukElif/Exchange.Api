using Exchange.Api;
using Exchange.Api.Models;
using Exchange.Api.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BLL.Controllers
{
    [System.Web.Http.Route("api/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICurrencyService service;

        public ValuesController()
        {
            service = new CurrencyService();
        }

        [System.Web.Http.HttpGet]
        public async Task<ActionResult<IEnumerable<CurrencyModel>>> GetLastCurrencies()
        {
            return await service.GetToday();

        }
        //[System.Web.Http.HttpPost]
        //public async Task<ActionResult<IEnumerable<CurrencyModel>>> Post(CurrencyModel entity)
        //{
        //    context.Add(entity);
        //    context.SaveChanges();
        //    return await service.GetToday();
        //}
      
    }
}
