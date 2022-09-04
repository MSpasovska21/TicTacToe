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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Play_MouseHover(object sender, EventArgs e)
        {
            btnPlay.Font = new Font("Segoe Print", 16, FontStyle.Bold);
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Font = new Font("Segoe Print", 14, FontStyle.Bold);
        }

        private void HowToPlay_MouseHover(object sender, EventArgs e)
        {
            btnHowToPlay.Font = new Font("Segoe Print", 16, FontStyle.Bold);
        }

        private void HowToPlay_MouseLeave(object sender, EventArgs e)
        {
            btnHowToPlay.Font = new Font("Segoe Print", 14, FontStyle.Bold);
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Font = new Font("Segoe Print", 16, FontStyle.Bold);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Font = new Font("Segoe Print", 14, FontStyle.Bold);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            Instructions uslovi = new Instructions();
            uslovi.ShowDialog();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Options fo = new Options();
            this.Hide();
            fo.Show();
        }

        private void lnlRights_Click(object sender, EventArgs e)
        {
            string text = "Tic Tac Toe is made by\r\n";
            text += "\t1. Monika Spasovska (186012)\r\n";
            text += "under mentorship of\r\n";
            text += "\t1. Dejan Gjorgjevic, Ph.D.\r\n";
            text += "\t2. Stefan Andonov, BSc\r\n\r\n";
            text += "This project is part of course Visual Programming in academic year 2021/2022.\r\n";
            text += "All rights reserved by FCSE.\r\n";

            MessageBox.Show(text, "COPYRIGHT");
        }

    }
}
