using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_03.Models
{
    public class Request
    {
        private int _timeInSystem;


        public Request()
        {
            _timeInSystem = 0;
        }


        public void IncTime()
        {
            _timeInSystem++;
        }


        public int TimeInSystem => _timeInSystem;
    }
}
