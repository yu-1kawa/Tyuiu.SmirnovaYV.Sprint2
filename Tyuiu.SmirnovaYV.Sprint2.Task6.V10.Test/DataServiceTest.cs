using Tyuiu.SmirnovaYV.Sprint2.Task6.V10.Lib;
namespace Tyuiu.SmirnovaYV.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds=new DataService();
            Assert.AreEqual("15.5.2024", ds.FindDateOfPreviousDay(2024, 5, 16));
            Assert.AreEqual("28.2.2023", ds.FindDateOfPreviousDay(2023, 3, 1));
            Assert.AreEqual("31.12.2023", ds.FindDateOfPreviousDay(2024, 1, 1));
            Assert.AreEqual("30.4.2024", ds.FindDateOfPreviousDay(2024, 5, 1));
            Assert.AreEqual("30.11.2024", ds.FindDateOfPreviousDay(2024, 12, 1));
            
        }
    }
}
