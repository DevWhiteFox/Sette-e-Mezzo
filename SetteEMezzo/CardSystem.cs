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
            GiveAll(1);
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

        private static void GiveAll(int eachTime)
        {
            Random random = new Random();

            for(int i=0; i < eachTime; i++)
                for(int j=0; j < Table.Players.Count; j++)
                {
                    Card estratto = bancone.ElementAt(random.Next(0, bancone.Count));
                    bancone.Remove(estratto);
                    Table.Players.ElementAt(j).Cards.Add(estratto);
                }
        }
    }
}
