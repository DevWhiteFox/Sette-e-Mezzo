using System.Windows.Forms;

namespace SetteEMezzo
{
    public static class FormVisualOperation
    {
        public static ListBox OwnCardList;
        public static Label WhosTheTurn;

        public static void LoadCardOfPlayer(Player player)
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

    }
}
