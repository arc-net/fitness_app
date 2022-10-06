using fitness_app.BL.Controller;
using fitness_app.BL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness");
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.WriteLine("Введите пол: ");
                var gender = Console.ReadLine();
                var birthDate = ParseDateTime();
                var weight = ParseDouble("вес");
                var height = ParseDouble("рост");


                userController.SetNewUserData(gender, birthDate, weight, height);

            }

            Console.WriteLine(userController.CurrentUser);

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("Е - ввести прием пищи");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.E)
            {
                EnterEating();
            }

            Console.ReadLine();


        }

        private static (Food, double) EnterEating()
        {
            Console.WriteLine("Введите имя продукта: ");
            var food = Console.ReadLine();

            Console.WriteLine("Введите калорийность: ");

            var weight = ParseDouble("Вес порции");
            var product = new Food(food);

            return (product, weight);
        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.WriteLine("Введите дату рождения: ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты рождения");
                }
            }  

            return birthDate;
        }

        private static double ParseDouble(string name)

        {

            while (true)
            {
                Console.WriteLine($"Введите {name}: ");
                if (Double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат поля {name}");
                }
            }
        }
    }
}
