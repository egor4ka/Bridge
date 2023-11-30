using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteT : Remote
    {
        private Dictionary<int, (int Power, int Mode)> _dictionary = new Dictionary<int, (int Power, int Mode)>();
        public void Save(int index)
        {
            _dictionary[index] = (Power, Mode);
            Console.WriteLine($"Сохраненный режим: {index} (Мощность--> {Power} Канал--> {Mode})");
        }
        public void Load(int index)
        {
            if (_dictionary.ContainsKey(index))
            {
                var dictionary = _dictionary[index];
                implementor.SetPower(Power);
                implementor.SetMode(Mode);
                Console.WriteLine($"Загруженный режим: {index} (Мощность--> {Power} Канал--> {Mode})");
            }
            else
            {
                Console.WriteLine($"Режим {index} не найден");
            }
        }
        public RemoteT(IRemoteImplementor implementor) : base(implementor)
        {
            if (implementor == null)
            {
                throw new ArgumentNullException(nameof(implementor), "Пустое значение.");
            }
        }
    }
}
