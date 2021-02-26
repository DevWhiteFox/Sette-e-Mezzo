using System.Collections.Generic;
using System.Windows.Forms;

namespace SetteEMezzo
{
    class Player
    {
        private char[] name = new char[StatusGame.Maxcharacters];
        private Label label;
        private List<Card> cards = new List<Card>();

        public string Name { get => new string(name); set => name = value.ToCharArray(); }
        public Label OwnLabel { get => label; set => label = value; }

        public List<Card> Cards { get => cards; set => cards = value; }


}
}
