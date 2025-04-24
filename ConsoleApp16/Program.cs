using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        delegate void Message(); //1.Объявляю делегат
        static void Main(string[] args)
        {
            Message message; //2.Создаем переменную делегата
            message = Hello;//3.Присваиваем этой переменной адрес метода
            if(DateTime.Now.Hour<=12)
            {
                Console.WriteLine("Доброе утро");
            }
            else
            {
                Console.WriteLine("Добрый вечер");
            }
            message();//4.Вызываем метод
            Message message1;
            message1 = GoodBye;
            message1();
            Console.Read();
        }
        static public void Hello() => Console.WriteLine("Привет");
        static public void GoodBye() => Console.WriteLine("Досвидания");
    }
}
