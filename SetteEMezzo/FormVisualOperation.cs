using System.Drawing;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public static class FormVisualOperation
    {
        public static ListBox OwnCardList;
        public static Label WhosTheTurn;

        public static ListBox TableCardList;

        public static RichTextBox WinBanner;

        public static Button PickCard { get; set; }

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
            if (label.Font.Bold || !label.Font.Strikeout)
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }
        }

        public static void MakeStrikeThroughFontLabel(Label label)
        {
            if (!(label.Font.Strikeout))
            {
                label.Font = new Font(label.Font, FontStyle.Strikeout);
            }
        }        

        public static void ShowBanner(string message)
        {
            WinBanner.Text = GameLoop.PlayerInTurn.Name + " " + message;
            WinBanner.Visible = true;
        }

        public static void HideBanner()
        {
            WinBanner.Visible = false;
        }
    }
}
