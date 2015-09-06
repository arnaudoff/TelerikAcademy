namespace Santase.Tests
{
    using System;
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        private const int InitialDeckCardsCount = 24;

        [Test]
        public void CreatedDeckShouldHaveCorrectNumberOfCards()
        {
            Deck deck = new Deck();
            
            Assert.AreEqual(
                InitialDeckCardsCount,
                deck.CardsLeft, 
                string.Format("Created deck should initially have {0} cards.", InitialDeckCardsCount));
        }

        [TestCase(20)]
        [TestCase(18)]
        public void CreatedDeckShouldHaveCorrectNumberOfCardsLeft(int numberOfCards)
        {
            Deck deck = new Deck();
            Card nextCard;

            for (int i = 0; i < numberOfCards; i++)
            {
                nextCard = deck.GetNextCard();
            }

            Assert.AreEqual(24 - numberOfCards, deck.CardsLeft);
        }

        [Test]
        public void DeckShouldChangeTrumpCardCorrectly()
        {
            Deck deck = new Deck();
            Card newTrumpCard = new Card(CardSuit.Spade, CardType.Ace);

            deck.ChangeTrumpCard(newTrumpCard);

            Assert.AreEqual(newTrumpCard, deck.GetTrumpCard);
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void DeckShouldThrowWhenNextCardIsNotPresent()
        {
            Deck deck = new Deck();

            for (int i = 0; i < InitialDeckCardsCount + 1; i++)
            {
                deck.GetNextCard();
            }
        }
    }
}