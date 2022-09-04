using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Options : Form
    {
        public static string player1;
        public static string player2;
        public static int rounds;
        public static int time;
        public Options()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string name1 = tbName1.Text;
            string name2 = tbName2.Text;
            rounds = Convert.ToInt32(this.dUD_Rounds.SelectedItem);
            time = Convert.ToInt32(this.dUD_Seconds.SelectedItem);

            if (name1.Length < 2)
            {
                MessageBox.Show("Enter name for Player1 longer than 1 character");
                return;
            }
            if (name2.Length < 2)
            {
                MessageBox.Show("Enter name for Player2 longer than 1 character");
                return;
            }
            if (this.dUD_Seconds.SelectedItem == null)
            {
                MessageBox.Show("Select number of seconds for the round");
                return;
            }
            if (this.dUD_Rounds.SelectedItem == null)
            {
                MessageBox.Show("Select number of maximum rounds");
                return;
            }

            player1 = tbName1.Text;
            player2 = tbName2.Text;

            this.Close();
            Game f = new Game();
            f.Show();

        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Font = new Font(" ", 14);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Font = new Font(" ", 12);
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.Font = new Font(" ", 14);
        }

        private void btnSart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Font = new Font(" ", 12);
        }

        private void Options_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.dUD_Rounds.Items;
            DomainUpDown.DomainUpDownItemCollection collectionSec = this.dUD_Seconds.Items;

            collection.Add("3");
            collection.Add("5");
            collection.Add("7");
            collection.Add("9");

            this.dUD_Rounds.Text = "Select";

            for (int i = 10; i <= 90; i++)
                collectionSec.Add(i.ToString());

            this.dUD_Seconds.Text = "Select";
        }

    }
}
