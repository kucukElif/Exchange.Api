using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Api.Serializer
{
   public interface IXmlSerializer
    {
        T Deserializer<T>(string value);
        string Serializer(object value);
    }

   
}
