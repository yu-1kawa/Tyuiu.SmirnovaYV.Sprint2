using Tyuiu.SmirnovaYV.Sprint2.Task7.V6.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#2                                                                 *");
            Console.WriteLine("* Тема: добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные            *");
            Console.WriteLine("*и вычисляет,находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите значение переменной Х: ");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds=new DataService();
            bool res =ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
