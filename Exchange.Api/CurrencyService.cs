using Exchange.Api.Models;
using Exchange.Api.Models.Context;
using Exchange.Api.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Api
{
    public class CurrencyService : ICurrencyService
    {
        private string urlPattern = "https://www.tcmb.gov.tr/kurlar/{0}.xml";
        private readonly WebClient client;
        private readonly IXmlSerializer serializer;
        private readonly AppDbContext context;

        public CurrencyService(  )
        {
            client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            serializer = new XmlSerializer();
            context = new AppDbContext();
        }
        
      

        public Task<CurrencyModel[]> GetToday()
        {
            var url = new Uri(string.Format(urlPattern, "today"));
            var data = client.DownloadString(url);
            var deserialize = serializer.Deserializer<Tarih_Date>(data);
            var result = deserialize.Currency.Select(CurrencyModel.Map).ToArray();
            return Task.FromResult(result);
        }

        public Task<CurrencyModel[]> Post(CurrencyModel model)
        {
            var url = new Uri(string.Format(urlPattern, "today"));
            var data = client.DownloadString(url);
            var deserialize = serializer.Deserializer<Tarih_Date>(data);
            var result = deserialize.Currency.Select(CurrencyModel.Map).ToArray();
            context.CurrencyModels.Add(model);
            context.SaveChanges();
            return Task.FromResult(result);
        }



    }
    }
