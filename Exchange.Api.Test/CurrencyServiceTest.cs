using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Exchange.Api.Test
{
  public  class CurrencyServiceTest
    {
        private readonly ICurrencyService service;
        public CurrencyServiceTest()
        {
            service = new CurrencyService();
        }
        [Fact]
        public async void Get_Today()
        {
            var result = await service.GetToday();
            Assert.True(condition: result.Length > 0);
        }

        [Fact]
        public async void Get_Currencies_By_Date()
        {
            var result = await service.GetByDate(new DateTime(year:2020,month:9,day:8));
            Assert.True(condition: result.Length > 0);
        }
    }
}
