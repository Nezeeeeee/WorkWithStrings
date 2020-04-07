using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Ёмкость строки: {sb.Capacity}");
            sb.Replace("мир", "Зилибоба!");
            Console.WriteLine(sb);
            #endregion
        }
    }
}
