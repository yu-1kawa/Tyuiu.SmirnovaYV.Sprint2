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
            Assert.AreEqual("15.05.2024", ds.FindDateOfPreviousDay(2024, 05, 16));
            Assert.AreEqual("28.02.2023", ds.FindDateOfPreviousDay(2023, 03, 01));
            Assert.AreEqual("31.12.2023", ds.FindDateOfPreviousDay(2024, 01, 01));
            Assert.AreEqual("30.04.2024", ds.FindDateOfPreviousDay(2024, 05, 01));
            Assert.AreEqual("30.11.2024", ds.FindDateOfPreviousDay(2024, 12, 01));
            
        }
    }
}
