using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernyak_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Черняк Оксана Александровна, АЭМ-111");
            Console.WriteLine(Reverse(57));
            Console.WriteLine(Reverse('a'));
            Console.WriteLine(Reverse("abcd"));
            Console.WriteLine(Reverse(173.12));
            Console.WriteLine(Reverse(new object()));
            Console.ReadKey();
        }

        private static string Reverse<T>(T obj)
        {
            if (obj == null) return "";
            string str = obj.ToString();
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            return rev;
        }
    }
}