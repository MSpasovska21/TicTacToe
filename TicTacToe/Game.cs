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
    public partial class Game : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void score()
        {
            if(button1.Text=="X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Pink;
                button4.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.CadetBlue;
                button5.BackColor = Color.CadetBlue;
                button7.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.SlateBlue;
                button5.BackColor = Color.SlateBlue;
                button8.BackColor = Color.SlateBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Violet;
                button6.BackColor = Color.Violet;
                button9.BackColor = Color.Violet;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.DarkSlateBlue;
                button5.BackColor = Color.DarkSlateBlue;
                button6.BackColor = Color.DarkSlateBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Azure;
                button8.BackColor = Color.Azure;
                button9.BackColor = Color.Azure;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }

            //=============================================================

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.LemonChiffon;
                button4.BackColor = Color.LemonChiffon;
                button7.BackColor = Color.LemonChiffon;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.BlueViolet;
                button5.BackColor = Color.BlueViolet;
                button9.BackColor = Color.BlueViolet;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.NavajoWhite;
                button5.BackColor = Color.NavajoWhite;
                button7.BackColor = Color.NavajoWhite;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.SandyBrown;
                button5.BackColor = Color.SandyBrown;
                button8.BackColor = Color.SandyBrown;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.SeaGreen;
                button6.BackColor = Color.SeaGreen;
                button9.BackColor = Color.SeaGreen;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Azure;
                button5.BackColor = Color.Azure;
                button6.BackColor = Color.Azure;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.DarkBlue;
                button8.BackColor = Color.DarkBlue;
                button9.BackColor = Color.DarkBlue;

                MessageBox.Show("The winner is Player Y", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
        }

        public Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;                   
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                lblPlayerX.Text = "0";
                lblPlayerY.Text = "0";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                btnNewGame.Enabled = true;

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Tic Tac Toe", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if(iExit == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
