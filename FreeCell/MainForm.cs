/*
ISCG6421 GUI Programming, Semester 1, 2020, Assignment 2
Student Name: Ponhvath Vann
Student ID: 1502538
*/
// Refractored the list of using, so many were not needed - Luke Attard

using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FreeCell
{
    public partial class MainForm : Form
    {
        private Random _random = new Random();
        private List<Card> cardList = new List<Card>(); //Store all of the 52 cards
        private List<GamePanel> cardPanels = new List<GamePanel>(); //Store tableau panels
        private List<FreeCellCardPanel> freecellCardPanels = new List<FreeCellCardPanel>(); //Store freecell panels
        private List<HomeCellCardPanel> homecellCardPanels = new List<HomeCellCardPanel>(); //Store homecell panels
        private List<GamePanel> CardPanelList = new List<GamePanel>(); //Store all panels
        private List<string> cardMoves = new List<string>(); //Store all card moves

        private bool translateFlag = false;
        private int numberOfMoves = 0;
        private int timer = 0;
        private bool isTxtBoxCardMoveVisible = false;
        private CardMove cardMove;

        //For animation
        private List<Card> cardMoveMade = new List<Card>();
        private List<GamePanel> oldCardPanelMoveMade = new List<GamePanel>();
        private List<GamePanel> newCardPanelMoveMade = new List<GamePanel>();
        private int counter = 0;

        //For loading the saved game state
        private List<Card> tableauCard1 = new List<Card>();
        private List<Card> tableauCard2 = new List<Card>();
        private List<Card> tableauCard3 = new List<Card>();
        private List<Card> tableauCard4 = new List<Card>();
        private List<Card> tableauCard5 = new List<Card>();
        private List<Card> tableauCard6 = new List<Card>();
        private List<Card> tableauCard7 = new List<Card>();
        private List<Card> tableauCard8 = new List<Card>();

        private List<Card> freecellCard1 = new List<Card>();
        private List<Card> freecellCard2 = new List<Card>();
        private List<Card> freecellCard3 = new List<Card>();
        private List<Card> freecellCard4 = new List<Card>();

        private List<Card> homecellCard1 = new List<Card>();
        private List<Card> homecellCard2 = new List<Card>();
        private List<Card> homecellCard3 = new List<Card>();
        private List<Card> homecellCard4 = new List<Card>();

        private int savedNumMoves = 0;
        private int interval = 0;
        private string minutes = "";
        private string seconds = "";
        private List<string> savedCardMoves = new List<string>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateCard();
            DistributeCard();
            timeRecorder.Start();
        }

        /// <summary>
        /// Create all 52 cards and shuffle the order
        /// </summary>
        private void CreateCard()
        {
            foreach (Face face in Enum.GetValues(typeof(Face)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    Card card = new Card(face, suit);
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    cardList.Add(card);
                }
            }
            cardList.Shuffle(_random.Next(617));
        }


        /// <summary>
        /// Deal cards to 8 tableau panels
        /// </summary>
        private void DistributeCard()
        {
            for (int i = 0; i < cardList.Count; i++)
            {
                if (i >= 0 && i <= 6)
                {
                    pnlTableau1.DealCard(cardList[i]);

                }
                if (i >= 7 && i <= 13)
                {
                    pnlTableau2.DealCard(cardList[i]);
                }

                if (i >= 14 && i <= 20)
                {
                    pnlTableau3.DealCard(cardList[i]);
                }

                if (i >= 21 && i <= 27)
                {
                    pnlTableau4.DealCard(cardList[i]);
                }

                if (i >= 28 && i <= 33)
                {
                    pnlTableau5.DealCard(cardList[i]);
                }

                if (i >= 34 && i <= 39)
                {
                    pnlTableau6.DealCard(cardList[i]);
                }

                if (i >= 40 && i <= 45)
                {
                    pnlTableau7.DealCard(cardList[i]);
                }

                if (i >= 46 && i <= 51)
                {
                    pnlTableau8.DealCard(cardList[i]);
                }
            }

            populateCardPanels();
            populateFreeCellCardPanels();
            populateHomeCellCardPanels();
            addDragEvents();
            populateCardPanelList();
        }

        /// <summary>
        /// Add 8 tableau card panels to the cardPanels list
        /// </summary>
        private void populateCardPanels()
        {
            cardPanels.Add(pnlTableau1);
            cardPanels.Add(pnlTableau2);
            cardPanels.Add(pnlTableau3);
            cardPanels.Add(pnlTableau4);
            cardPanels.Add(pnlTableau5);
            cardPanels.Add(pnlTableau6);
            cardPanels.Add(pnlTableau7);
            cardPanels.Add(pnlTableau8);
        }


        /// <summary>
        /// Add 4 freecell card panels to the freecellCardPanels list
        /// </summary>
        /// //TODO - refractor and have the panels as part of the class, can then have the class as static as well.
        private void populateFreeCellCardPanels()
        {
            freecellCardPanels.Add(pnlFreeCell1);
            freecellCardPanels.Add(pnlFreeCell2);
            freecellCardPanels.Add(pnlFreeCell3);
            freecellCardPanels.Add(pnlFreeCell4);
        }

        /// <summary>
        /// Add 4 homecell card panels to the homecellCardPanels list
        /// </summary>
        /// //TODO - refractor and have the panels as part of the class, can then have the class as static as well. - 
        /// Same here no adding the objects, when you can have them as part of the class on compile
        /// 
        private void populateHomeCellCardPanels()
        {
            homecellCardPanels.Add(pnlHomeCell1);
            homecellCardPanels.Add(pnlHomeCell2);
            homecellCardPanels.Add(pnlHomeCell3);
            homecellCardPanels.Add(pnlHomeCell4);
        }


        /// <summary>
        /// Add all the panels to the CardPanel List
        /// </summary>
        /// // TODO and here too, there is no need to have loops to create these objects when we can just have them statically created in the class. 
        private void populateCardPanelList()
        {
            foreach (GamePanel cp in cardPanels)
            {
                CardPanelList.Add(cp);
            }

            foreach (FreeCellCardPanel fcp in freecellCardPanels)
            {
                CardPanelList.Add(fcp);
            }

            foreach (HomeCellCardPanel hcp in homecellCardPanels)
            {
                CardPanelList.Add(hcp);
            }
        }

        /// <summary>
        /// Add Drag events to freecell and homecell card panels
        /// </summary>
        private void addDragEvents()
        {
            for (int i = 0; i < freecellCardPanels.Count; i++)
            {
                freecellCardPanels[i].DragOver += new DragEventHandler(OnCardDragOver);
                freecellCardPanels[i].DragDrop += new DragEventHandler(OnCardDragDrop);
            }

            for (int i = 0; i < homecellCardPanels.Count; i++)
            {
                homecellCardPanels[i].DragOver += new DragEventHandler(OnCardDragOver);
                homecellCardPanels[i].DragDrop += new DragEventHandler(OnCardDragDrop);
            }
        }

        /// <summary>
        /// Function to check if the top card in each stack can make a valid move
        /// </summary>
        private bool EvaluateCard(Card card)
        {
            bool canMoveFlag = false;

            for (int i = 0; i < cardPanels.Count; i++)
            {
                cardPanels[i].AllowDrop = false;
                cardPanels[i].DragOver += new DragEventHandler(OnCardDragOver);
                cardPanels[i].DragDrop += new DragEventHandler(OnCardDragDrop);

                GamePanel currentCardPanel = (GamePanel)card.Parent;

                if (cardPanels[i].GetLength() == 0)
                {
                    cardPanels[i].AllowDrop = true;
                    canMoveFlag = true;
                }
                else
                {
                    // if the card panel is not the panel of the card that was clicked on
                    if (cardPanels[i] != currentCardPanel)
                    {
                        if (GameRules.IsMoveValid(card, cardPanels[i].GetTopCard()))
                        {
                            cardPanels[i].AllowDrop = true;
                            canMoveFlag = true;
                        }

                    }
                }
            }

            if (canMoveFlag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Function to enable the dragdrop event to each card 
        /// </summary>
        private void onCardMouseDown(object sender, MouseEventArgs e)
        {
            Card card = (Card)sender;
            GamePanel panel = (GamePanel)card.Parent;

            bool canMove = EvaluateCard(card);
            if (canMove)
            {
                this.DoDragDrop(card, DragDropEffects.Move);
            }
            else if (panel.GetCardIndex(card) == panel.GetLength() - 1) //Check if the selected card is at the top of the stack
            {
                this.DoDragDrop(card, DragDropEffects.Move);
            }
            else if (GameRules.IsStackValid(panel.cardStack, panel.GetCardIndex(card))) //Check if the stack is valid
            {
                this.DoDragDrop(card, DragDropEffects.Move);
            }
            else
            {
                MessageBox.Show("This card cannot be moved.");
            }

            bool isGameCompleted = GameRules.isGameCompleted(cardPanels, freecellCardPanels, homecellCardPanels); //Check if the user has won the game
            if (isGameCompleted)
            {
                MessageBox.Show("Congratulations! You have won the game!");
                DialogResult res = MessageBox.Show("Do you want to review your gameplay?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    startCurrentGameAnimation();
                }
            }
        }

        /// <summary>
        /// Function to toggle the mouse cursor when card is being hovered over other panel
        /// </summary>
        private void OnCardDragOver(object sender, DragEventArgs e)
        {
            GamePanel panel = (GamePanel)sender;

            if (panel.GetType() == typeof(FreeCellCardPanel))
            {
                bool canDrop = (GameRules.IsFreeCellCardPanel(panel));
                if (!canDrop)
                {
                    Cursor.Current = System.Windows.Forms.Cursors.No;
                }
            }
            else if (panel.GetType() == typeof(HomeCellCardPanel))
            {
                Cursor.Current = System.Windows.Forms.Cursors.Default;
            }
            else if (panel.GetLength() == 0)
            {
                Cursor.Current = System.Windows.Forms.Cursors.Default;
            }
            else
            {
                Card card = (Card)e.Data.GetData(typeof(Card));
                bool canDrop = GameRules.IsMoveValid(card, panel.GetTopCard());

                if (!canDrop)
                {
                    Cursor.Current = System.Windows.Forms.Cursors.No;
                }
            }
        }

        /// <summary>
        /// Function to add, remove, organize the card stack when valid card is being dropped
        /// </summary>
        private void OnCardDragDrop(object sender, DragEventArgs e)
        {
            GamePanel panel = (GamePanel)sender;
            Card droppedCard = (Card)e.Data.GetData(typeof(Card));
            GamePanel oldParent = (GamePanel)droppedCard.Parent;

            if (panel.GetType() == typeof(GamePanel) && panel.GetLength() == 0) //Check if the Tableau Card Panel is emtpy
            {
                addCardMoveToTextBox(droppedCard.cardId, panel.Name);
                storeAnimationState(droppedCard, oldParent, panel);

                GamePanel oldPanel = (GamePanel)droppedCard.Parent;
                oldPanel.RemoveCard(droppedCard);
                ((Card)e.Data.GetData(typeof(Card))).Parent = (Panel)sender;
                panel.AddCard(droppedCard);

                updateNumberOfMove();
            }
            else if (panel.GetType() == typeof(FreeCellCardPanel) && oldParent.GetCardIndex(droppedCard) == oldParent.GetLength() - 1) //Check if CardPanel is FreeCell and selected card is at the top of the stack 
            {
                if (GameRules.IsFreeCellCardPanel(panel)) //Check if the freecell cardstack is not occupied
                {
                    addCardMoveToTextBox(droppedCard.cardId, panel.Name);
                    storeAnimationState(droppedCard, oldParent, panel);

                    GamePanel oldPanel = (GamePanel)droppedCard.Parent;
                    oldPanel.RemoveCard(droppedCard);
                    ((Card)e.Data.GetData(typeof(Card))).Parent = (Panel)sender;
                    panel.AddCard(droppedCard);

                    updateNumberOfMove();
                }
            }
            else if (panel.GetType() == typeof(HomeCellCardPanel)) //Check if CardPanel is HomeCell
            {
                //Check if homecell cardstack is not occupied, the destination has no card, the card being dropped is Ace and the selected card is at the top of the stack
                if (GameRules.IsHomeCellCardPanel(panel) && panel.GetLength() == 0 && droppedCard.face == Face.Ace && oldParent.GetCardIndex(droppedCard) == oldParent.GetLength() - 1)
                {
                    addCardMoveToTextBox(droppedCard.cardId, panel.Name);
                    storeAnimationState(droppedCard, oldParent, panel);

                    GamePanel oldPanel = (GamePanel)droppedCard.Parent;
                    oldPanel.RemoveCard(droppedCard);
                    ((Card)e.Data.GetData(typeof(Card))).Parent = (Panel)sender;
                    panel.AddCard(droppedCard);

                    panel.OrganizePanelWithoutOffset();
                    updateNumberOfMove();
                }
                //Check if homecell cardstack is not occupied, the destination has cards, the card being dropped is Ace and the selected card is at the top of the stack
                else if (GameRules.IsHomeCellCardPanel(panel) && panel.GetLength() > 0 && droppedCard.face != Face.Ace && oldParent.GetCardIndex(droppedCard) == oldParent.GetLength() - 1)
                {
                    //Check if Suits are matched and Faces are valid
                    if ((GameRules.IsHomeCellCardValid(panel, droppedCard, panel.GetTopCard())))
                    {
                        addCardMoveToTextBox(droppedCard.cardId, panel.GetTopCard().cardId, panel.Name);
                        storeAnimationState(droppedCard, oldParent, panel);

                        GamePanel oldPanel = (GamePanel)droppedCard.Parent;
                        oldPanel.RemoveCard(droppedCard);
                        ((Card)e.Data.GetData(typeof(Card))).Parent = (Panel)sender;
                        panel.AddCard(droppedCard);

                        panel.OrganizePanelWithoutOffset();
                        updateNumberOfMove();
                    }
                }
            }
            //Check if CardPanel is Tableau and if the stack is valid
            else if (panel.GetType() == typeof(GamePanel) && GameRules.IsStackValid(oldParent.cardStack, oldParent.GetCardIndex(droppedCard), panel.GetTopCard()))
            {
                // loop through all cards that are being moved
                int droppedCardIndex = oldParent.GetCardIndex(droppedCard);

                while (oldParent.cardStack.Count >= droppedCardIndex + 1)
                {
                    Card temp = oldParent.cardStack[droppedCardIndex];
                    addCardMoveToTextBox(temp.cardId, panel.GetTopCard().cardId, panel.Name);
                    storeAnimationState(temp, oldParent, panel);

                    panel.AddCard(temp);
                    temp.Parent = panel;

                    if (!oldParent.RemoveCard(temp))
                    {
                        MessageBox.Show("Invalid stack");
                    }
                }
                updateNumberOfMove();

                oldParent.OrganizePanel();
                panel.OrganizePanel();
            }
            //Check if CardPanel is Tableau and if single card move is valid
            else if (droppedCard == (droppedCard.Parent as GamePanel).GetTopCard() && GameRules.IsMoveValid(droppedCard, panel.GetTopCard()))
            {
                addCardMoveToTextBox(droppedCard.cardId, panel.GetTopCard().cardId, panel.Name);
                storeAnimationState(droppedCard, oldParent, panel);

                GamePanel oldPanel = (GamePanel)droppedCard.Parent;
                oldPanel.RemoveCard(droppedCard);
                ((Card)e.Data.GetData(typeof(Card))).Parent = (Panel)sender;
                panel.AddCard(droppedCard);
                updateNumberOfMove();
            }
        }

        /// <summary>
        /// Function to update number of valid moves
        /// </summary>
        private void updateNumberOfMove()
        {
            numberOfMoves++;
            this.lblMoveText.Text = numberOfMoves.ToString();
        }

        /// <summary>
        /// Function to add valid cardMove to cardMoves list and append the cardMove to the textbox (Tableau Panels)
        /// </summary>
        private void addCardMoveToTextBox(string card1, string card2, string cardPanel)
        {
            cardMove = new CardMove(card1, card2, cardPanel);
            cardMoves.Add(cardMove.GetTableauCardMove());

            txtBoxCardMove.Clear();
            foreach (string cardMove in cardMoves)
            {
                txtBoxCardMove.AppendText(cardMove + "\r\r\n\n");
                txtBoxCardMove.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Function to add valid cardMove to cardMoves list and append the cardMove to the textbox (Freecell and Homecell Panels)
        /// </summary>
        private void addCardMoveToTextBox(string card1, string cardPanel)
        {
            cardMove = new CardMove(card1, cardPanel);
            cardMoves.Add(cardMove.GetFreeCellCardMove());

            txtBoxCardMove.Clear();
            foreach (string cardMove in cardMoves)
            {
                txtBoxCardMove.AppendText(cardMove + "\r\r\n\n");
                txtBoxCardMove.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Function to restart the game
        /// </summary>
        private void ResetGame()
        {
            saveGameToolStripMenuItem.Enabled = true;
            loadGameToolStripMenuItem.Enabled = true;
            reviewGameplayToolStripMenuItem.Enabled = true;

            timeRecorder.Stop();
            timeRecorder.Start();
            resetGameState();
            CreateCard();
            DistributeCard();
        }

        /// <summary>
        /// Function to reset the game state
        /// </summary>
        private void resetGameState()
        {
            foreach (GamePanel cardPanel in cardPanels)
            {
                cardPanel.Controls.Clear();
                cardPanel.EmptyCardStack();
            }

            foreach (FreeCellCardPanel fcPanel in freecellCardPanels)
            {
                fcPanel.Controls.Clear();
                fcPanel.EmptyCardStack();
            }

            foreach (HomeCellCardPanel hcPanel in homecellCardPanels)
            {
                hcPanel.Controls.Clear();
                hcPanel.EmptyCardStack();
            }

            foreach (GamePanel cpList in CardPanelList)
            {
                cpList.Controls.Clear();
                cpList.EmptyCardStack();
            }

            this.lblMoveText.Text = "0";
            this.txtBoxCardMove.Text = String.Empty;
            this.txtMinute.Text = "00";
            this.txtSecond.Text = "00";

            this.timer = 0;
            this.numberOfMoves = 0;
            this.cardList.Clear();
            this.cardMoves.Clear();

            //Clear saved state
            this.tableauCard1.Clear();
            this.tableauCard2.Clear();
            this.tableauCard3.Clear();
            this.tableauCard4.Clear();
            this.tableauCard5.Clear();
            this.tableauCard6.Clear();
            this.tableauCard7.Clear();
            this.tableauCard8.Clear();
            this.freecellCard1.Clear();
            this.freecellCard2.Clear();
            this.freecellCard3.Clear();
            this.freecellCard4.Clear();
            this.homecellCard1.Clear();
            this.homecellCard2.Clear();
            this.homecellCard3.Clear();
            this.homecellCard4.Clear();
            this.savedCardMoves.Clear();
        }

        /// <summary>
        /// Function to reset the game state, except it does reset the cardList(initial game state)
        /// </summary>
        private void resetGameStateForAnimation()
        {
            foreach (GamePanel cardPanel in cardPanels)
            {
                cardPanel.Controls.Clear();
                cardPanel.EmptyCardStack();
            }

            foreach (FreeCellCardPanel fcPanel in freecellCardPanels)
            {
                fcPanel.Controls.Clear();
                fcPanel.EmptyCardStack();
            }

            foreach (HomeCellCardPanel hcPanel in homecellCardPanels)
            {
                hcPanel.Controls.Clear();
                hcPanel.EmptyCardStack();
            }

            foreach (GamePanel cpList in CardPanelList)
            {
                cpList.Controls.Clear();
                cpList.EmptyCardStack();
            }

            this.lblMoveText.Text = "0";
            this.txtBoxCardMove.Text = String.Empty;
            this.txtMinute.Text = "00";
            this.txtSecond.Text = "00";

            this.timer = 0;
            this.numberOfMoves = 0;
            //this.cardList.Clear();
            this.cardMoves.Clear();

            //Clear saved state
            this.tableauCard1.Clear();
            this.tableauCard2.Clear();
            this.tableauCard3.Clear();
            this.tableauCard4.Clear();
            this.tableauCard5.Clear();
            this.tableauCard6.Clear();
            this.tableauCard7.Clear();
            this.tableauCard8.Clear();
            this.freecellCard1.Clear();
            this.freecellCard2.Clear();
            this.freecellCard3.Clear();
            this.freecellCard4.Clear();
            this.homecellCard1.Clear();
            this.homecellCard2.Clear();
            this.homecellCard3.Clear();
            this.homecellCard4.Clear();
            this.savedCardMoves.Clear();
        }

        /// <summary>
        /// Function to load the game from the saved file
        /// </summary>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resetGameState();

                reviewGameplayToolStripMenuItem.Enabled = false;

                FileIO.loadGame(openFileDialog1.FileName, 
                                tableauCard1, tableauCard2, tableauCard3, tableauCard4, tableauCard5, tableauCard6, tableauCard7, tableauCard8,
                                freecellCard1, freecellCard2, freecellCard3, freecellCard4,
                                homecellCard1, homecellCard2, homecellCard3, homecellCard4,
                                ref savedNumMoves, ref minutes, ref seconds, ref interval, savedCardMoves);


                foreach (Card card in tableauCard1)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau1.DealCard(card);
                }

                foreach (Card card in tableauCard2)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau2.DealCard(card);
                }

                foreach (Card card in tableauCard3)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau3.DealCard(card);
                }

                foreach (Card card in tableauCard4)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau4.DealCard(card);
                }

                foreach (Card card in tableauCard5)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau5.DealCard(card);
                }

                foreach (Card card in tableauCard6)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau6.DealCard(card);
                }

                foreach (Card card in tableauCard7)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau7.DealCard(card);
                }

                foreach (Card card in tableauCard8)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlTableau8.DealCard(card);
                }

                foreach (Card card in freecellCard1)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlFreeCell1.DealCard(card);
                }

                foreach (Card card in freecellCard2)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlFreeCell2.DealCard(card);
                }

                foreach (Card card in freecellCard3)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlFreeCell3.DealCard(card);
                }

                foreach (Card card in freecellCard4)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlFreeCell4.DealCard(card);
                }

                foreach (Card card in homecellCard1)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlHomeCell1.DealCard(card);
                }

                foreach (Card card in homecellCard2)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlHomeCell2.DealCard(card);
                }

                foreach (Card card in homecellCard3)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlHomeCell3.DealCard(card);
                }

                foreach (Card card in homecellCard4)
                {
                    card.MouseDown += new MouseEventHandler(onCardMouseDown);
                    pnlHomeCell4.DealCard(card);
                }

                //Remove Card offset from homecell
                pnlHomeCell1.OrganizePanelWithoutOffset();
                pnlHomeCell2.OrganizePanelWithoutOffset();
                pnlHomeCell3.OrganizePanelWithoutOffset();
                pnlHomeCell4.OrganizePanelWithoutOffset();

                //Restore the saved game data
                this.timer = interval;
                this.lblMoveText.Text = savedNumMoves.ToString();
                this.txtMinute.Text = minutes;
                this.txtSecond.Text = seconds;
                this.numberOfMoves = savedNumMoves;

                //Restart the timer recorder
                timeRecorder.Stop();
                timeRecorder.Start();
                
                //Restore the cardMoves and append it to the textbox
                foreach (string cardMove in savedCardMoves)
                {
                    txtBoxCardMove.AppendText(cardMove + "\r\r\n\n");
                    txtBoxCardMove.AppendText(Environment.NewLine);
                    cardMoves.Add(cardMove);
                }

                //Restore Tableau, FreeCell, HomeCell, DragEvents
                populateCardPanels();
                populateFreeCellCardPanels();
                populateHomeCellCardPanels();
                addDragEvents();
                populateCardPanelList();

                MessageBox.Show("Game has been loaded successfully!");
                saveFileDialog1.FileName = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Function to start the animation timer
        /// </summary>
        private void startCurrentGameAnimation()
        {
            resetGameStateForAnimation();
            DistributeCard();
            animation.Start(); //timer
        }

        /// <summary>
        /// Function to store data needed to produce the animation timer
        /// </summary>
        private void storeAnimationState(Card card, GamePanel oldCardPanel, GamePanel newCardPanel)
        {
            cardMoveMade.Add(card);
            oldCardPanelMoveMade.Add(oldCardPanel);
            newCardPanelMoveMade.Add(newCardPanel);
        }

        /// <summary>
        /// Timer to animate the gameplay
        /// </summary>
        private void animation_Tick(object sender, EventArgs e)
        {
            if(counter < cardMoveMade.Count)
            {
                Card tempCard = cardMoveMade[counter];
                GamePanel tempNewPanel = newCardPanelMoveMade[counter];
                GamePanel tempOldPanel = oldCardPanelMoveMade[counter];
                addCardMoveToTextBox(tempCard.cardId, tempNewPanel.Name);

                tempNewPanel.AddCard(tempCard);
                tempOldPanel.RemoveCard(tempCard);
                tempCard.Parent = tempNewPanel;

                updateNumberOfMove();

                if (tempNewPanel.GetType() == typeof(HomeCellCardPanel) || tempNewPanel.GetType() == typeof(FreeCellCardPanel))
                {
                    tempOldPanel.OrganizePanel();
                    tempNewPanel.OrganizePanelWithoutOffset();
                }else
                {
                    tempOldPanel.OrganizePanel();
                    tempNewPanel.OrganizePanel();
                }
                counter++;
            }else
            {
                animation.Stop();
                timeRecorder.Stop();

                saveGameToolStripMenuItem.Enabled = false;
                loadGameToolStripMenuItem.Enabled = false;
                reviewGameplayToolStripMenuItem.Enabled = false;

                DialogResult res = MessageBox.Show("Gameplay animation is finished! Do you want to restart a new game?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    ResetGame();
                }
            }
        }

        /// <summary>
        /// Timer to update the elapsed time
        /// </summary>
        private void timeRecorder_Tick(object sender, EventArgs e)
        {
            timer += 1;

            if (timer < 10)
            {
                this.txtSecond.Text = "0" + timer.ToString();
            }
            else if (timer == 60)
            {
                timer = 0;
                txtMinute.Text = (int.Parse(txtMinute.Text) + 1).ToString();
                if (int.Parse(txtMinute.Text) < 10)
                {
                    this.txtMinute.Text = "0" + txtMinute.Text;

                }
                else
                {
                    this.txtMinute.Text = txtMinute.Text;
                }
                this.txtSecond.Text = "00";
            }
            else
            {
                this.txtSecond.Text = timer.ToString();
            }

        }

        /// <summary>
        /// Toggle the cardMove text box visibility
        /// </summary>
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (!isTxtBoxCardMoveVisible)
            {
                txtBoxCardMove.Visible = false;
                isTxtBoxCardMoveVisible = true;
            }
            else
            {
                txtBoxCardMove.Visible = true;
                isTxtBoxCardMoveVisible = false;
            }
        }

        /// <summary>
        /// Restart a new game
        /// </summary>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to restart the game?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                ResetGame();
            }
        }

        /// <summary>
        /// Save the current game
        /// </summary>
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileIO.saveGame(saveFileDialog1.FileName, cardPanels, freecellCardPanels, homecellCardPanels, cardList, cardMoves, numberOfMoves, txtMinute.Text, txtSecond.Text, timer);
                MessageBox.Show("Game has been saved successfully!");
            }
        }

        /// <summary>
        /// Review the current or complete game
        /// </summary>
        private void reviewGameplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("This current game will be replayed! However, move cannot be made after the animation is finished!\n" +
                "To play unfinished game, Please save first and load the game.\n" +
                "Are you sure want to proceed to gameplay animation?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                startCurrentGameAnimation();
            }
        }

        /// <summary>
        /// Translate the text to Maori in the MainForm
        /// </summary>
        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!translateFlag)
            {
                this.Text = "Takahuri";
                translateFlag = true;
            }
            else
            {
                this.Text = "FreeCell";
                translateFlag = false;
            }
        }
    }
}
