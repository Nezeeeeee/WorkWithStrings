using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formattingAndInterpolationOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Форматирование строк
            ////При выводе строк в консоли с помощью метода Console.WriteLine мы можем применять форматирование вместо конкатенации
            //Person person = new Person { Name = "Adam", Age = 26 };
            //Console.WriteLine("Имя: {0} Возраст: {1}",person.Name, person.Age);

            #endregion

            #region Интерполяция строк
            Person person = new Person { Name = "Bill", Age = 33 };
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
            #endregion
        }
    }
    #region Форматирование строк
    //class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    #endregion

    #region Интерполяция строк
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion
}
