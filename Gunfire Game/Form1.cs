using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Gunfire_Game
    //from here i begin my codding
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;

        GenreateFire obj = new GenreateFire();



        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\gun-spinng.wav");
                splayer.Play();
            }
            if (x > 0)
            {
                picbox1.ImageLocation = @"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\gun spin.gif";
            }
            else
            {
                MessageBox.Show("Please click on Load Bullet First");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
                picbox1.ImageLocation = @"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\gunshoot.gif";
                if (y == z && cunt<2)
                {
                    cunt++;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\gun-gunshot.wav");
                    player.Play();
                    z = obj.fire();
                }
                if (cunt == 1)
                {
                    MessageBox.Show("Game over play again");
                    btnshoot.Enabled = false;

                }
            }
        }

        private void picbox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //this is for the sound
        {
            x = x + 1;
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\gun-loading.wav");
                splayer.Play();
            }
            if (x == 1)
            {
                picbox1.ImageLocation = @"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\gun load image.gif";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnshoot.Enabled = true;
            picbox1.ImageLocation = @"C:\Users\ising\source\repos\Gunfire Game\Gunfire Game\images\Gun-on-White-Background.jpg";
            
        }
    }
}
