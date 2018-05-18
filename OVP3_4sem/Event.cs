using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVP3_4sem
{
    class Event 
    {
        public delegate void ChangeX();

        public event ChangeX Change;
    }
}
