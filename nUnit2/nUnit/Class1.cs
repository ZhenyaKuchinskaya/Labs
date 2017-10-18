using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AddPlus1()
        {
            int result = Calculator.Test_one(15, 13);
            Assert.AreEqual(28, result);
        }
        [Test]
        public void AddPlus2()
        {
            int result = Calculator.Test_one(15, 5);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void AddPlus3()
        {
            int result = Calculator.Test_one(15, 0);
            Assert.AreEqual(16, result);
        }
        [Test]
        public void AddPlus4()
        {
            int result = Calculator.Test_one(15, 2);
            Assert.AreEqual(17, result);
        }
        [Test]
        public void AddPlus5()
        {
            int result = Calculator.Test_one(15, 13);
            Assert.AreEqual(99, result);
        }



        [Test]
        public void AddMinus1()
        {
            int result = Calculator.Test_two(15, 13);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void AddMinus2()
        {
            int result = Calculator.Test_two(15, 13);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void AddMinus3()
        {
            int result = Calculator.Test_two(15, 10);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddMinus4()
        {
            int result = Calculator.Test_two(15, 9);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void AddMinus5()
        {
            int result = Calculator.Test_two(15, 20);
            Assert.AreEqual(-5, result);
        }


        [Test]
        public void AddDel1()
        {
            int result = Calculator.Test_free(15, 5);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void AddDel2()
        {
            int result = Calculator.Test_free(15, 3);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddDel3()
        {
            int result = Calculator.Test_free(15, 0);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void AddDel4()
        {
            int result = Calculator.Test_free(15, 5);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void AddDel5()
        {
            int result = Calculator.Test_free(15, 5);
            Assert.AreEqual(2, result);
        }



        [Test]
        public void AddPr1()
        {
            int result = Calculator.Test_four(15, 13);
            Assert.AreEqual(195, result);
        }
        [Test]
        public void AddPr2()
        {
            int result = Calculator.Test_four(15, 13);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void AddPr3()
        {
            int result = Calculator.Test_four(15, 13);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void AddPr4()
        {
            int result = Calculator.Test_four(15, 1);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void AddPr5()
        {
            int result = Calculator.Test_four(15, 2);
            Assert.AreEqual(30, result);
        }
    }
}
