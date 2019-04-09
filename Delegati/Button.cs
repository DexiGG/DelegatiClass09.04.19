using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    public delegate void ClickButtonDelegate(OutButtonEventArgs args);
    public class Button
    {
        private ClickButtonDelegate clickButtonDelegate;

        //Если не нужен механизм multicastDelegate полностью
        //public ClickButtonDelegate ClickButtonDelegate { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
    
        public void RegisterButtonDelegate(ClickButtonDelegate clickButtonDelegate)
        {
            //Delegate.Combine(this.clickButtonDelegate, clickButtonDelegate);
            this.clickButtonDelegate += clickButtonDelegate;
        }

        public void UnregisterButtonDelegate(ClickButtonDelegate clickButtonDelegate)
        {
            //Delegate.Remove(this.clickButtonDelegate, clickButtonDelegate);
            this.clickButtonDelegate -= clickButtonDelegate;
        }

        public void Click()
        {
            //При нажатии изменяем размер и цвет если надо
            //if (clickButtonDelegate != null)
            //    clickButtonDelegate(new OutButtonEventArgs());
            clickButtonDelegate?.Invoke(new OutButtonEventArgs());
            //clickButtonDelegate.Invoke(new OutButtonEventArgs()); одно и тоже
        }
    }
}
