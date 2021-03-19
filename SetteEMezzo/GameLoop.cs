using System.Threading;

namespace SetteEMezzo
{
    public static class GameLoop
    {
        public static byte PlayerTurn { get; set; } = 0;

        public static void DoNextTurnOperation()
        {
            SelectPlayerToLoadCard();
            CycleIncrement();
        }

        private static void CycleIncrement()
        {
            PlayerTurn = (byte)((PlayerTurn + 1) % StatusGame.RegistredNames.Count);
        }

        private static void SelectPlayerToLoadCard()
        {
            FormVisualOperation.LoadCardOfPlayer(Table.Players[PlayerTurn]);
        }
    }
}

