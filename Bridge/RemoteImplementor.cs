using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteImplementor
    {
        public void On() { }
        public void Off() { }
        public void SetPower(int power) { }
        public void SetMode(int mode) { }
    }
}
