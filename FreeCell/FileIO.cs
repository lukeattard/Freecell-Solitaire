using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeCell
{
    public static class FileIO
    {

        /// <summary>
        /// Function to save the game state
        /// </summary>
        public static void saveGame(string path, List<CardPanel> pnlTableau, List<FreeCellCardPanel> pnlFreeCell, List<HomeCellCardPanel> pnlHomeCell, List<Card> initialCardList, List<string> cardMoves, int moveCount, string minutes, string seconds, int interval)
        {
            StreamWriter sw = new StreamWriter(path);
            StringBuilder sb = new StringBuilder(2000);

            int i = 1;
            foreach(CardPanel tableauPanel in pnlTableau)
            {
                sb.Append($"pnlTableau{i}");
                List<Card> cards = tableauPanel.cardStack;

                foreach(Card card in cards)
                {
                    sb.Append($",{card.cardId}");
                }
                sb.Append($"\r\n");
                i++;
            }

            int j = 1;
            foreach (FreeCellCardPanel freecellPanel in pnlFreeCell)
            {
                sb.Append($"pnlFreeCell{j}");
                List<Card> cards = freecellPanel.cardStack;

                foreach (Card card in cards)
                {
                    sb.Append($",{card.cardId}");
                }
                sb.Append($"\r\n");
                j++;
            }

            int p = 1;
            foreach (HomeCellCardPanel homecellPanel in pnlHomeCell)
            {
                sb.Append($"pnlHomeCell{p}");
                List<Card> cards = homecellPanel.cardStack;

                foreach (Card card in cards)
                {
                    sb.Append($",{card.cardId}");
                }
                sb.Append($"\r\n");
                p++;
            }

            sb.Append("initialState");
            foreach (Card card in initialCardList)
            {
                sb.Append($",{card.cardId}");
            }
            sb.Append($"\r\n");

            sb.Append("cardMoves");
            foreach (string cm in cardMoves)
            {
                sb.Append($",{cm}");
            }
            sb.Append($"\r\n");

            sb.Append("numebrOfMoves,");
            sb.Append($"{moveCount}\r\n");

            sb.Append("interval,");
            sb.Append($"{interval}\r\n");

            sb.Append("minutes,");
            sb.Append($"{minutes}\r\n");

            sb.Append("seconds,");
            sb.Append(seconds);

            sw.Write(sb);
            sw.Close();
        }

        /// <summary>
        /// Function to load the game state
        /// </summary>
        public static void loadGame(string path, 
                                    List<Card> tableauCard1, List<Card> tableauCard2, List<Card> tableauCard3, List<Card> tableauCard4, 
                                    List<Card> tableauCard5, List<Card> tableauCard6, List<Card> tableauCard7, List<Card> tableauCard8,
                                    List<Card> freecellCard1, List<Card> freecellCard2, List<Card> freecellCard3, List<Card> freecellCard4,
                                    List<Card> homecellCard1, List<Card> homecellCard2, List<Card> homecellCard3, List<Card> homecellCard4,
                                    ref int savedNumMoves, ref string minutes, ref string seconds, ref int interval, List<string> savedCardMoves)
        {
            StreamReader sr = new StreamReader(path);
            string temp = sr.ReadLine();
            while(temp != null)
            {
                string[] substrings = temp.Split(',');
                string keyword = substrings[0]; 

                if (keyword.Substring(0,3) == "pnl")
                {
                    List<Card> cardList = GetPanelFromString(keyword, 
                                                            tableauCard1, tableauCard2, tableauCard3, tableauCard4, tableauCard5, tableauCard6, tableauCard7, tableauCard8,
                                                            freecellCard1, freecellCard2, freecellCard3, freecellCard4,
                                                            homecellCard1, homecellCard2, homecellCard3, homecellCard4);
                    if(cardList != null)
                    {
                        for(int i=1; i<substrings.Length; i++)
                        {   
                            Card card = new Card(getFaceFromString(substrings[i].Substring(1, substrings[i].Length - 1)), getSuitFromChar(substrings[i][0])); //CA, A is Face(index 1), C is Suit (index 0)
                            cardList.Add(card);
                        }
                    }
                }
                //else if (keyword.Substring(0, 3) == "ini")
                //{
                //    for (int i = 1; i < substrings.Length; i++)
                //    {
                //        Card card = new Card(getFaceFromString(substrings[i].Substring(1, substrings[i].Length - 1)), getSuitFromChar(substrings[i][0])); //CA, A is Face(index 1), C is Suit (index 0)
                //        initialCardList.Add(card);
                //    }
                //}
                else if (keyword.Substring(0, 3) == "car")
                {
                    for (int i = 1; i < substrings.Length; i++)
                    {
                        savedCardMoves.Add(substrings[i]);
                    }
                }
                else if(keyword.Substring(0,3) == "num")
                {
                    for (int i = 1; i < substrings.Length; i++)
                    {
                        savedNumMoves =  Convert.ToInt32(substrings[i]);
                    }
                }
                else if (keyword.Substring(0, 3) == "int")
                {
                    for (int i = 1; i < substrings.Length; i++)
                    {
                        interval = Convert.ToInt32( substrings[i]);
                    }
                }
                else if (keyword.Substring(0, 3) == "min")
                {
                    for (int i = 1; i < substrings.Length; i++)
                    {
                        minutes = substrings[i];
                    }
                }
                else if (keyword.Substring(0, 3) == "sec")
                {
                    for (int i = 1; i < substrings.Length; i++)
                    {
                        seconds = substrings[i];
                    }
                }
                temp = sr.ReadLine();
            }

            sr.Close();
        }

        /// <summary>
        /// Function to return the card list for each panel
        /// </summary>
        private static List<Card> GetPanelFromString(string panelName, 
                                                    List<Card> cp1, List<Card> cp2, List<Card> cp3, List<Card> cp4, List<Card> cp5, List<Card> cp6, List<Card> cp7, List<Card> cp8,
                                                    List<Card> fcp1, List<Card> fcp2, List<Card> fcp3, List<Card> fcp4,
                                                    List<Card> hcp1, List<Card> hcp2, List<Card> hcp3, List<Card> hcp4)
        {
            switch(panelName)
            {
                case "pnlTableau1":
                    return cp1;
                case "pnlTableau2":
                    return cp2;
                case "pnlTableau3":
                    return cp3;
                case "pnlTableau4":
                    return cp4;
                case "pnlTableau5":
                    return cp5;
                case "pnlTableau6":
                    return cp6;
                case "pnlTableau7":
                    return cp7;
                case "pnlTableau8":
                    return cp8;
                case "pnlFreeCell1":
                    return fcp1;
                case "pnlFreeCell2":
                    return fcp2;
                case "pnlFreeCell3":
                    return fcp3;
                case "pnlFreeCell4":
                    return fcp4;
                case "pnlHomeCell1":
                    return hcp1;
                case "pnlHomeCell2":
                    return hcp2;
                case "pnlHomeCell3":
                    return hcp3;
                case "pnlHomeCell4":
                    return hcp4;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Function to convert string into Face
        /// </summary>
        private static Face getFaceFromString(string s)
        {
            switch(s)
            {
                case "A":
                    return Face.Ace;
                case "2":
                    return Face.Two;
                case "3":
                    return Face.Three;
                case "4":
                    return Face.Four;
                case "5":
                    return Face.Five;
                case "6":
                    return Face.Six;
                case "7":
                    return Face.Seven;
                case "8":
                    return Face.Eight;
                case "9":
                    return Face.Nine;
                case "10":
                    return Face.Ten;
                case "J":
                    return Face.Jack;
                case "Q":
                    return Face.Queen;
                case "K":
                    return Face.King;
                default:
                    return Face.Ace;
            }
        }

        /// <summary>
        /// Function to convert the char into Suit
        /// </summary>
        private static Suit getSuitFromChar(char c)
        {
            switch(c)
            {
                case 'C':
                    return Suit.Clubs;
                case 'D':
                    return Suit.Diamonds;
                case 'H':
                    return Suit.Hearts;
                case 'S':
                    return Suit.Spades;
                default:
                    return Suit.Clubs;
            }
        }
    }
}
