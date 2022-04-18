using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timofey_Utils
{
    public class Utils

    {
        public static void PrintInfo(int Age, string name, string Profesia)
        {
            Console.WriteLine($"Ваш возраст{Age}");
            Console.WriteLine($" Ваше имя{name}");
            
            Console.WriteLine($"Ваша профессия{Profesia}");
        }
    }
}
