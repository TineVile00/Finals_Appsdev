using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProj
{
    public partial class Cupcakeuc : UserControl
    {
        public Cupcakeuc()
        {
            InitializeComponent();
        }

        private void ccPrevBtn_Click(object sender, EventArgs e)
        {
            var parent7 = this.Parent as Form1;
            var DashPan = parent7.dashboard1;
            var ccCupcakePan = parent7.cupcakeuc1;

            DashPan.Show();
            ccCupcakePan.Hide();
        }

        private void ccNextBtn_Click(object sender, EventArgs e)
        {
            var parent7 = this.Parent as Form1;
            var DashPan = parent7.dashboard1;
            var ccCupcakePan = parent7.cupcakeuc1;
            var CookiePan = parent7.cookies1;

            DashPan.Hide();
            ccCupcakePan.Hide();
            CookiePan.Show();
        }
    }
}
