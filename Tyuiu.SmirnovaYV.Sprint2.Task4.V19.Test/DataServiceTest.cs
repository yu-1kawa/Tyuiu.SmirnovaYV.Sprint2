using Tyuiu.SmirnovaYV.Sprint2.Task4.V19.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 36.754;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 3.750;
            Assert.AreEqual(wait, res);

        }

    }
}
