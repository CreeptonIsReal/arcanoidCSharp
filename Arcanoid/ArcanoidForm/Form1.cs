using Arcanoid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcanoidForm
{
          public partial class Form1 : Form
          {
                    public Form1()
                    {
                              InitializeComponent();
                    }

                    private void button1_Click(object sender, EventArgs e)
                    {
                              game2.StartGame();
                              if (game2._timer.Enabled == true)
                              {
                                        button1.Enabled = false;
                              }
                    }

                    private void button2_Click(object sender, EventArgs e)
                    {
                              game2.StopGame();
                              button1.Enabled = true;
                    }

                    private void game_Score(object sender, EventArgs e)
                    {
                              int score = game2.Score;
                              label1Score.Text = "Score: " + score;
                    }

                    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
                    {
                              e.Cancel = game2.GmStatus != 0;
                    }
          }
}

