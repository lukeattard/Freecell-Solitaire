using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCell
{
    public static class GameRules
    {

        /// <summary>
        /// Function to check if the card move is valid
        /// </summary>
        public static bool IsMoveValid(Card card1, Card card2)
        {
            if(IsColorsMatched(card1, card2))
            {
                return false;
            }
            else if(IsFacesValid(card1, card2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to check if the card stack is valid
        /// </summary>
        public static bool IsStackValid(List<Card> cardStack, int cardIndex)
        {
            bool validStack = false;

            for(int i=cardIndex + 1; i<cardStack.Count; i++)
            {
                Face previousCard = (Face)cardStack[i - 1].face;

                if(previousCard == (cardStack[i].face + 1))
                {
                    if (i == cardStack.Count - 1)
                    {
                        validStack = true;
                    }
                }
            }

            if(validStack)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Function to check if the card stack is valid and move made is valid
        /// </summary>
        public static bool IsStackValid(List<Card> cardStack, int cardIndex, Card card)
        {
            bool validStack = false;
            Card selectedCard = cardStack[cardIndex];

            for (int i = cardIndex + 1; i < cardStack.Count; i++)
            {
                Face previousCard = (Face)cardStack[i - 1].face;

                if (previousCard == (cardStack[i].face + 1))
                {
                    if (i == cardStack.Count - 1)
                    {
                        if (IsMoveValid(selectedCard, card))
                        {
                            validStack = true;
                        }
                    }
                }
            }

            if (validStack)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Function to check if the freecell panel is not occupied
        /// </summary>
        public static bool IsFreeCellCardPanel(GamePanel fcPanel)
        {
            if (fcPanel.GetLength() == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Function to check if the homecell panel is occupied
        /// </summary>
        public static bool IsHomeCellCardPanel(GamePanel hcPanel)
        {
            if (hcPanel.GetLength() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Function to check if the move made with the homecell panel is valid
        /// </summary>
        public static bool IsHomeCellCardValid(GamePanel cp, Card card1, Card card2)
        {
            if (IsSuitsMatched(card1, card2) && IsHomeCellCardFacesValid(card1, card2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to check if the faces are valid
        /// </summary>
        private static bool IsHomeCellCardFacesValid(Card card1, Card card2)
        {
            if (card1.face == card2.face + 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to check if the suits are matched
        /// </summary>
        private static bool IsSuitsMatched(Card card1, Card card2)
        {

            if (card1.suit == Suit.Clubs && card2.suit == Suit.Spades ||
               card1.suit == Suit.Hearts && card2.suit == Suit.Diamonds ||
               card1.suit == Suit.Spades && card2.suit == Suit.Clubs ||
               card1.suit == Suit.Diamonds && card2.suit == Suit.Hearts)
            {
                return false;
            }
            
            if (card1.suit == Suit.Clubs && card2.suit == Suit.Clubs ||
               card1.suit == Suit.Spades && card2.suit == Suit.Spades ||
               card1.suit == Suit.Hearts && card2.suit == Suit.Hearts ||
               card1.suit == Suit.Diamonds && card2.suit == Suit.Diamonds)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to check if the suits between card 1 and card 2 is matched
        /// </summary>
        private static bool IsColorsMatched(Card card1, Card card2)
        {
            //Check for matching colors
            if(card1.suit == Suit.Clubs && card2.suit == Suit.Spades ||
               card1.suit == Suit.Hearts && card2.suit == Suit.Diamonds ||
               card1.suit == Suit.Spades && card2.suit == Suit.Clubs ||
               card1.suit == Suit.Diamonds && card2.suit == Suit.Hearts
               )
            {
                return true;
            }
            //Check for matching cards
            if(card1.suit == Suit.Clubs && card2.suit == Suit.Clubs ||
               card1.suit == Suit.Spades && card2.suit == Suit.Spades ||
               card1.suit == Suit.Hearts && card2.suit == Suit.Hearts ||
               card1.suit == Suit.Diamonds && card2.suit == Suit.Diamonds)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to check if the faces between card 1 and card 2 is valid
        /// </summary>
        private static bool IsFacesValid(Card card1, Card card2)
        {
            if(card1.face == card2.face - 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to check how many cards can be moved in given the amount of free spaces
        /// this is not solitair it is freecell
        /// Luke Attard
        /// </summary>

        private static int CardsThatCanBeMoved()
        {
            int legalNumberOfCards = 0;

            return legalNumberOfCards;
        }
        /// <summary>
        /// Function to check if user has won the game
        /// </summary>
        public static bool isGameCompleted(List<GamePanel> cardPanels, List<FreeCellCardPanel> freecellCardPanels, List<HomeCellCardPanel> homecellCardPanels)
        {
            bool isCompleted = false;

            foreach(GamePanel cp in cardPanels)
            {
                if(cp.GetLength() == 0)
                {
                    isCompleted = true;
                }
                else
                {
                    isCompleted = false;
                }
            }

            foreach (FreeCellCardPanel fcp in freecellCardPanels)
            {
                if (fcp.GetLength() == 0)
                {
                    isCompleted = true;
                }
                else
                {
                    isCompleted = false;
                }
            }

            foreach (HomeCellCardPanel hcp in homecellCardPanels)
            {
                if(hcp.GetLength() == 13)
                {
                    isCompleted = true;
                }else
                {
                    isCompleted = false;
                }
            }

            if(isCompleted)
            {
                return true;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Function to check if there is anymore possible move
        /// </summary>
        private static bool isMovePossible(List<GamePanel> CardPanelList, Card card1, Card card2)
        {
            bool IsAMovePossible = false;

            // Loop through the cardPanels
            foreach (GamePanel cp in CardPanelList)
            {
                // Loop through each card in the Panel
                foreach (Card c in cp.cardStack)
                {
                    // Loop through the CardPanels to check for dragDrop options
                    foreach (GamePanel innerCP in CardPanelList)
                    {
                        if (IsMoveValid(card1, card2))
                        {
                            // A move is possible, so the game is not a failure yet
                            IsAMovePossible = true;
                        }else
                        {
                            return false;
                        }
                    }
                }
            }

            if (IsAMovePossible)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
