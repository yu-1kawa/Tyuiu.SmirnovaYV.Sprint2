using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SmirnovaYV.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x==2)
            {
                y = Math.Round(x + (15.0 / x), 3);
            }
            else
            {
                if (x>0)
                {
                    y = Math.Round(Math.Exp(x) - 12 * x + Math.Cos(x), 3);
                    
                }
                else
                {
                    if ((x>-5)&&(x<3))
                    {
                        y = Math.Round(x + 10 * x - (1 / x), 3);
                    }
                    else
                    {
                        if (x<-5)
                        {
                            y = Math.Round(x + 10 * x - (1 / (Math.Pow(x, 3) + 3)), 3);
                        }
                    }
                }
            }
            return y;
        }
    }
}
