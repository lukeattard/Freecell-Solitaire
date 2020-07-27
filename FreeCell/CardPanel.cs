using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeCell
{
    public class CardPanel : Panel
    {
        private List<Card> CardStack;
        static Point offset;
 
        public CardPanel()
        {
            this.CardStack = new List<Card>();
            this.Size = new Size(146, 468);
            offset = new Point(0, 40);

            this.DragEnter += new DragEventHandler(onCardDragEnter);
            this.DragLeave += new EventHandler(OnCardDragLeave);
        }

        /// <summary>
        /// Function to return the cardstack of the panel
        /// </summary>
        public List<Card> cardStack
        {
            get { return CardStack; }
        }

        /// <summary>
        /// Function to add card to the card stack, set the parent and reorder the stack
        /// </summary>
        public void DealCard(Card card)
        {
            this.CardStack.Add(card);
            card.Parent = this;
            ReorderCardDisplay();
        }

        /// <summary>
        /// Function to add card to the card stack and reorder the stack
        /// </summary>
        public virtual void AddCard(Card card)
        {
            this.CardStack.Add(card);
            ReorderCardDisplay();
        }

        /// <summary>
        /// Function to remove the top card from the card stack and reorder the stack
        /// </summary>
        public virtual void RemoveCard()
        {
            this.CardStack.RemoveAt(this.CardStack.Count - 1);
            ReorderCardDisplay();
        }

        /// <summary>
        /// Function to remove the card from the card stack
        /// </summary>
        public bool RemoveCard(Card card)
        {
            return this.CardStack.Remove(card);
        }

        /// <summary>
        /// Function to get the top card inside the stack
        /// </summary>
        public virtual Card GetTopCard()
        {
            Card topCard = this.CardStack[CardStack.Count - 1];
            return topCard;
        }

        /// <summary>
        /// Function to get the card index inside the stack
        /// </summary>
        public virtual int GetCardIndex(Card card)
        {
            int cardIndex = this.CardStack.IndexOf(card);
            return cardIndex;
        }

        /// <summary>
        /// Function to reorder the card display
        /// </summary>
        protected virtual void ReorderCardDisplay()
        {
            int cardIndex = 0;
            foreach (Card card in CardStack)
            {
                card.Left = offset.X;
                card.Top = offset.Y * cardIndex;
                card.BringToFront();
                cardIndex++;
            }
        }

        /// <summary>
        /// Function to reorder the card display
        /// </summary>
        public virtual void OrganizePanel()
        {
            int cardIndex = 0;
            foreach (Card card in CardStack)
            {
                card.Left = offset.X;
                card.Top = offset.Y * cardIndex;
                card.BringToFront();
                cardIndex++;
            }
        }

        /// <summary>
        /// Function to reorder the card display with no offset (made for Homecell panel)
        /// </summary>
        public virtual void OrganizePanelWithoutOffset()
        {
            int cardIndex = 0;
            foreach (Card card in CardStack)
            {
                card.Left = 0;
                card.Top = 0;
                card.BringToFront();
                cardIndex++;
            }
        }

        /// <summary>
        /// Function to clear all the card inside the card stack
        /// </summary>
        public virtual void EmptyCardStack()
        {
            this.CardStack.Clear();
        }

        /// <summary>
        /// Function to get the length of the card stack
        /// </summary>
        public virtual int GetLength()
        {
            return this.CardStack.Count;
        }

        private void onCardDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void onCardDragDrop(object sender, DragEventArgs e)
        {
            ((Card)e.Data.GetData(typeof(Card))).Parent = (Panel)sender;
            
        }

        private void OnCardDragLeave(object sender, EventArgs e)
        {
            Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
    }
}
