using System.Collections.Generic;

namespace SetteEMezzo
{
    public static class StatusGame
    {
        private static readonly byte MAX_PLAYERS = 5;
        private static readonly byte MIN_PLAYERS = 2;
        private static readonly byte MAX_CHARACTERS = 15;
        private static readonly byte MAX_NUMBER_CARD_EACH_SEED = 10;
        private static readonly byte MAX_VALID_NUMBER_OF_POINT = 7;

        private static char[] seed = { 'B', 'O', 'C', 'S' };
        private static char jollySeed = 'X';

        public static byte MinPlayers { get => MIN_PLAYERS; }
        public static byte MaxPlayers { get => MAX_PLAYERS; }
        public static byte Maxcharacters { get => MAX_CHARACTERS; }
        public static byte MaxNumberOfCard { get => MAX_NUMBER_CARD_EACH_SEED; }

        public static byte MaxValidNumberOfPoint { get => MAX_VALID_NUMBER_OF_POINT; }

        public static List<string> RegistredNames { get; } = new List<string>();
        public static char[] Seed { get => seed; set => seed = value; }
        public static char JollySeed { get => jollySeed; set => jollySeed = value; }
    }
}
