using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exchange.Api.Models
{
    public class CurrencyModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public int Unit { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public string CrossRateUsd { get; set; }
        [Column(TypeName = "decimal(18,4)")]

        public decimal ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string BankNoteBuying { get; set; }
        public string BanknoteSelling { get; set; }

        public static CurrencyModel Map(Tarih_DateCurrency x)
        {
            return new CurrencyModel
            {
                Unit = x.Unit,
                Name = x.CurrencyName,
                CurrencyCode = x.CurrencyCode,
                BanknoteSelling = x.BanknoteSelling,
                BankNoteBuying = x.BanknoteBuying,
                ForexSelling = x.ForexSelling,
                CrossRateUsd = x.CrossRateUSD
            };

        }
    }
}
