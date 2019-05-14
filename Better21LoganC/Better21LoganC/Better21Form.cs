using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better21LoganC
{
    public partial class frmBetter21 : Form
    {
        // Variables
        public Deck deck;
        private Dealer dealer;
        private User user;
        private LinkedList<Player> players = new LinkedList<Player>();
        private LinkedList<Player>.Enumerator playerEnumerator;
        private Player currentPlayer;
        private int buyinCost = 50;

        // Constructor
        public frmBetter21()
        {
            InitializeComponent();
        }

        // Starts game
        private void StartGame()
        {
            // Creates a new deck, dealer, and user
            deck = new Deck();
            dealer = new Dealer(ref deck, this);
            user = new User(ref deck, this, tbxUsername.Text);
            

            // Add dealer at the end
            players.AddLast(dealer);

            // Add UI2 if playing with it
            if (chkAI2.Checked)
            {
                players.AddFirst(new AIPlayer(ref deck, this, cmbDifficulty2.SelectedIndex, 2, tbxAI2name.Text));
            }
            
            // Add User
            players.AddFirst(user);

            // Add UI1 if playing with it
            if (chkAI1.Checked)
            {
                players.AddFirst(new AIPlayer(ref deck, this, cmbDifficulty1.SelectedIndex, 1, tbxAIName1.Text));
            }

            // Start the first round
            StartRound();
        }

        private void StartRound()
        {
            // Create an enumerator for the players
            playerEnumerator = players.GetEnumerator();

            // Call the new round function on each player
            foreach (Player player in players)
            {
                player.NewRound(buyinCost);
            }

            // Move enumerator to the first player. set the current player. start their turn.
            playerEnumerator.MoveNext();
            currentPlayer = playerEnumerator.Current;
            currentPlayer.StartTurn();
        }

        // Ends round
        private void EndRound()
        {
            // Determines the player with the most points
            int topPoints = 0;
            List<Player> topPlayers = new List<Player>();

            foreach (Player p in players)
            {
                if (p.Sum > topPoints) // Player has more points than the previous top player
                {
                    topPlayers.Clear(); // Clear the top players list (because the old ones have been beaten
                    topPlayers.Add(p); // Add the current player to the list
                    topPoints = p.Sum; // top points is equal to this player's points
                }
                else if (p.Sum == topPoints) // Same number of points as the current top player (tie)
                {
                    topPlayers.Add(p); // add the current player to the top players list
                }
            }

            // Tells us how many players there are in
            int numWinners = topPlayers.Count();

            if (numWinners == 0)
            {
                //Everyone busted
                MessageBox.Show("Everyone Busted.");
            }
            else if (numWinners == 1)
            {
                Player winner = topPlayers.First();

                string winMessage = string.Format("{0} Won!", winner.name);
                MessageBox.Show(winMessage);

                winner.Win(buyinCost * players.Count());
            }
            else if (numWinners > 1)
            {
                string playerNames = "";
                for (int i = 0; i < topPlayers.Count() - 1; i++)
                {
                    playerNames += topPlayers[i].name + ", ";
                }
                playerNames += "and " + topPlayers.Last().name + " Won!";

                MessageBox.Show(playerNames);

                foreach (Player winner in topPlayers)
                {
                    winner.Win(buyinCost * players.Count() / numWinners);
                }
            }

            StartRound();
        }

        public void NextTurn()
        {
            if (playerEnumerator.MoveNext() == true)
            {
                currentPlayer = playerEnumerator.Current;
                currentPlayer.StartTurn();
            }
            else
            {
                EndRound();
            }

        }

        private void StopGameplay()
        {
            
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopGameplay();

            chkAI1.Checked = false;
            chkAI2.Checked = false;
            tbxAI2name.Text = "";
            tbxAIName1.Text = "";
            tbxUsername.Text = "";
            cmbDifficulty1.SelectedIndex = -1;
            cmbDifficulty2.SelectedIndex = -1;

            grbSetup.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkAI1_CheckedChanged(object sender, EventArgs e)
        {
            bool chkd = chkAI1.Checked;

            tbxAIName1.Enabled = chkd;
            cmbDifficulty1.Enabled = chkd;
        }

        private void ChkAI2_CheckedChanged(object sender, EventArgs e)
        {
            bool chkd = chkAI2.Checked;

            tbxAI2name.Enabled = chkd;
            cmbDifficulty2.Enabled = chkd;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cmbDifficulty1.SelectedIndex);
            if (tbxUsername.Text == "" || (chkAI1.Checked && (tbxAIName1.Text == "" || cmbDifficulty1.SelectedIndex == -1)) || (chkAI2.Checked && (tbxAI2name.Text == "" || cmbDifficulty2.SelectedIndex == -1))){
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                grbSetup.Hide();

                StartGame();
            }
        }
    }
}
