using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PR_17
{
    class Utensil // Класс "Посуда"
    {
        int y;
        int quantity1; // кол-во стаканов
        int quantity2; // кол-во бокалов
        double Calculate1() // расчет, если стаканов больше, чем бокалов
        {
            double calculation1 = quantity1 - quantity2;
            return calculation1;
        }

        double Calculate2() // расчет, если бокалов больше, чем стаканов
        {
            int calculation2 = quantity2 - quantity1;
            return calculation2;
        }

        double Calculate_sum() // расчет суммы
        {
            int calculation_sum = quantity2 + quantity1;
            return calculation_sum;
        }
        void GetInfo() // метод вывода данных (расчет*)
        {
            if (y == 1)
            {
                if (quantity1 == quantity2) Console.WriteLine($"\nСравнение/разница: стаканов столько же, сколько и бокалов. (" + quantity1 + " шт.)\n");
                else
                {
                    if (quantity1 > quantity2) Console.WriteLine($"\nСравнение/разница: стаканов больше, чем бокалов, на {Calculate1()}" + " шт.\n");
                    else Console.WriteLine($"\nСравнение/разница: бокалов больше, чем стаканов, на {Calculate2()}" + " шт.");
                }
            }

            else Console.WriteLine($"\nСумма: Если сложить кол-во бокалов и стаканов, общее кол-во посуды составляет {Calculate_sum()}" + " шт.\n");
        }
        void SetInfo() // метод ввода данных
        {
            Console.WriteLine("\n\nВведите данные о посуде:\n");

            Console.Write("Количество стаканов: ");
            quantity1 = Int32.Parse(Console.ReadLine());

            Console.Write("Количество бокалов: ");
            quantity2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nРабота с посудой:");

            Console.WriteLine("\nНажмите 1, чтобы сравнить/найти разницу, или 2, чтобы сложить и найти общее кол-во посуды.\n");
            y = Convert.ToInt32(Console.ReadLine()); // ввод с клавиатуры*
            GetInfo();
        }
        ~Utensil() // деструктор для проверки*
        {
            Console.WriteLine("\nДеструктор сработал.");
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // ввод значения для продолжения цикла
            do // цикл
            {
                try
                {
                    Console.Clear();

                    Utensil utensil = new Utensil();
                    Console.WriteLine("\nДобро пожаловать... Практическая работа №17");
                    utensil.SetInfo(); // переход к методу вводу данных
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nВозникла ошибка: " + e.Message); // вывод типа ошибки при наличии таковой
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nНажмите 1, чтобы завершить работу, или 2, чтобы продолжить.\n");
                x = Convert.ToInt32(Console.ReadLine()); // ввод с клавиатуры*
            }
            while (x == 2);
            Console.WriteLine("\nЗавершение работы. Спасибо, что использовали эту программу.");
            Console.ReadKey(); // задержка экрана консоли
        }
    }
}

// Необходимо использовать инкапсуляцию*