using Exchange.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Api
{
  public  interface ICurrencyService
    {
        Task<CurrencyModel[]> GetToday();
        Task<CurrencyModel[]> Post(CurrencyModel model);
    }

}
