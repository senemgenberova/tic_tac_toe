using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool playerChoosing()
        {
            if (this.player.Text == "player1")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public void fillButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (this.playerChoosing())
            {
                b.Text = "X";
                this.player.Text = "player2";

            }
            else {
                b.Text = "O";
                this.player.Text = "player1";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
        }
    }
}
