using Tyuiu.SmirnovaYV.Sprint2.Task4.V19.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds=new DataService();
            Console.Title = "Спринт #2| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: Тренарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тренарного оператора, где пользователь вводит значение х,у.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
