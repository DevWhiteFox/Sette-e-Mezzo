using System;
using System.Collections.Generic;
using System.Linq;

namespace SetteEMezzo
{
    public static class CardSystem
    {
        private static readonly List<Card> mazzo = new List<Card>();
        private static readonly List<Player> howWaitMaster = new List<Player>();
        private static readonly Random random = new Random();
        private static readonly float LimitPoints = 7.5f;

        public static void Start()
        {
            GenerateCard();
            GiveOneToEachPlayers(1);
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
                    mazzo.Add(card);
                }
            }
        }

        private static bool GiveOneToEachPlayers(int eachTime)
        {
            if (EnoughForEveryone(eachTime))
            {
                for (int i = 0; i < eachTime; i++)
                    foreach (Player player in Table.Players)
                    {
                        player.TakeCard(ExtractRandom());
                    }

                return true;
            }
            return false;
        }

        private static bool EnoughForEveryone(int eachTime)
        {
            return mazzo.Count >= (Table.Players.Count * eachTime);
        }

        public static Card ExtractRandom()
        {
            Card estratto = mazzo.ElementAt(random.Next(0, mazzo.Count));
            mazzo.Remove(estratto);
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
    }
}
