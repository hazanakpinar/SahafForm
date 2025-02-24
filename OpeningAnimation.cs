using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksellerApp
{
    public partial class OpeningAnimation : Form
    {
        public OpeningAnimation()
        {
            InitializeComponent();
        }
        bool act = false;
        private void tmrOpening_Tick(object sender, EventArgs e)
        {
            if (!act)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                act = true;
            }
            if (act)
            {
                this.Opacity -= 0.009;
                if (this.Opacity == 0)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                    tmrOpening.Enabled = false;
                }
            }
        }
    }
}
