using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesDI
{
    public class Service : IService
    {
        int _counter = 0;
        public string Message()
        {
            _counter += 1;
            return "Message from service, counter count ->  " + _counter;
        }
    }
}
