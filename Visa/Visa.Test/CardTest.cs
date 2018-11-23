using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Visa.API.Context;
using Visa.API.Model;
using Visa.API.Repository;

namespace Tests
{
    public class Tests
    {
        private CardRepository _cardRepository;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CardDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Visa_Test;Trusted_Connection=True;");
            var context = new CardDbContext(optionsBuilder.Options);
            _cardRepository = new CardRepository(context);
        }

        [Test]
        [TestCase("4444555566667777", 72004)]
        [TestCase("4564555566667777", 121996)]
        public void ValidateCard_WithVisa_Valid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.Visa);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Valid);
        }

        [Test]
        [TestCase("4444555566667777", 72001)]
        [TestCase("4564555566667777", 121995)]
        public void ValidateCard_WithVisa_Invalid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.Visa);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Invalid);
        }

        [Test]
        [TestCase("5444555566667777", 71951)]
        [TestCase("5564555566667777", 122003)]
        public void ValidateCard_WithMasterCard_Valid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.Master);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Valid);
        }

        [Test]
        [TestCase("5444555566667777", 72000)]
        [TestCase("5564555566667777", 121995)]
        public void ValidateCard_WithMasterCard_Invalid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.Master);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Invalid);
        }

        [Test]
        [TestCase("344455556666777", 71951)]
        [TestCase("376455556666777", 122003)]
        public void ValidateCard_WithAmex_Valid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.Amex);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Valid);
        }

        [Test]
        [TestCase("3444555566667777", 72000)]
        [TestCase("3764555566667777", 121995)]
        public void ValidateCard_WithAmex_Invalid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.Amex);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Invalid);
        }

        [Test]
        [TestCase("3528555566667777", 71951)]
        [TestCase("3589555566667777", 122003)]
        public void ValidateCard_WithJCB_Valid(string CardNumber, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = CardNumber,
                ExpirationDate = expirationDate
            };

            var cardValidation = _cardRepository.ValidateCard(card);
            Assert.AreEqual(cardValidation.TCard, CardType.JCB);
            Assert.AreEqual(cardValidation.VCard, CardValidation.Valid);
        }
    }
}