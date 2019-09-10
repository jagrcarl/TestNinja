using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("{content}");

            // Specific
            Assert.That(result, Is.EqualTo("<strong>{content}</strong>").IgnoreCase);

            // More general
            // Assert.That(result, Does.StartWith("<strong"));
        }
    }
}
