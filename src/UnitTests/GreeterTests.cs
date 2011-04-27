using System.IO;
using OpenWrapSpike;

namespace UnitTests.GreeterTests
{
    using NUnit.Framework;

    [TestFixture]
    public class When_greeting
    {
        [Test]
        public void should_say_hello()
        {
            // Given 
            var greeter = new Greeter();
            var stringWriter = new StringWriter();
            System.Console.SetOut(stringWriter);

            // When
            greeter.Greet("World");

            // Then
            Assert.That(stringWriter.ToString(), Is.EqualTo("Hello World"));
        }
    }
}