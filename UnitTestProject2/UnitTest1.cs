using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LR0Moroz;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string[] s = { "Айфон", "1006", "13000", "95000", "5 декабря 2021г.", "51" };
            var f = new MainTable(s);
            string res2 = f.test();
            string one = string.Join(Convert.ToString(' '), s);

            Assert.AreEqual(one, res2);
        }
    }
}
