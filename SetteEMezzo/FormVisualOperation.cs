using System.Drawing;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public static class FormVisualOperation
    {
        public static ListBox OwnCardList;
        public static Label WhosTheTurn;

        public static ListBox TableCardList;

        public static void UpdateCardOfPlayer(Player player)
        {
            WhosTheTurn.Text = player.Name;

            OwnCardList.BeginUpdate();

            OwnCardList.Items.Clear();

            foreach (Card cards in player.Cards)
            {
                OwnCardList.Items.Add(cards.Seed + "" + cards.Numeration);
            }

            OwnCardList.EndUpdate();
        }

        public static void MakeBoldLabel(Label label)
        {
            if (!(label.Font.Bold))
            {
                label.Font = new Font(label.Font, FontStyle.Bold);
            }
        }

        public static void MakeDefaultFontLabel(Label label)
        {
            if (label.Font.Bold)
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }
        }

    }
}
