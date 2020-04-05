using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Concat
            //string s1 = "hello";
            //string s2 = "world";
            //string s3 = s1 + " " + s2; //Результат строка: hello world
            //string s4 = String.Concat(s3, "!!!"); //Результат строка: hello world!!!
            //Console.WriteLine(s4);
            #endregion

            #region Concat Join
            //string s5 = "apple";
            //string s6 = "a day";
            //string s7 = "keeps";
            //string s8 = "a doctor";
            //string s9 = "away";
            //string[] values = new string[] { s5, s6, s7, s8, s9 };
            //String s10 = String.Join(" ", values);
            //Console.WriteLine(s10); //результат : строка "apple a day keeps a doctor away"
            #endregion

            #region Сравнение строк метод Compare
            //string s1 = "hello";
            //string s2 = "world";
            //int result = String.Compare(s1, s2);
            //if(result < 0)
            //{
            //    Console.WriteLine("Строка s1 перед стройкой s2");
            //}
            //else if(result > 0)
            //{
            //    Console.WriteLine("Строка s1 стоит после строки s2");
            //}
            //else
            //{
            //    Console.WriteLine("Строки s1 и s2 идентичны");
            //}
            ////Результатом будет "Строка s1 перед строкой s2"

            ///*Данная версия метода Compare принимает две строки и возвращает число. Если первая строка по алфавиту стоит выше второй, 
            // *то возвращается число меньше нуля. В противном случае возвращается число больше нуля. И третий случай - если строки равны, 
            // *то возвращается число 0.В данном случае так как символ h по алфавиту стоит выше символа w, то и первая строка будет стоять выше.*/
            #endregion

            #region Поиск в строке
            ////С помощью метода IndexOf мы можем определить индекс первого вхождения отдельного символа или подстроки в строке

            //string s1 = "hello world";
            //char ch = 'o';
            //int indexOfChar = s1.IndexOf(ch); //равно 4 
            //Console.WriteLine(indexOfChar);

            //string subString = "wor";
            //int indexOfSubstring = s1.IndexOf(subString); // равно 6
            //Console.WriteLine(indexOfSubstring);
            ////Подобным образом действует метод LastIndexOf, только находит индекс последнего вхождения символа или подстроки в строку.
            #endregion

            #region разделение строк
            //string text = "И поэтому все так произошло";
            //string[] words = text.Split(new char[] { ' ' });
            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Обрезка строки
            //string text = " hello world ";

            //text = text.Trim(); //Результат "hello world"
            //text = text.Trim(new char[] { 'd', 'h' }); //Результат "ello worl"

            #endregion

            #region Вставка
            //Для вставки одной строки в другую применяется функция Insert
            //string text = "Хороший день";
            //string subString = "замечательный ";

            //text = text.Insert(8, subString);
            //Console.WriteLine(text);
            ///*Первым параметром в функции Insert является индекс, по которому надо вставлять подстроку, 
            // *а второй параметр - собственно подстрока.*/
            #endregion

            #region удаление строк
            ////Удалить часть строки помогает метод Remove

            //string text = "Хороший день";
            ////Индекс последнего символа
            //int ind = text.Length - 1;
            ////Вырезаем последний символ
            //text = text.Remove(ind);
            //Console.WriteLine(text);

            ////вырезаем первые два символа
            //text = text.Remove(0, 2);

            ///*Первая версия метода Remove принимает индекс в строке, начиная с которого надо удалить все символы. 
            // *Вторая версия принимает еще один параметр - сколько символов надо удалить.*/
            #endregion

            #region Замена
            ////Чтобы заменить один символ или подстроку на другую, применяется метод Replace
            //string text = "хороший день";

            //text = text.Replace("хороший", "не очень");
            //Console.WriteLine(text);

            //text = text.Replace("o", "");
            //Console.WriteLine(text);
            #endregion

            #region Смена регистра
            ////Для приведения строки к верхнему и нижнему регистру используются соответственно функции ToUpper() и ToLower()
            //string hello = "Hello world!";
            //Console.WriteLine(hello.ToLower()); // hello world!
            //Console.WriteLine(hello.ToUpper()); // HELLO WORLD!
            #endregion
        }
    }
}
