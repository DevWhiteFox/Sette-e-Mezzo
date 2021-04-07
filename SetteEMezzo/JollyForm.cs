using System.Windows.Forms;

namespace SetteEMezzo
{
    public partial class JollyForm : Form
    {
        Card jolly;

        public JollyForm()
        {
            InitializeComponent();
        }

        public void TakeCard(Card card)
        {
            jolly = card;
        }

        private void AssignNumber_Click(object sender, System.EventArgs e)
        {
            if(NumberCard.Value <= StatusGame.MaxNumberOfCard && NumberCard.Value > 0)
            {
                jolly.Numeration = (byte)NumberCard.Value;
            }
            Close();
        }
    }
}
