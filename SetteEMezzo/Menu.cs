using System;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class Menu : Form
    {
        private Lobby InstanceLobby;

        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Hide();

            InstanceLobby = new Lobby();
            InstanceLobby.ImportMenuInstance(this);
            InstanceLobby.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
