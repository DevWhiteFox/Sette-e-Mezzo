namespace SetteEMezzo
{
    public static class GameLoop
    {
        public static byte CyclicTurnCounter { get; set; } = 0;
        private static Player PlayerInTurn { get; set; } = Table.Players[CyclicTurnCounter];

        public static void DoNextTurnOperation()
        {
            RelievedOfOldPlayer();
            RegistreActualPlayer();
            LoadCardOfSelectedPlayer();
            EvidenceLabelOf();
            CycleIncrement();
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

        private static void CycleIncrement()
        {
            CyclicTurnCounter = (byte)((CyclicTurnCounter + 1) % Table.Players.Count);
        }

        private static void RelievedOfOldPlayer()
        {
            FormVisualOperation.MakeDefaultFontLabel(PlayerInTurn.OwnSeat);
        }

        public static void CheckIfPlayerExceededPoints()
        {
            CardSystem.CalculatePlayerPoints(PlayerInTurn);
        }

        public static void PlayerdrawsACard()
        {
            PlayerInTurn.Cards.Add(CardSystem.ExtractRandomCard());
            FormVisualOperation.UpdateCardOfPlayer(PlayerInTurn);
        }
    }
}

