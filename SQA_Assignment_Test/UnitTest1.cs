using NUnit.Framework;
using SQA_Assignment1;

namespace SQA_Assignment_Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetLength()
        {
            Rectangle r = new Rectangle(5,5);
            int a = r.GetLength();
            Assert.AreEqual(5, a);
           

        }

        [Test]
        public void TestSetLength()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(5, r.SetLength(5));
        }

        [Test]
        public void TestGetWidth()
        {
            Rectangle r = new Rectangle(4,4);
            Assert.AreEqual(4, r.GetWidth());

        }

        [Test]
        public void TestSetWidth()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(6, r.SetWidth(6));
        }

        [Test]
        public void TestGetPerimeter()
        {
            Rectangle r = new Rectangle(4,4);
            Assert.AreEqual(16, r.GetPerimeter());
        }

        [Test]
        public void TestGetArea()
        {
            Rectangle r = new Rectangle(5,4);
            Assert.AreEqual(20, r.GetArea());
        }
    }
}