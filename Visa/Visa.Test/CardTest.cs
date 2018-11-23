using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase("4444555566667777", 72004)]
        [TestCase("4564555566667777", 121996)]
        public void ValidateCard_WithVisa_Valid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("4444555566667777", 72000)]
        [TestCase("4564555566667777", 121995)]
        public void ValidateCard_WithVisa_Invalid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("5444555566667777", 71951)]
        [TestCase("5564555566667777", 122003)]
        public void ValidateCard_WithMasterCard_Valid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("5444555566667777", 72000)]
        [TestCase("5564555566667777", 121995)]
        public void ValidateCard_WithMasterCard_Invalid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("344455556666777", 71951)]
        [TestCase("376455556666777", 122003)]
        public void ValidateCard_WithAmex_Valid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("3444555566667777", 72000)]
        [TestCase("3764555566667777", 121995)]
        public void ValidateCard_WithAmex_Invalid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("3528555566667777", 71951)]
        [TestCase("3589555566667777", 122003)]
        public void ValidateCard_WithJCB_Valid(string CardNumber, int expirationDate)
        {
            Assert.Pass();
        }
    }
}