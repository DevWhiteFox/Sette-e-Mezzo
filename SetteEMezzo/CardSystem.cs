using System;
using System.Collections.Generic;
using System.Linq;

namespace SetteEMezzo
{
    public static class CardSystem
    {
        private static readonly List<Card> bancone = new List<Card>();
        private static readonly Random random = new Random();

        public static void Start()
        {
            GenerateCard();
            GiveOneCardToEachPlayers(1);
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
            
            if (EnoughCardsForEveryone(eachTime))
            {
                for (int i = 0; i < eachTime; i++)
                    foreach(Player player in Table.Players)
                    {
                        player.Cards.Add(ExtractRandomCard());
                    }

                return true;
            }
            return false;
        }   

        private static bool EnoughCardsForEveryone(int eachTime)
        {
            return bancone.Count >= (Table.Players.Count * eachTime);
        }

        public static Card ExtractRandomCard()
        {
            Card estratto = bancone.ElementAt(random.Next(0, bancone.Count));
            bancone.Remove(estratto);
            return estratto;
        }

        public static void CalculatePlayerPoints(Player player)
        {
            float totalPoints = 0.0f;

            List<Card> cards = player.Cards;
            foreach(Card card in cards)
            {
                if(card.Numeration > StatusGame.MaxValidNumberOfPoint)
                {
                    totalPoints += 0.5f;
                }
                else
                {
                    totalPoints += card.Numeration;
                }
            }

            Console.WriteLine(totalPoints);
            if (totalPoints > 7.0f)
            {
                Console.WriteLine(player.Name + " Lose");
            }
            else if(totalPoints == 7.0f)
            {
                Console.WriteLine(player.Name + " WIN");
            }
        }
    }
}
