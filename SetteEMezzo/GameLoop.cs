﻿namespace SetteEMezzo
{
    public static class GameLoop
    {
        public static byte CyclicTurnCounter { get; set; } = 0;
        public static Player PlayerInTurn { get; set; } = null;

        public static void DoNextTurnOperation()
        {
            RelievedOfOldPlayer();
            if(IsPlayerOutOfGame()) CycleIncrement();
            UpdateFormAboutPlayer();
        }

        public static void UpdateFormAboutPlayer()
        {
            RipristineCounter();
            RegistreActualPlayer();
            LoadCardOfSelectedPlayer();
            EvidenceLabelOf();
        }

        private static bool IsPlayerOutOfGame()
        {
            return !PlayerInTurn.OwnSeat.Font.Strikeout;
        }

        public static void CycleIncrement()
        {
            CyclicTurnCounter = (byte)((CyclicTurnCounter + 1) % Table.Players.Count);
        }

        private static void RipristineCounter()
        {
            if (IsCounterOverLimit())
            {
                CyclicTurnCounter = 0;
            }
        }

        private static bool IsCounterOverLimit()
        {
            return CyclicTurnCounter > (Table.Players.Count);
        }

        private static void RelievedOfOldPlayer()
        {
            FormVisualOperation.MakeDefaultFontLabel(PlayerInTurn.OwnSeat);
        }

        private static void RegistreActualPlayer()
        {
            PlayerInTurn = Table.Players[CyclicTurnCounter];
        }
       
        private static void LoadCardOfSelectedPlayer()
        {
            FormVisualOperation.UpdateCardOfPlayer(PlayerInTurn);
        }

        private static void EvidenceLabelOf()
        {
            FormVisualOperation.MakeBoldLabel(PlayerInTurn.OwnSeat);
        }

        public static void PlayerDrawsACard()
        {
            PlayerInTurn.TakeCard(CardSystem.ExtractRandom());
            FormVisualOperation.UpdateCardOfPlayer(PlayerInTurn);
        }
    }
}

