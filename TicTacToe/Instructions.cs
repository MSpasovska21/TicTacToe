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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            tbInstructions.Text = " Tic Tac Toe \r\n";
            tbInstructions.Text += "   For 2 players\r\n\r\n\r\n\r\n";
            tbInstructions.Text += "The rules are simple: Try to build a line of three marks (X or O) while keeping your " +
                "opponent from doing the same.Sounds easy, but it's not! The vertical strategy creates a unique " +
                "challenge:you must think in a whole new way to block your opponent's moves! \r\n\r\n\r\n";
            tbInstructions.Text += "OBJECT \r\n\r\n";
            tbInstructions.Text += "Be the first player to get three of your marks in a row - horizontally, " +
                "vertivally or diagonally. \r\n\r\n\r\n";
            tbInstructions.Text += "HOW TO PLAY \r\n\r\n";
            tbInstructions.Text += "1. Decide who plays first. Players will alternate turns after playing a mark. \r\n";
            tbInstructions.Text += "    NOTE: The player starting the first game will play second in the next game. \r\n\r\n";
            tbInstructions.Text += "2. On your turn, drop one of your marks i.e. select the wanted field \r\n\r\n";
            tbInstructions.Text += "3. Play alternates until one player gets THREE marks in a row. " +
                "The three in a row can be horizontal, vertical or diagonal. \r\n\r\n\r\n";
            tbInstructions.Text += "HOW TO WIN \r\n\r\n";
            tbInstructions.Text += "If you are the first player to get three of your marks in a row, you win the round! You can play as many rounds as you want. The player with bigger score win the game! \r\n\r\n\r\n";
            tbInstructions.Text += "TO START ANOTHER GAME \r\n\r\n";
            tbInstructions.Text += "Once when you finished the round, you can start another round by pressing RESTART, " +
                "or you can choose NEW GAME and start all over again. \r\n\r\n\r\n";
            tbInstructions.Text += "HISTORY \r\n\r\n";
            tbInstructions.Text += "Games played on three-in-a-row boards can be traced back to ancient Egypt, " +
                "where such game boards have been found on roofing tiles dating from around 1300 BC. " +
                "In 1952, OXO (or Noughts and Crosses), developed by British computer scientist Sandy Douglas for the EDSAC computer at " +
                "the University of Cambridge, became one of the first known video games. The computer player could play perfect games of tic-tac-toe against a human opponent.\r\n\r\n";
            tbInstructions.Text += "Other names for this this game are \"Noughts and crosses\" and \"Xs and Os\". \r\n";

        }

        private void Insttructions_Resize(object sender, EventArgs e)
        {
            tbInstructions.Size = new System.Drawing.Size(this.Size.Width - 27, this.Size.Height - 48);
        }
    }
}
