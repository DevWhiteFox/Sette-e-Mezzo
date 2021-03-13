using System;
using System.Collections.Generic;
using System.Linq;

namespace SetteEMezzo
{
    public static class CardSystem
    {
        private static readonly List<Card> bancone = new List<Card>();

        public static void Start()
        {
            GenerateCard();
            GiveOneCardToEachPlayers(5);
        }

        private static void GenerateCard()
        {
            foreach (char seed in StatusGame.Seed)
            {
                for (int i = 1; i <= StatusGame.MaxNumberOfCard; i++)
                {
                    Card card = new Card
                    {
                        Seed = seed,
                        Numeration = i
                    };
                    bancone.Add(card);
                }
            }
        }

        private static bool GiveOneCardToEachPlayers(int eachTime)
        {
            Random random = new Random();
            if (EnoughCardsForEveryone(eachTime))
            {
                for (int i = 0; i < eachTime; i++)
                    for (int j = 0; j < Table.Players.Count; j++)
                        GiveCardToPlayerByIndex(random, j);

                return true;
            }
            return false;
        }   

        private static bool EnoughCardsForEveryone(int eachTime)
        {
            return bancone.Count >= (Table.Players.Count * eachTime);
        }

        private static void GiveCardToPlayerByIndex(Random random, int j)
        {
            Card estratto = bancone.ElementAt(random.Next(0, bancone.Count));
            bancone.Remove(estratto);
            Table.Players.ElementAt(j).Cards.Add(estratto);
        }
    }
}
