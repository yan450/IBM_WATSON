using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class JsonHelper
    {
        public static string SerializeObject<T>(T o)
        {
            var json = JsonConvert.SerializeObject(o);
            return json;
        }

        public static T DeserializeObject<T>(string jsonString)
        {
            var obj = JsonConvert.DeserializeObject<T>(jsonString);
            return obj;
        }
    }
}
