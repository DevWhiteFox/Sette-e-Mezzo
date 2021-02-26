using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetteEMezzo
{
    class Card{
        private string seme;
        private char proprietario;
        
        public char Proprietario
        {
            get => proprietario;
            set { proprietario = value; } 
        } 
        public Card(string seme, char proprietario)
        {
            this.seme = seme;
            this.proprietario = proprietario;
        }
    }
}
