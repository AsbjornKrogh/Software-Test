using System.Security.Cryptography.X509Certificates;
using Calculator;
using NUnit.Framework;

namespace CalculaterTestProject
{
    public class Tests
    {
        private CalculatorClass uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalculatorClass();
        }

        [Test]
        public void Add_2plus3_isEqualTo5()
        {
            Assert.That(uut.Add(2,3),Is.EqualTo(5));
        }

        [Test]
        public void Subtract_8minus3_isEqualTo5()
        {
            Assert.That(uut.Subtract(8,3),Is.EqualTo(5));
        }

        [Test]
        public void Multiply_2times4_isEqualTo8()
        {
            Assert.That(uut.Multiply(2,4),Is.EqualTo(8));
        }

        [Test]
        public void Multiplu_10times10_EquelTo100()
        {
            Assert.That(uut.Multiply(10, 10), Is.EqualTo(100));
        }

        [Test]
        public void Power_3lifted3_isEqual27()
        {
            Assert.That(uut.Power(3,3),Is.EqualTo(27));
        }

        [Test]
        public void Devide_4DevidedBy2_isEqual2()
        {
            Assert.That(uut.Devider(4,2),Is.EqualTo(2));
        }

        [TestCase(6, 4, 10)]
        [TestCase(2, 1, 3)]
        [TestCase(6, -4, 2)]
        

        public void Add(int x, int y, int z)
        {
            Assert.AreEqual(uut.Add(x,y),z);
        }
    }
}