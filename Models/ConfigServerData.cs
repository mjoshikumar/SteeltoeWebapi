using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Model
{

    /// <summary>
    /// An object used with the DI Options mechanism for exposing the data retrieved 
    /// from the Spring Cloud Config Server
    /// </summary>
    public class ConfigServerData
    {
        public string app { get; set; }
        public string config { get; set; }
        public string data { get; set; }
        public string message { get; set; }
    }
}
