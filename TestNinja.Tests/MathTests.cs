using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Tests
{
    [TestFixture]
    public class MathTests
    {
        private Maths _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Maths();
        }

        [Test]
//        [Ignore("Because I love it")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
          //  var math = new Maths();

            var result = _math.Add(1, 2);

            Assert.AreEqual(result, 3);
        }

        [Test]
        [TestCase (2, 1, 2)]
        [TestCase (1, 2, 2)]
        [TestCase (1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int exceptedResult)
        {
            //  var math = new Maths();

            var result = _math.Max(a, b);

            Assert.AreEqual(result, exceptedResult);
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //   Assert.That(result, Is.Not.Empty);
            //   Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

         //   Assert.That(result, Is.Ordered);
         //   Assert.That(result, Is.Unique);
        } 
    }
}
