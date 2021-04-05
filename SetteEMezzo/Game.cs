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
            FormVisualOperationInit();
            InitPresenceOfAllPlayer();
            DinamicStorePlayerLabel();
            
            Table.PreparesGameBoard();

            CardSystem.Start();

            GameLoop.UpdateFormAboutPlayer();
        }

        private void FormVisualOperationInit()
        {
            FormVisualOperation.OwnCardList = OwnCardList;
            FormVisualOperation.WhosTheTurn = WhosTheTurn;
            FormVisualOperation.PickCard = PickCard;
            FormVisualOperation.WinBanner = WinBanner;
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

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Table.ResetSession();
            InstanceMenu.Show();
        }

        private void OwnCardList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            PassTurn.Enabled = true;
        }
    
        private void PassTurn_Click(object sender, System.EventArgs e)
        {
            GameLoop.DoNextTurnOperation();
            PickCard.Enabled = true;
            if(GameLoop.CyclicTurnCounter == Table.Players.Count)
            {
                PassTurn.Enabled = false;
                PickCard.Enabled = false;
            }
        }

        private void PickCard_Click(object sender, System.EventArgs e)
        {
            GameLoop.PlayerDrawsACard();
            CardSystem.CheckPlayerStatus();
        }
    }
}
