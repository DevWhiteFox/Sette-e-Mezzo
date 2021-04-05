using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public static class Table
    {
        public static string SEAT_IS_AVAILABLE = "#";

        public static List<Player> Players { get; } = new List<Player>();
        public static List<Label> SeatingLabel { get; set; }

        public static int assignedSeats;
        public static string seatingArrangement;

        public static void PreparesGameBoard()
        {
            ArrangementByNumberOfPlayers();
            AssignSeatsOfAllPlayer();
            InitOfPlayersPresent();
        }

        private static void ArrangementByNumberOfPlayers()
        {
            switch (StatusGame.RegistredNames.Count)
            {
                case 2: seatingArrangement = "O#O#O"; break;
                case 3: seatingArrangement = "#O#O#"; break;
                case 4: seatingArrangement = "##O##"; break;
                case 5: seatingArrangement = "#####"; break;
                default: seatingArrangement = "OOOOO"; break;
            }
        }

        private static void AssignSeatsOfAllPlayer()
        {
            assignedSeats = 0;
            for (int seat = 0; seat < seatingArrangement.Length; seat++)
            {
                if (SeatIsSuitable(seat)) AssignSinglePlayerSeats(seat);
            }
        }

        private static bool SeatIsSuitable(int seat)
        {
            return seatingArrangement.Substring(seat, 1) == SEAT_IS_AVAILABLE;
        }

        private static void AssignSinglePlayerSeats(int seat)
        {
            SeatingLabel[seat].Text = StatusGame.RegistredNames.ElementAt(index: assignedSeats);
            SeatingLabel[seat].Visible = true;
            assignedSeats++;
        }

        private static void InitOfPlayersPresent()
        {
            for (int seat = 0; seat < seatingArrangement.Length; seat++)
            {
                if (SeatIsSuitable(seat)) RegistreAPlayer(SeatingLabel[seat]);
            }
        }

        public static void RegistreAPlayer(Label seat)
        {
            Player player = new Player
            {
                Name = seat.Text,
                OwnSeat = seat
            };
            Players.Add(player);
        }

        public static void ResetSession()
        {
            Players.Clear();
            SeatingLabel.Clear();
            GameLoop.CyclicTurnCounter = 0;
        }
    }
}