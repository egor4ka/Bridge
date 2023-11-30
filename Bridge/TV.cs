using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : IRemoteImplementor
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }
        public void SetPower(int power)
        {
            Console.WriteLine($"Мощность телевизора: {power}");
        }
        public void SetMode(int mode)
        {
            Console.WriteLine($"Канал:  {mode}");
        }
    }
}
