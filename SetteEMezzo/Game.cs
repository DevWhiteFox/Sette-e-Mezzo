using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class Game : Form
    {
        private Menu InstanceMenu;

        public Game()
        {
            InitializeComponent();
            InitGame();
        }

        public void ImportMenuInstance(Menu instance)
        {
            InstanceMenu = instance;
        }

        private void InitGame()
        {
            PlayTheCard.Enabled = false;

            InitPresenceOfAllPlayer();
            DinamicStorePlayerLabel();
            ArrangementByNumberOfPlayers();
            AssignSeatsOfAllPlayer();
            InitOfPlayersPresent();

            CardSystem.Start();

            FormVisualOperationInit();
            GameLoop.DoNextTurnOperation();
        }

        private void FormVisualOperationInit()
        {
            FormVisualOperation.OwnCardList = OwnCardList;
            FormVisualOperation.WhosTheTurn = WhosTheTurn;
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
            Table.SeatingLabel = new List<Label> {
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
            Table.SeatingLabel[seat].Text = StatusGame.RegistredNames.ElementAt(index: Table.assignedSeats);
            Table.SeatingLabel[seat].Visible = true;
            Table.assignedSeats++;
        }

        private void InitOfPlayersPresent()
        {
            for (int seat = 0; seat < Table.seatingArrangement.Length; seat++)
            {
                if (SeatIsSuitable(seat)) RegistreAPlayer(Table.SeatingLabel[seat]);
            }

            RegistreAPlayer(Master);
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


        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResetSession();
            InstanceMenu.Show();
        }

        private void ResetSession()
        {
            Table.Players.Clear();
            Table.SeatingLabel.Clear();

        }

        private void PlayTheCard_Click(object sender, System.EventArgs e)
        {
            PlayTheCard.Enabled = false;
            GameLoop.DoNextTurnOperation();
        }

        private void OwnCardList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            PlayTheCard.Enabled = true;
        }

        private void PutCardOnTable_Click(object sender, System.EventArgs e)
        {
            GameLoop.PlayerdrawsACard();
            GameLoop.CheckIfPlayerExceededPoints();
        }
    }
}
