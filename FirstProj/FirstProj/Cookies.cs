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
    public partial class Cookies : UserControl
    {
        public Cookies()
        {
            InitializeComponent();
        }

        private void cooPrevBtn_Click(object sender, EventArgs e)
        {
            var parent8 = this.Parent as Form1;
            var CookiePan = parent8.cookies1;
            var ccCupcakePan = parent8.cupcakeuc1;
            var DashPan = parent8.dashboard1;

            CookiePan.Hide();
            ccCupcakePan.Show();
            DashPan.Hide();
        }
    }
}
