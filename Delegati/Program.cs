using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        static void Main(string[] args)
        {
            //Делегаты -button 1. ctor, methods, prop.
            Button smallButton = new Button
            {
                Width = 20,
                Height = 20,
                Text = "Нажми меня"
            };
            smallButton.RegisterButtonDelegate(new ClickButtonDelegate(Hz));

            Button mediumButton = new Button
            {
                Width = 40,
                Height = 40,
                Text = "Нажми меня сильнее"
            };


            Button bigButton = new Button
            {
                Width = 100,
                Height = 100,
                Text = "Ударь меня"
            };
        }
        public static void Hz(OutButtonEventArgs args)
        {
            Console.WriteLine("AAAA!Меня нажали!");
        }
    }
}
