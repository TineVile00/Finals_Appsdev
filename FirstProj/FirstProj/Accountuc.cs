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
    public partial class Accountuc : UserControl
    {
        public Accountuc()
        {
            InitializeComponent();
        }

        private void Accountuc_Load(object sender, EventArgs e)
        {

        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var RegisterPan = parent3.registerpanel1;
            var LogInPan = parent3.logInpanel1;
            var AccountPan = parent3.accountuc1;


            RegisterPan.Hide();
            LogInPan.Show();
            AccountPan.Hide();
        }

        private void DasbaordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;
            var AccountPan = parent3.accountuc1;
            var CartPan = parent3.cartUc1;

            CartPan.Hide();
            DashPan.Show();
            AccountPan.Hide();
        }

        private void CartLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;
            var AccountPan = parent3.accountuc1;
            var CartPan = parent3.cartUc1;

            CartPan.Show();
            DashPan.Hide();
            AccountPan.Hide();
        }

        private void HistoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;
            var AccountPan = parent3.accountuc1;
            var CartPan = parent3.cartUc1;
            var HistoryPan = parent3.historyUc1;

            CartPan.Hide();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;

            DashPan.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashPicBox_Click(object sender, EventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;
            var AccountPan = parent3.accountuc1;
            var CartPan = parent3.cartUc1;

            CartPan.Hide();
            DashPan.Show();
            AccountPan.Hide();
        }

        private void CartPicBox_Click(object sender, EventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;
            var AccountPan = parent3.accountuc1;
            var CartPan = parent3.cartUc1;

            CartPan.Show();
            DashPan.Hide();
            AccountPan.Hide();
        }

        private void HistPicBox_Click(object sender, EventArgs e)
        {
            var parent3 = this.Parent as Form1;
            var DashPan = parent3.dashboard1;
            var AccountPan = parent3.accountuc1;
            var CartPan = parent3.cartUc1;
            var HistoryPan = parent3.historyUc1;

            CartPan.Hide();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Show();
        }
    }
}
