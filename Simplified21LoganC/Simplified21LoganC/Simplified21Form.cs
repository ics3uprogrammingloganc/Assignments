/*
 * Created by: Logan Cantin
 * Created on: April 10th, 2019
 * Created for: ICS3U Programming
 * Assignment #6b - Simplified 21
 * This program allows the user to play a simplified version of the popular casino game 21.
 * 
 * Bonus features:
 * - Scores
 * - Split feature (really complicated - should be worth 2 marks)
 * - Running sums
 * - hit more than once
 * - Intelligent dealer
 * - Sounds
 * - pass by reference function (Deal)
 * - play button
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Simplified21LoganC
{

    public partial class frmSimplified21 : Form
    {
        // Variables
        Random randomGenerator = new Random();
        int dealerScore = 0;
        int userScore = 0;
        int userSplitSum = 0;
        bool split = false;
        int activeHand = 1;
        int userSum, dealerSum;
        SoundPlayer cheer = new SoundPlayer(Properties.Resources.cheer);
        SoundPlayer aww = new SoundPlayer(Properties.Resources.aww);
        
        // Deals (numCards) cards to the supplied listBox
        void Deal(ref ListBox listBox, int numCards)
        {
            // Adds (numCards) to the listbox
            for (int i = numCards; i > 0; i--)
                 listBox.Items.Add(randomGenerator.Next(1, 11));

            // Calculates sum of the cards in hand
            int sum = 0;
            foreach (int card in listBox.Items)
            {
                sum += card;
            }

            // Updates the appropriate sum label
            if (listBox == lstPlayerHand)
            {
                userSum = sum;
                lblUserSum.Text = "Your sum: " + Convert.ToString(userSum);
            }
            else if (listBox == lstDealerCards)
            {
                dealerSum = sum;
                lblDealerSum.Text = "Dealer sum: " + Convert.ToString(dealerSum);
            }
            else if (listBox == lstPlayerSplitHand)
            {
                userSplitSum = sum;
                lblSplitSum.Text = "Split Sum: " + Convert.ToString(userSplitSum);
            }
        }

        // Start a new round
        void Setup()
        {
            // Clear all hands. Resize the player's hand to the original size
            lstDealerCards.Items.Clear();
            lstPlayerHand.Items.Clear();
            lstPlayerSplitHand.Items.Clear();
            lstPlayerHand.Size = new Size(184, 95);

            // Resets split
            split = false;
            btnSplit.Enabled = false;
            lblSplitSum.Hide();

            // Resets the sum texts, and hides the 
            lblDealerSum.Text = "Dealer Sum: ";
            lblUserSum.Text = "Your Sum: ";

            //Deals 2 cards to the user and 1 to the dealer
            Deal(ref lstDealerCards, 1);
            Deal(ref lstPlayerHand, 2);

            //Let the player have their turn
            PlayerTurn();
        }

        // Starts player's turn
        void PlayerTurn()
        {
            // Enables player controls, disables dealer
            grbDealer.Enabled = false;
            grbPlayer.Enabled = true;

            // If the player's cards are the same, allow them to split
            if ((int)lstPlayerHand.Items[0] == (int)lstPlayerHand.Items[1])
            {
                btnSplit.Enabled = true;
            }
        }

        // Start dealer's turn and make plays for dealer
        void DealerTurn()
        {
            // Enable dealer, disable player
            grbDealer.Enabled = true;
            grbPlayer.Enabled = false;
            
            // Keep hitting until dealer's hand has a sum of at least 17
            while (dealerSum < 17)
            {
                Deal(ref lstDealerCards, 1);
            }

            // Determine the winner of the round
            DetermineWinner();
        }

        void DealerWin()
        {
            dealerScore++;
            aww.Load();
            aww.Play();
        }

        void UserWin()
        {
            userScore++;
            cheer.Load();
            cheer.Play();
        }

        // Determines winner(s) of the round
        void DetermineWinner()
        {
            // If the player split their hand
            if (split)
            {
                // HAND 1 RESULT
                if (userSum > 21)
                {
                    DealerWin();
                    MessageBox.Show("Hand 1: Bust, Dealer Win!");
                    
                }
                else if (userSum == 21)
                {
                    UserWin();
                    MessageBox.Show("Hand 1: Blackjack! You win!");
                }
                else if (dealerSum > 21)
                {
                    UserWin();
                    MessageBox.Show("Hand 1: Dealer bust, you win!");
                }
                else if (userSum == dealerSum)
                {
                    MessageBox.Show("Hand 1: Tie");
                }
                else if (userSum > dealerSum)
                {
                    UserWin();
                    MessageBox.Show("Hand 1: You beat the dealer");
                }
                else if (dealerSum > userSum)
                {
                    DealerWin();
                    MessageBox.Show("Hand 1: The dealer beat you");
                }
                else
                {
                    MessageBox.Show("Hand 1: ERROR");
                }


                // HAND 2 RESULT
                if (userSplitSum > 21)
                {
                    DealerWin();
                    MessageBox.Show("Hand 2 bust, Dealer Win!");
                    
                }
                else if (userSplitSum == 21)
                {
                    UserWin();
                    MessageBox.Show("Hand 2 Blackjack! You win!");
                    
                }
                else if (dealerSum > 21)
                {
                    UserWin();
                    MessageBox.Show("Hand 2: Dealer bust, you win!");
                    
                }
                else if (userSplitSum == dealerSum)
                {
                    MessageBox.Show("Hand 2: Tie");
                }
                else if (userSplitSum > dealerSum)
                {
                    UserWin();
                    MessageBox.Show("Hand 2: You beat the dealer");
                    
                }
                else if (dealerSum > userSplitSum)
                {
                    DealerWin();
                    MessageBox.Show("Hand 2: The dealer beat you");
                    
                }
                else
                {
                    MessageBox.Show("Hand 2: ERROR");
                }
            }

            // No split - only one hand
            else
            {
                if (userSum > 21)
                {
                    DealerWin();
                    MessageBox.Show("You bust, Dealer Win!");
                }
                else if (userSum == 21)
                {
                    UserWin();
                    MessageBox.Show("Blackjack! You win!");
                    
                }
                else if (dealerSum > 21)
                {
                    UserWin();
                    MessageBox.Show("Dealer bust, you win!");
                    
                }
                else if (userSum == dealerSum)
                {
                    MessageBox.Show("Tie");
                }
                else if (userSum > dealerSum)
                {
                    UserWin();
                    MessageBox.Show("You beat the dealer");
                    
                }
                else if (dealerSum > userSum)
                {
                    DealerWin();
                    MessageBox.Show("The dealer beat you");
                    
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            
            // Update user and dealer's scores
            lblUserScore.Text = "Your score: " + Convert.ToString(userScore);
            lblDealerScore.Text = "Dealer's Score: " + Convert.ToString(dealerScore);

            // New round
            Setup();
        }

        // Hit procedure for player
        private void btnHit_Click(object sender, EventArgs e)
        {
            // Player can't split anymore
            btnSplit.Enabled = false;
            
            // If the user's split hand is active
            if (activeHand == 2)
            {
                // Deal a card to the player's split hand. If blackjack or bust, move on to other hand
                Deal(ref lstPlayerSplitHand, 1);
                if (userSplitSum > 20)
                    btnStay_Click(this, new EventArgs());
                
            }

            // Regular hand is active
            else
            {
                // Deal a card to the player's regular hand. If blackjack or bust, move on to dealer's turn
                Deal(ref lstPlayerHand, 1);
                if (userSum > 20)
                    DealerTurn();
            }
        }

        // Stay procedure for player
        private void btnStay_Click(object sender, EventArgs e)
        {
            // Disable split button
            btnSplit.Enabled = false;

            // If split hand is active
            if (activeHand == 2)
            {
                // Enable regular hand and disable split hand. Move active hand over to regular hand (1)
                lstPlayerHand.Enabled = true;
                lstPlayerSplitHand.Enabled = false;
                activeHand--;
            }

            // Regular hand
            else
            {
                // Move on to dealer's turn
                DealerTurn();
            }            
        }
        
        // Split procedure for player
        private void btnSplit_Click(object sender, EventArgs e)
        {
            // Make the regular player hand smaller to accomodate for the split hand. Show split hand
            lstPlayerHand.Size = new Size(75, 95);
            lstPlayerSplitHand.Show();

            // Show split sum
            lblSplitSum.Show();

            // Set active hand to split. Set split to true.
            activeHand = 2;
            split = true;

            // Enable split hand and disable regular hand
            lstPlayerSplitHand.Enabled = true;
            lstPlayerHand.Enabled = false;

            // Move 1 card from regular hand over to split hand
            lstPlayerSplitHand.Items.Add((int)lstPlayerHand.Items[0]);
            lstPlayerHand.Items.RemoveAt(1);

            // New sums
            lblUserSum.Text = "Your sum: " + Convert.ToString((int)lstPlayerHand.Items[0]);
            lblSplitSum.Text = "Split sum: " + Convert.ToString((int)lstPlayerHand.Items[0]);

            //Disable split button
            btnSplit.Enabled = false;
        }

        // New game
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset scores. Start new round
            userScore = 0;
            dealerScore = 0;

            // Reset labels
            lblDealerScore.Text = "Dealer Score: 0";
            lblUserScore.Text = "Your Score: 0";

            grbDealer.Hide();
            grbPlayer.Hide();
            btnPlay.Show();
        }

        // Exit game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Start game
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Show all controls, start new round
            grbDealer.Show();
            grbPlayer.Show();
            btnPlay.Hide();
            Setup();
        }

        public frmSimplified21()
        {
            InitializeComponent();

            //Hide everything except play button
            grbDealer.Hide();
            grbPlayer.Hide();
            btnPlay.Show();
        }
    }
}
