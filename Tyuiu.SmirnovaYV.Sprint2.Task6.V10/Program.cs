using Tyuiu.SmirnovaYV.Sprint2.Task6.V10.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число месяца:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            if ((d<1)||(d>31)||(m<1)||(m>12)||(g<=0))
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Результат:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Введено неверное значение                                               *");
            }
            else
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Результат:                                                              *");
                Console.WriteLine("***************************************************************************");
                string res = "Предыдущая дата: " + ds.FindDateOfPreviousDay(g, m, d);
                Console.WriteLine(res);
            }
                
            Console.ReadKey();
        }
    }
}
