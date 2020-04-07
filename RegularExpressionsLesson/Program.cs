using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RegularExpressions
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if(matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            #endregion
        }
    }
}
