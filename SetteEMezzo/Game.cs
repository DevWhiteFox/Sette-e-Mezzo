using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class Game : Form
    {

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
            InitOfPlayersPresent();

            CardSystem.Start();
            LoadCardOfPlayer(Table.Players.ElementAt(0));
        }

        private void InitPresenceOfAllPlayer()
        {
            Player1.Visible =
            Player2.Visible =
            Player3.Visible =
            Player4.Visible =
            Player5.Visible = false;
        }

        private void DinamicStorePlayerLabel()
        {
            Table.seatingLabel = new List<Label> {
                Player1,
                Player2,
                Player3,
                Player4,
                Player5
            };
        }

        private void ArrangementByNumberOfPlayers()
        {
            switch (StatusGame.RegistredNames.Count)
            {
                case 2: Table.seatingArrangement = "O#O#O"; break;
                case 3: Table.seatingArrangement = "#O#O#"; break;
                case 4: Table.seatingArrangement = "##O##"; break;
                case 5: Table.seatingArrangement = "#####"; break;
                default: Table.seatingArrangement = "OOOOO"; break;
            }
        }

        private void AssignSeatsOfAllPlayer()
        {
            Table.assignedSeats = 0;
            for (int seat = 0; seat < Table.seatingArrangement.Length; seat++)
            {
                if (SeatIsSuitable(seat)) AssignSinglePlayerSeats(seat);
            }
        }

        private bool SeatIsSuitable(int seat)
        {
            return Table.seatingArrangement.Substring(seat, 1) == Table.SEAT_IS_AVAILABLE;
        }

        private void AssignSinglePlayerSeats(int seat)
        {
            Table.seatingLabel[seat].Text = StatusGame.RegistredNames.ElementAt(index: Table.assignedSeats);
            Table.seatingLabel[seat].Visible = true;
            Table.assignedSeats++;
        }

        private void InitOfPlayersPresent()
        {
            for (int seat = 0; seat < Table.seatingArrangement.Length; seat++)
            {
                if (SeatIsSuitable(seat)) RegistreAPlayer(Table.seatingLabel[seat]);
            }
        }

        private void RegistreAPlayer(Label seat)
        {
            Player player = new Player
            {
                Name = seat.Text,
                OwnSeat = seat
            };
            Table.Players.Add(player);
        }


        private void LoadCardOfPlayer(Player player)
        {
            OwnCardList.BeginUpdate();

            foreach (Card cards in player.Cards)
            {
                OwnCardList.Items.Add(cards.Seed + "" + cards.Numeration);
            }

            OwnCardList.EndUpdate();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NextTurn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
