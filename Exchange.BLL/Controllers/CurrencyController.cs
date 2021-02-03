using Exchange.Api;
using Exchange.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange.BLL.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService service;

        public CurrencyController( )
        {
            service = new CurrencyService();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurrencyModel>>> GetLastCurrencies()
        {
            return await service.GetToday();

        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<CurrencyModel>>> PostData(CurrencyModel currencyModel)
        {
            return await service.Post(currencyModel);

        }

    }
}
