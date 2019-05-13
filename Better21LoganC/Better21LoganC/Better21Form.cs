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
        public Deck deck;
        private Dealer dealer;
        private User user;
        private LinkedList<Player> players = new LinkedList<Player>();
        private LinkedList<Player>.Enumerator playerEnumerator;
        private Player currentPlayer;
        private int buyinCost = 50;

        public frmBetter21()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            deck = new Deck();
            dealer = new Dealer(ref deck, this);
            user = new User(ref deck, this, tbxUsername.Text);
            

            players.AddLast(dealer);

            if (chkAI2.Checked)
            {
                players.AddFirst(new AIPlayer(ref deck, this, cmbDifficulty2.SelectedIndex, 2, tbxAI2name.Text));
            }
                
            players.AddFirst(user);

            if (chkAI1.Checked)
            {
                players.AddFirst(new AIPlayer(ref deck, this, cmbDifficulty1.SelectedIndex, 1, tbxAIName1.Text));
            }

            StartRound();
        }

        private void StartRound()
        {
            playerEnumerator = players.GetEnumerator();

            foreach (Player player in players)
            {
                player.NewRound(buyinCost);
            }

            playerEnumerator.MoveNext();
            currentPlayer = playerEnumerator.Current;
            currentPlayer.StartTurn();
        }

        private void EndRound()
        {
            int topPoints = 0;
            List<Player> topPlayers = new List<Player>();

            foreach (Player p in players)
            {
                Console.WriteLine(string.Format("{0}: {1}", p.name, p.Sum));

                if (p.Sum > topPoints)
                {
                    topPlayers.Clear();
                    topPlayers.Add(p);
                    topPoints = p.Sum;
                }
                else if (p.Sum == topPoints)
                {
                    topPlayers.Add(p);
                }
            }

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

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
