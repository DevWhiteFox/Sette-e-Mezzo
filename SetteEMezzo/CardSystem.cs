using System;
using System.Collections.Generic;
using System.Linq;

namespace SetteEMezzo
{
    class CardSystem
    {
             

        public void start()
        {
            generateCard();
            giveAll(1);
        }

        private void generateCard()
        {
            foreach (char seme in semi)
            {
                for (int i = 1; i <= MAX_NUMBER_CARD; i++)
                {
                    bancone.Add(new Card(semi + "" + i, 'x'));
                }
            }
        }

        private void giveAll(int eachTime)
        {
            Random random = new Random();

            for(int i=0; i < eachTime; i++)
                for(int j=0; j < StatusGame.Players.Count; j++)
                {
                    Card estratto = bancone.ElementAt(random.Next(0, bancone.Count));
                    bancone.Remove(estratto);
                    estratto.Proprietario = (char) j;
                    players.Add(estratto);
                }
        }


        /*
         *  array banchiere B2 null
         *  array players B3 0
         * 
         *  Seme proprietari
         */
    }
}
