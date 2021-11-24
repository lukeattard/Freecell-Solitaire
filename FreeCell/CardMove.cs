using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCell
{
    public class CardMove 
    {
        private int cardIndex;
        private int cardLocation;
        private string card1;
        private string card2;
        string cardPanel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        public CardMove()
        {
            // This call is required by the Windows.Forms Form Designer.
            // InitializeComponent();

            // TODO: Add any initialization after the InitForm call

            // Removed the class call for forms so i could remove this useless call.

      
        }

        /// <summary>
        /// Function that takes card index within the list and the card location where it has been placed
        /// </summary>
        public CardMove(int cardIndex, int cardLocation)
        {
            this.cardIndex = cardIndex;
            this.cardLocation = cardLocation;
        }

        /// <summary>
        /// Function that takes card(selected card) and the cardPanel(dropped destination) as as a string
        /// </summary>
        public CardMove(string card1, string cardPanel)
        {
            this.card1 = card1;
            this.cardPanel = cardPanel;
        }

        /// <summary>
        /// Function that takes card1(selected card), card2(top card inside dropped destination) and the cardPanel(dropped destination) as as a string
        /// </summary>
        public CardMove(string card1, string card2, string cardPanel)
        {
            this.card1 = card1;
            this.card2 = card2;
            this.cardPanel = cardPanel;
        }

        /// <summary>
        /// Function that returns the cardIndex and Location in a form of "cardIndex -> cardLocation"
        /// </summary>
        public string asText()
        {
            string cardMovement = this.cardIndex + " -> " + this.cardLocation;
            return cardMovement;
        }

        /// <summary>
        /// Function that returns the cardMove for tableau panels
        /// </summary>
        public string GetTableauCardMove()
        {
            string cardMovement = this.card1 + " -> " + this.card2 + " -> " + this.cardPanel;
            return cardMovement;
        }

        /// <summary>
        /// Function that returns the cardMove for freecell panels
        /// </summary>
        public string GetFreeCellCardMove()
        {
            string cardMovement = this.card1 + " -> " + this.cardPanel;
            return cardMovement;
        }
    }
}
