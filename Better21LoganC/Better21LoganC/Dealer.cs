using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace Better21LoganC
{
    public class Dealer : Player
    {
        /* Constructor */
        public Dealer(ref Deck d, frmBetter21 m) : base(ref d, ref m)
        {
            name = "Dealer";

            handPosition = 50;

            UIx = 700;
            UIy = 186;

            CreateUI();
        }

        /* Override Functions */

        public async override void StartTurn()
        {
            EnableControls(true);

            await Sleep.sleep(1000);

            while (sum < 16)
            {
                await Sleep.sleep(500);
                Hit(true);
            }

            EndTurn();
        }

        public override void NewRound(int buyIn)
        {
            base.NewRound(buyIn);

            Hit(true);
            Hit(true);

            EnableControls(false);

            lblSum.Hide();
        }
    }
}
