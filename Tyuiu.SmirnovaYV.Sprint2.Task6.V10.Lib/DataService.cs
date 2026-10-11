using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SmirnovaYV.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n>1)
            {
                return (n-1) + "." + m + "." + g;
            }
            else
            {
                int DayInPrrevMonth= m switch
                {
                    1 => 31,
                    2 => 31,
                    3 => 28,
                    4 => 31,
                    5 => 30,
                    6 => 31,
                    7 => 30,
                    8 => 31,
                    9 => 31,
                    10 => 30,
                    11 => 31,
                    12 => 30,
                    _ => 30
                };
                n = DayInPrrevMonth;
                if (m==1)
                {
                    g = g - 1;
                    m = 12;
                }
                else
                {
                    m = m - 1;
                }
                return n + "." + m + "." + g;
            }

        }
    }
}
