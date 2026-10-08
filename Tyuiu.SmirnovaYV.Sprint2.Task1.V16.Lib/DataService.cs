using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SmirnovaYV.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c);
            res[1] = (a + 572 > b) & (d < c);
            res[2] = (a > b) | (d < c);
            res[3] = (a + 571 > b) & (d < c);
            res[4] = !(!res[0]);
            res[5] = (a <= b) ^ (d < c);
            return res;
        }
    }
}