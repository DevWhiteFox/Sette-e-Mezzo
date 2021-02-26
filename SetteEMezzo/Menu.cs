using System;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StatusGame.InstanceMenu = this;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatusGame.InstanceLobby = new Lobby();
            StatusGame.InstanceLobby.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
