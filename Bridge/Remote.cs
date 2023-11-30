using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Remote
    {
        protected IRemoteImplementor implementor { get; private set; }
        public int Power { get; set; }
        public int Mode { get; set; }
        public Remote(IRemoteImplementor implementor)
        {
            this.implementor = implementor;
        }
        public void On()
        {
            implementor.On();
        }
        public void Off()
        {
            implementor.Off();
        }
        public virtual void PowerPlus()
        {
            implementor.SetPower(++Power);
        }
        public virtual void PowerMinus()
        {
            implementor.SetMode(++Mode);
        }
        public virtual void ModeNext()
        {
            implementor.SetMode(++Mode);
        }
        public virtual void ModePreview()
        {
            implementor.SetMode(--Mode);
        }
    }
}
