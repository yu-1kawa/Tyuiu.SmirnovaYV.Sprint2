using Tyuiu.SmirnovaYV.Sprint2.Task2.V14.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadeArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res=ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
