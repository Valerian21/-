using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы__классы
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetMess();//Надпись результат
            int sum = GetSum();//сумма 2х чисел 

            Console.WriteLine(message); 
            Console.WriteLine(sum); 
            Console.ReadKey();
            user user = new user() 
            {
                Name = "Ваелериан",
                Surname = "Пляскина",
                Login = "Vlr",
                Password = "qwerty",

            };
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine(); //Вводим логин и пароль
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();
            user.AuthorizeUser(login,password); //Авторизируем
            Console.ReadLine();

        }

        static string GetMess() 
        {
            return "Результат";
        }
        static int GetSum()
        {
            Console.WriteLine("Введите x");             //Тут и там мы вводим числа, которые надо суммировать
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            return x + y;       //Сумма
        }

    }
    class user
    {
        public string Surname;          
        public string Name;

        public string Login;
        public string Password;

        public void AuthorizeUser(string login, string password)
        { 
        if (Login == login || Password==password) //Если пароль и логин совпали, то
            {
                Console.WriteLine("Вы успешно авторизовались");
            }
            else
            {       //Если пароль и логин не совпали, то
                Console.WriteLine("Авторизация не удалась");

            }
        }
    }
}
