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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void CartLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent4 = this.Parent as Form1;
            var DashPan = parent4.dashboard1;
            var AccountPan = parent4.accountuc1;
            var CartPan = parent4.cartUc1;
            var HistoryPan = parent4.historyUc1;

            CartPan.Show();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Hide();
        }

        private void ButterflyBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SubflowerBtn_Click(object sender, EventArgs e)
        {

        }

        private void AccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent4 = this.Parent as Form1;
            var DashPan = parent4.dashboard1;
            var AccountPan = parent4.accountuc1;

            DashPan.Hide();
            AccountPan.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void DasbaordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void HistoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent4 = this.Parent as Form1;
            var DashPan = parent4.dashboard1;
            var AccountPan = parent4.accountuc1;
            var CartPan = parent4.cartUc1;
            var HistoryPan = parent4.historyUc1;

            CartPan.Hide();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Show();
        }

        private void CartPicBox_Click(object sender, EventArgs e)
        {
            var parent4 = this.Parent as Form1;
            var DashPan = parent4.dashboard1;
            var AccountPan = parent4.accountuc1;
            var CartPan = parent4.cartUc1;
            var HistoryPan = parent4.historyUc1;

            CartPan.Show();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Hide();
        }

        private void HistPicBox_Click(object sender, EventArgs e)
        {
            var parent4 = this.Parent as Form1;
            var DashPan = parent4.dashboard1;
            var AccountPan = parent4.accountuc1;
            var CartPan = parent4.cartUc1;
            var HistoryPan = parent4.historyUc1;

            CartPan.Hide();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Show();
        }

        private void AccPicBox_Click(object sender, EventArgs e)
        {
            var parent4 = this.Parent as Form1;
            var DashPan = parent4.dashboard1;
            var AccountPan = parent4.accountuc1;

            DashPan.Hide();
            AccountPan.Show();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
             var parent4 = this.Parent as Form1;
             var ccCupcakePan = parent4.cupcakeuc1;

             ccCupcakePan.Show();
             ccCupcakePan.BringToFront();
        }
    }
}
