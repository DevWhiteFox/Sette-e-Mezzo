using System.Collections.Generic;

namespace SetteEMezzo
{
    public static class StatusGame
    {
        private static readonly byte MAX_PLAYERS = 5;
        private static readonly byte MIN_PLAYERS = 2;
        private static readonly byte MAX_CHARACTERS = 10;
        private static readonly byte MAX_NUMBER_CARD = 10;

        private static Menu instanceMenu;
        private static Lobby instanceLobby;
        private static Game instanceGame;

        private static char[] semi = { 'B', 'O', 'C', 'S' };

        public static byte MinPlayers { get => MIN_PLAYERS; }
        public static byte MaxPlayers { get => MAX_PLAYERS; }
        public static byte Maxcharacters { get => MAX_CHARACTERS; }
        public static byte MaxNumberOfCard { get => MAX_NUMBER_CARD; }

        public static Menu InstanceMenu { get => instanceMenu; set => instanceMenu = value; }
        public static Lobby InstanceLobby { get => instanceLobby; set => instanceLobby = value; }
        public static Game InstanceGame { get => instanceGame; set => instanceGame = value; }

        public static List<string> Players { get; } = new List<string>(); //Da eliminare non appena si crea e implementa la classe Player

        public static char[] Semi { get => semi; set => semi = value; }

    }
}
