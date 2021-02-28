using System.Collections.Generic;
using System.Windows.Forms;

namespace SetteEMezzo
{
    class Player
    {
        private Label label;
        private List<Card> cards = new List<Card>();

        public string Name { get => label.Text; set => label.Text = value; }
        public Label OwnSeat { get => label; set => label = value; }

        public List<Card> Cards { get => cards; set => cards = value; }
    }
}
