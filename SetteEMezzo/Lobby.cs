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

        private Game InstanceGame;

        public Lobby()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            InitLabel();
            SetEnableSetPlayers(false);
            SetEnableCount(true);
        }

        private void SetEnableSetPlayers(bool state)
        {
            namePlayer.Enabled = state;
            playerLabel.Enabled = state;
            addPlayer.Enabled = state;
        }

        private void SetEnableCount(bool state)
        {
            numPlayerLabel.Enabled = state;
            choiceNumberPlayers.Enabled = state;
            confirmNPlayer.Enabled = state;
        }

        private void InitLabel()
        {
            numPlayerLabel.Text = "Numero Players: ";
            playerLabel.Text = "Nome Giocatore ";
        }

        private void Play_Click(object sender, EventArgs e)
        {
            pressStart = true;
            Hide();
            if(InstanceGame == null) InstanceGame = new Game();
            InstanceGame.Show();
        }

        private void UpdatePlayerLabelCount(string reasonCall)
        {
            playerLabel.Text = reasonCall + " (" + (StatusGame.RegistredNames.Count) + "/" + choiceNumber + ")";
        }

        private void AddPlayerInGroup()
        {
            StatusGame.RegistredNames.Add(namePlayer.Text);
            namePlayer.Text = "";
        }

        private void ConfirmNPlayer_Click(object sender, EventArgs e)
        {   //Confermiamo il numero di player

            choiceNumber= (byte)choiceNumberPlayers.Value;
            if (choiceNumber>= StatusGame.MinPlayers && choiceNumber<= StatusGame.MaxPlayers)
            {
                numPlayerLabel.Text = DEFAULT_NUMBER_PLAYER + choiceNumber;
                UpdatePlayerLabelCount(DEFAULT_PLAYER_NAME);
                SetEnableSetPlayers(true);
                SetEnableCount(false);
            }
            else
            {
                numPlayerLabel.Text = WRONG_NUMBER_PLAYER;
            }
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {   //Aggiungiamo il nome dei player in un elenco

            if (StatusGame.RegistredNames.Count != choiceNumber)
            {
                if (namePlayer.Text.Length <= StatusGame.Maxcharacters &&
                    namePlayer.Text.Length > 0) {

                    AddPlayerInGroup();
                    UpdatePlayerLabelCount(SUCCESS_PLAYER_NAME);
                }else{
                    UpdatePlayerLabelCount(WRONG_PLAYER_NAME);
                }

                if (StatusGame.RegistredNames.Count == choiceNumber)
                {
                    SetEnableSetPlayers(false);
                    Play.Enabled = true;
                }
            }
        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pressStart) { 
                Menu.GetForm().Close();
                StatusGame.RegistredNames.Clear();
            }
        }
    }
}

