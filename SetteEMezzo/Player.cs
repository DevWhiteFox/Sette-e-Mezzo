using System.Collections.Generic;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public class Player
    {
        public string Name { get => OwnSeat.Text; set => OwnSeat.Text = value; }
        public Label OwnSeat { get; set; } = new Label();

        public List<Card> Cards { get; set; } = new List<Card>();
    }
}
