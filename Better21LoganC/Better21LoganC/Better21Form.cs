﻿using System;
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
        private Dealer dealer;
        private User user;

        public frmBetter21()
        {
            InitializeComponent();


            dealer = new Dealer(ref deck, this);
            user = new User(ref deck, this);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            dealer.StartTurn();
            user.StartTurn();
        }
    }
}
