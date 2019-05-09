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
        public Deck deck = new Deck();

        public frmBetter21()
        {
            InitializeComponent();
            this.pbxTest.Image = GetCardImage('C', 2);
        }

        Image GetCardImage(char suit, int number)
        {
            string path = @"Cards\";

            Image img;

            path += Convert.ToString(number) + Convert.ToString(suit) + ".png";

            img = new Bitmap(path);

            return img;
        }

        public void CreateDealerUI()
        {
            lblDealer.Show();
        }

        public void AddCard(Card Player, Player player)
        {

        }
    }
}
