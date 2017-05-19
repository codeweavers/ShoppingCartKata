using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ShoppingCartKata.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void WhenOneAppleThenTotalIs50()
        {
            var subject = new ShoppingCart();
            subject.Scan("Apple");
            Assert.That(subject.Total(), Is.EqualTo(50));
        }
    }
}
