using MathOps_Func;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace MathOps
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int n1 = 100;
            int n2 = 200;
            int expectedresult = 300;
            int actualresult=n1 + n2;
            Assert.That(actualresult, Is.EqualTo(expectedresult));
        }
        [TestCase(100,200,300)]
        [TestCase(-100, -200, -300)]
        public void Test_MultipleInputs_Add(int n1, int n2, int expected)
        {
            int actualresult = n1 + n2;
            Assert.That(actualresult,Is.EqualTo(expected));

        }
        [TestCase(100,200,300)]
        [TestCase(100,-50,50)]
        [TestCase(-100,-200,-300)]
        public void Test_Gherkin_Add_Valid_Integers(int n1, int n2, int expected)
        {
            //Act
            int actual = MathOps_Func.Ops.Add(n1, n2);

            //Assert
            Assert.That(actual,Is.EqualTo(expected));

        }
        [Test]
        public void StartsandEndsWithTest()
        {
            string phrase = "Hello World";
            String[] greetings = new string[]{ "hello!", "hi!", "Hola!" };

            //constraint syntax
            Assert.That(phrase, Does.Not.StartWith("Hi").IgnoreCase);
            Assert.That(phrase, Does.StartWith("Hello").IgnoreCase);
            Assert.That(phrase, Does.EndWith("world").IgnoreCase);
            Assert.That(phrase, Does.Not.EndWith("me").IgnoreCase);
            Assert.That(greetings, Is.All.EndWith("!").IgnoreCase);

        }
        [Test]
        public void RegularExpressionTests()
        {
            string phrase = "Now is the time for all good men to come to the aid of their country";
            string[] quotes = new string[] { "Never say never", "its never too late", "Nevermore!" };
            Assert.That(phrase, Does.Match("all good men"));
            Assert.That(phrase, Does.Not.Match("all.*men.*good"));
            Assert.That(quotes, Is.All.Matches("never").IgnoreCase);
            //string license = "1234-5678-9101-1213";
            //Assert.That(license, Does.Match(@"^\d{4}-\d{4}-\d{4}-\d{4}$"));
        }
        [TestCase("1234-5678-9101-1213")]
        [TestCase("2345-3467-7890-5467")]
        public void Licence(string phrase)
        {
            Assert.That(phrase, Does.Match(@"^\d{4}-\d{4}-\d{4}-\d{4}$"));

        }
        [Test]
        public void AllItemsTest()
        {
            object[] ints = new object[] { 1, 2, 3, 4, 4 };
            object[] doubles = new object[] { 0.99, 2.1, 3.0, 4.05};
            object[] strings = new object[] { "abc","bad","cab","bad","dad" };
            Assert.That(ints, Is.All.Not.Null);
            Assert.That(ints, Has.None.Null);
            Assert.That(ints,Is.All.InstanceOf(typeof(int)));
            Assert.That(ints,Has.All.InstanceOf(typeof(int)));
            //Assert.That(ints, Is.Unique);

            Assert.That(strings, Is.Not.Unique);
            Assert.That(ints,Is.All.GreaterThan(0));
            Assert.That(strings,Has.All.Contain("a"));
            Assert.That(strings, Has.Some.Property("Length").EqualTo(3));
            Assert.That(doubles, Has.Some.EqualTo(1.0).Within(.05));
        }
    }
    
}