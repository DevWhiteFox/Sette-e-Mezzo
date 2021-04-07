using System;
using System.Collections.Generic;
using System.Linq;

namespace SetteEMezzo
{
    public static class CardSystem
    {
        private static readonly List<Card> Mazzo = new List<Card>();
        private static readonly List<Player> HowWaitMaster = new List<Player>();
        private static readonly Random Random = new Random();
        private static readonly float LimitPoints = 7.5f;

        public static void Start()
        {
            //GenerateCard();
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());
            Mazzo.Add(new Jolly());

            GiveOneToEachPlayers(0);
        }

        private static void GenerateCard()
        {
            foreach (char seed in StatusGame.Seed)
            {
                for (byte i = 1; i <= StatusGame.MaxNumberOfCard; i++)
                {
                    Card card = new Card
                    {
                        Seed = seed,
                        Numeration = i
                    };
                    Mazzo.Add(card);
                }
            }
        }

        private static bool GiveOneToEachPlayers(int eachTime)
        {
            if (EnoughForEveryone(eachTime))
            {
                for (int i = 0; i < eachTime; i++)
                    for (int j = 0; j < Table.Players.Count; j++)
                    {
                        Player player = Table.Players[j];
                        Card card = ExtractRandom();
                        if (!CheckIfJolly(card))
                        {
                            player.TakeCard(card);
                        }
                        else
                        {
                            Mazzo.Add(card);
                            j--;
                        }
                    }

                return true;
            }
            return false;
        }

        private static bool EnoughForEveryone(int eachTime)
        {
            return Mazzo.Count >= (Table.Players.Count * eachTime);
        }

        public static Card ExtractRandom()
        {
            Card estratto = Mazzo.ElementAt(Random.Next(0, Mazzo.Count));
            Mazzo.Remove(estratto);
            return estratto;
        }

        public static void CheckPlayerStatus()
        {
            if(GameLoop.PlayerInTurn.Points > LimitPoints)
            {
                PlayerLose();
            }
            else if(GameLoop.PlayerInTurn.Points == LimitPoints)
            {
                PlayerWin();
            }
        }

        private static void PlayerLose()
        {
            Player player = GameLoop.PlayerInTurn;
            FormVisualOperation.MakeStrikeThroughFontLabel(player.OwnSeat);
            FormVisualOperation.ShowBanner("HAI PERSO");
            FormVisualOperation.PickCard.Enabled = false;
        }

        private static void PlayerWin()
        {
            Player player = GameLoop.PlayerInTurn;
            FormVisualOperation.MakeBoldAndGreenLabel(player.OwnSeat);
            FormVisualOperation.ShowBanner("HAI VINTO");
            FormVisualOperation.PickCard.Enabled = false;
        }

        public static bool CheckIfJolly(Card card)
        {
            return card.Seed == StatusGame.JollySeed;
        }
    }
}
