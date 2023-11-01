using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiYarismasi
{
    internal abstract class sorular
    {
        abstract public void Questions();
    }

    internal class soru1 : sorular
    {
        public override void Questions()
        {
            Console.WriteLine("1.Soru: Türkiyenin Başkenti Neresidir?");
            Console.WriteLine("");
            Console.WriteLine("A) İstanbul B) Ankara  C) İzmir  D) Diyarbakır");
        }
    }

    internal class soru2 : sorular
    {
        public override void Questions()
        {
            Console.WriteLine("2. Soru: İstanbulun  Plaka Kodu Kaçtır?");
            Console.WriteLine();
            Console.WriteLine("A) 21  B)36  C)34  D)10");
        }
    }

    internal class soru3 : sorular
    {
        public override void Questions()
        {
            Console.WriteLine("3. Ateşten Gömlek Kimin Eseridir?");
            Console.WriteLine();
            Console.WriteLine("A) Sagopa Kajmer  B) Halide Edip Adıvar");
            Console.WriteLine("C) Nâzım Hikmet  D) Necip Fazıl Kısakürek");
        }
    }
}
