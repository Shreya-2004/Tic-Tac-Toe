using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : MetroForm
    {
        int player1, player2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tick = "O";
        }

        string tick = "";
        public void switchBUtton()
        {
            if (tick == "O")
            {
                tick = "X";
            }
            else
            {
                tick = "O";
            }
        }

        int click;
        public void ButtonClick(Button btn)
        {
            switchBUtton();
            btn.Text = tick; ;

            checkit();
        }

        private void button_Click1(object sender, EventArgs e)
        {
            ButtonClick(button1);

        }
   
        private void button_Click2(object sender, EventArgs e)
        {
            ButtonClick(button2);

        }

        private void button_Click3(object sender, EventArgs e)
        {
            ButtonClick(button3);

        }

        private void button_Click4(object sender, EventArgs e)
        {
            ButtonClick(button4);

        }

        private void button_Click5(object sender, EventArgs e)
        {
            ButtonClick(button5);

        }

        private void button_Click6(object sender, EventArgs e)
        {
            ButtonClick(button6);

        }

        private void button_Click7(object sender, EventArgs e)
        {
            ButtonClick(button7);

        }

        private void button_Click8(object sender, EventArgs e)
        {
            ButtonClick(button8);

        }

        private void button_Click9(object sender, EventArgs e)
        {
            ButtonClick(button9);

        }


        public void Reset()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;



            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            button6.BackColor = Color.LightGray;
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
            button9.BackColor = Color.LightGray;

            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (txt_player1.Text == "" || txt_player2.Text == "")
            {
                MessageBox.Show("Complete the field", "ALert");
            }
            else
            {
                lbl_player1.Text = txt_player1.Text;
                lbl_player2.Text = txt_player2.Text;

                groupBox1.Visible = false;
                lbl_newplayers.Visible = true;
            }
        }

        private void lbl_newplayers_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txt_player1.Text = "";
            txt_player2.Text = "";
            lbl_player1score.Text = "";
            lbl_player2score.Text = "";
            lbl_newplayers.Visible= false;
            player1 = 0;
            player2 = 0;
           
        } 
        
        public void checkit()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.MediumTurquoise;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.MediumTurquoise;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.MediumTurquoise;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!", "Match Status");
                        Reset();
                        player1++; 
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!" , "Match Status");
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.MediumTurquoise;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.MediumTurquoise;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.MediumTurquoise;
                    button7.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!", "Match Status"); 
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!", "Match Status"); 
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.MediumTurquoise;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.MediumTurquoise;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.MediumTurquoise;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!", "Match Status"); 
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!" , "Match Status");
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.MediumTurquoise;
                    button2.ForeColor = Color.White;
                    button5.BackColor = Color.MediumTurquoise;
                    button5.ForeColor = Color.White;
                    button8.BackColor = Color.MediumTurquoise;
                    button8.ForeColor = Color.White;
                    if (button2.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!", "Match Status"); 
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!" , "Match Status"); 
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.MediumTurquoise;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.MediumTurquoise;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.MediumTurquoise;
                    button7.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!", "Match Status"); 
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!", "Match Status"); 
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.MediumTurquoise;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.MediumTurquoise;
                    button6.ForeColor = Color.White;
                    button9.BackColor = Color.MediumTurquoise;
                    button9.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!" , "Match Status");
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!" , "Match Status");
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.MediumTurquoise;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.MediumTurquoise;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.MediumTurquoise;
                    button6.ForeColor = Color.White;
                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!" , "Match Status"); 
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!", "Match Status"); 
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }


            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.MediumTurquoise;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.MediumTurquoise;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.MediumTurquoise;
                    button9.ForeColor = Color.White;
                    if (button7.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!", "Match Status");
                        Reset();
                        player1++;
                        lbl_player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!", "Match Status");
                        Reset();
                        player2++;
                        lbl_player2score.Text = player2.ToString();
                    }
                }
            }

            if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
               
                    MessageBox.Show("Draw","Match Status");
                    lbl_player1score.Text = "";
                    lbl_player2score.Text = "";
                    Reset();

            }
        }
    }
}


