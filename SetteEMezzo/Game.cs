using System.Collections.Generic;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class Game : Form
    {
        string SEAT_IS_AVAILABLE = "#";
        List<Label> seatingLabel;
        int assignedSeats;
        string seatingArrangement;

        public Game()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            InitPresenceOfAllPlayer();
            DinamicStorePlayerLabel();

            ArrangementByNumberOfPlayers();
            AssignSeatsOfAllPlayer();
        }

        private void InitPresenceOfAllPlayer()
        {
            player1.Visible =
            player2.Visible =
            player3.Visible =
            player4.Visible =
            player5.Visible = false;
        }

        private void DinamicStorePlayerLabel()
        {
            seatingLabel = new List<Label>
            {
                player1,
                player2,
                player3,
                player4,
                player5
            };
        }

        private void ArrangementByNumberOfPlayers()
        {
            switch (StatusGame.Players.Count)
            {
                    case 2: seatingArrangement = "O#O#O"; break;
                    case 3: seatingArrangement = "#O#O#"; break;
                    case 4: seatingArrangement = "##O##"; break;
                    case 5: seatingArrangement = "#####"; break;
                    default: seatingArrangement = "OOOOO"; break;
            }
        }

        private void AssignSeatsOfAllPlayer()
        {
            assignedSeats = 0;
            for (int seat = 0; seat < seatingArrangement.Length; seat++)
            {
                if(SeatIsSuitable(seat)) AssignSinglePlayerSeats(seat);
            }
        }

        private bool SeatIsSuitable(int seat)
        {
            return seatingArrangement.Substring(seat, 1) == SEAT_IS_AVAILABLE;
        }

        private void AssignSinglePlayerSeats(int seat)
        {
            seatingLabel[seat].Text = StatusGame.Players[assignedSeats];
            seatingLabel[seat].Visible = true;
            assignedSeats++;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
