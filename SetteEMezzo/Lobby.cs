using System;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class Lobby : Form
    {
        private const string DEFAULT_NUMBER_PLAYER = "Numero Players: ";
        private const string WRONG_NUMBER_PLAYER = "Numero Players: Non valido";

        private const string DEFAULT_PLAYER_NAME = "Nome Giocatore";
        private const string WRONG_PLAYER_NAME = "Nome Giocatore non valido";
        private const string SUCCESS_PLAYER_NAME = "Nome Giocatore Registrato";

        private byte choiceNumber = 0;
        private bool pressStart = false;

        public Lobby()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            initLabel();
            setEnableSetPlayers(false);
            setEnableCount(true);
        }

        private void setEnableSetPlayers(bool state)
        {
            namePlayer.Enabled = state;
            playerLabel.Enabled = state;
            addPlayer.Enabled = state;
        }

        private void setEnableCount(bool state)
        {
            numPlayerLabel.Enabled = state;
            choiceNumberPlayers.Enabled = state;
            confirmNPlayer.Enabled = state;
        }

        private void initLabel()
        {
            numPlayerLabel.Text = "Numero Players: ";
            playerLabel.Text = "Nome Giocatore ";
        }

        private void Play_Click(object sender, EventArgs e)
        {
            pressStart = true;
            this.Close();
            StatusGame.InstanceGame = new Game();
            StatusGame.InstanceGame.Show();
        }

        private void updatePlayerLabelCount(string reasonCall)
        {
            playerLabel.Text = reasonCall + " (" + (StatusGame.Players.Count) + "/" + choiceNumber + ")";
        }

        private void addPlayerInGroup()
        {
            StatusGame.Players.Add(namePlayer.Text);
            namePlayer.Text = "";
        }

        private void confirmNPlayer_Click(object sender, EventArgs e)
        {   //Confermiamo il numero di player

            choiceNumber= (byte)choiceNumberPlayers.Value;
            if (choiceNumber>= StatusGame.MinPlayers && choiceNumber<= StatusGame.MaxPlayers)
            {
                numPlayerLabel.Text = DEFAULT_NUMBER_PLAYER + choiceNumber;
                updatePlayerLabelCount(DEFAULT_PLAYER_NAME);
                setEnableSetPlayers(true);
                setEnableCount(false);
            }
            else
            {
                numPlayerLabel.Text = WRONG_NUMBER_PLAYER;
            }
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {   //Aggiungiamo il nome dei player in un elenco

            if (StatusGame.Players.Count != choiceNumber)
            {
                if (namePlayer.Text.Length <= StatusGame.Maxcharacters &&
                    namePlayer.Text.Length > 0) {

                    addPlayerInGroup();
                    updatePlayerLabelCount(SUCCESS_PLAYER_NAME);
                }else{
                    updatePlayerLabelCount(WRONG_PLAYER_NAME);
                }

                if (StatusGame.Players.Count == choiceNumber)
                {
                    setEnableSetPlayers(false);
                    Play.Enabled = true;
                }
            }
        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pressStart) { 
                StatusGame.InstanceMenu.Show();
                StatusGame.Players.Clear();
            }
        }
    }
}

