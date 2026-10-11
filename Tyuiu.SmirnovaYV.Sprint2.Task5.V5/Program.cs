using Tyuiu.SmirnovaYV.Sprint2.Task5.V5.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: оператор switch                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("*  требуемое значение и возвращает результат.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер карты:");
            int numCard = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numCard<6)||(numCard>14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это карта: " + ds.FindCardValue(numCard);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine( res);
            Console.ReadKey();
        }
    }
}
