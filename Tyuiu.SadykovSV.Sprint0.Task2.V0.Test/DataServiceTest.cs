using Tyuiu.SadykovSV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SadykovSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChenkGetMessageValid()
        {
            var name = "Савелий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Савелий", res);
        }
    }
}
