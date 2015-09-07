using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RunAndJump
{
    public partial class RunAndJump : Form
    {
        string[] woorden = File.ReadAllLines(@"C:\Users\gabyg4\Documents\Visual Studio 2015\Projects\RunAndJump\RunAndJump\bin\Debug\woorden.txt");
        int a = 0;
        int points = 0;
        int time = 0;
        int left = 0;
        int top = 250;
        int left2;
        int top2;

        public RunAndJump()
        {
            InitializeComponent();
            tmSeconds.Start();
            tmRunToRight.Start();
            lbwoorden.Enabled = false;
            lbwoorden.Text = woorden[a];
            lbtime.Text = "0";
            lbpoints.Text = "0";
        }

        private void tmSeconds_Tick(object sender, EventArgs e)
        {
            tmSeconds.Stop();

            time++;
            lbtime.Text = time.ToString();

            tmSeconds.Start();
        }

        private void tmRunToRight_Tick(object sender, EventArgs e)
        {
            left++;
            lbwoorden.Left = left;

            if (lbwoorden.Left >= this.Right)
            {
                a++;
                left = 0;
                lbwoorden.Text = woorden[a];
                
            }
        }


        private void tmJump_Tick(object sender, EventArgs e)
        {
            tmJump.Stop();

            Random rnd = new Random();
            left2 = rnd.Next(0, 500);
            top2 = rnd.Next(0, 500);

            lbwoorden.Top = top2;
            lbwoorden.Left = left2;

            tmJump.Start();            
        }

        private void lbwoorden_Click(object sender, EventArgs e)
        {
            try
            {
                points++;
                left = 0;
                txtinput.Clear();
                txtinput.Focus();
                a++;
                lbwoorden.Text = woorden[a];
                lbpoints.Text = points.ToString();
                lbwoorden.Top = top;
                lbwoorden.Enabled = false;
                tmRunToRight.Start();
                tmJump.Stop();
            }
            catch (Exception)
            {
                MessageBox.Show("Gefeliciteerd, je hebt het spel uitgespeeld!");
                MessageBox.Show("Je hebt er "+time.ToString()+" seconden over gedaan");
                tmSeconds.Stop();
            }
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
            if (lbwoorden.Text == txtinput.Text)
            {
                lbwoorden.Enabled = true;
                tmRunToRight.Stop();
                tmJump.Start();
            }
        }
    }
}
