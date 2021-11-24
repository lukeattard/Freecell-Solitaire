using System;
using System.Drawing;
using System.Windows.Forms;

namespace FreeCell 
{

    /// <summary>
    /// enumeration that represents face values
    /// </summary>
     public enum Face
     {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    /// <summary>
    /// enumeration that represents suit values
    /// </summary>
    public enum Suit
    {
        Clubs = 0,
        Diamonds = 1,
        Hearts = 2,
        Spades = 3
    }

    public class Card : Button
    {
        private string card;

        /// <summary>
        /// Required designer variable.
        /// </summary>        
        public Face face;
        public Suit suit;

        public Card(Face face, Suit suit)
        {       
            Initialize(face, suit);
        }

        public Card(int face, Suit suit)
        {
            Initialize((Face)face, suit);
        }

        public Card(int face, int suit)
        {
            Initialize((Face)face, (Suit)suit);
        }

        public Card(string face, string suit)
        {
            Initialize((Face)Convert.ToInt32(face), (Suit)Convert.ToInt32(suit));

        }

        /// <summary>
        /// Initialize setting for each card created
        /// </summary>
        public void Initialize(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
            this.Size = new Size(146, 200);
            SetCardImage();
        }

        /// <summary>
        /// Get card id, Ex: C2, D5
        /// </summary>
        public string cardId
        {
            get { return card; }
        }

        public System.Windows.Forms.Button CardDraw(int horizotal, int vertical)
        {
            // Set Button properties                      
            this.Location = new Point(horizotal, vertical);
            //this.Text =  this.face.ToString();          

            this.BackgroundImage = Image.FromFile(@"..\..\images\CA.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            return this; 
        }


        /// <summary>
        /// Function to set up background image on the card
        /// </summary>
        private void SetCardImage()
        {
            //string card = "";
            switch (this.suit)
            {
                case (Suit.Clubs):
                    card += 'C';
                    break;
                case (Suit.Diamonds):
                    card += 'D';
                    break;
                case (Suit.Hearts):
                    card += 'H';
                    break;
                case (Suit.Spades):
                    card += 'S';
                    break;
                default:
                    card += 'C';
                    break;
            }
            switch (this.face)
            {
                case (Face.Ace):
                    card += 'A';
                    break;
                case (Face.Two):
                    card += '2';
                    break;
                case (Face.Three):
                    card += '3';
                    break;
                case (Face.Four):
                    card += '4';
                    break;
                case (Face.Five):
                    card += '5';
                    break;
                case (Face.Six):
                    card += '6';
                    break;
                case (Face.Seven):
                    card += '7';
                    break;
                case (Face.Eight):
                    card += '8';
                    break;
                case (Face.Nine):
                    card += '9';
                    break;
                case (Face.Ten):
                    card += "10";
                    break;
                case (Face.Jack):
                    card += 'J';
                    break;
                case (Face.Queen):
                    card += 'Q';
                    break;
                case (Face.King):
                    card += 'K';
                    break;
                default:
                    card += 'A';
                    break;
            }

            BackgroundImage = (Image)Card1.Properties.Resources.ResourceManager.GetObject(card, Card1.Properties.Resources.Culture);
            BackgroundImageLayout = ImageLayout.Stretch;
            ForeColor = Color.Transparent;
        }
    }
}
