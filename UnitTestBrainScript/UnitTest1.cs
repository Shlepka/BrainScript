using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BrainScript;

namespace UnitTestBrainScript
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        public void Test_Load_File()
        {
            {
                // исходные данные
                var  Str  = 0;
                int i = 5;
                int expected = 15;

                // получение значения с помощью тестируемого метода
                CSharp test = new CSharp();
                int actual = 0;

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
