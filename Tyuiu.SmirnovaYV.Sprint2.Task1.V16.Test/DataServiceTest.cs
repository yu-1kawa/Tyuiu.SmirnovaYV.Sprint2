using Tyuiu.SmirnovaYV.Sprint2.Task1.V16.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VailidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;
            bool[] res = new bool[6];
            res =ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
