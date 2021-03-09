using System.Collections.Generic;
using System.Windows.Forms;

namespace SetteEMezzo
{
    public static class Table
    {
        public static string SEAT_IS_AVAILABLE = "#";

        public static List<Player> Players { get; } = new List<Player>();
        public static List<Label> seatingLabel;

        public static int assignedSeats;
        public static string seatingArrangement;
    }
}