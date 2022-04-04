using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;

namespace Skreamer
{
    public partial class Play : Form
    {
        int m, s, num, win;
        bool hope = true;
        string count;
        Random rnd = new Random();

        public Play(int m,int s, string count)
        {
            
            this.m = m;
            this.s = s;
            this.count = count;

            InitializeComponent();
            timer.Start();


            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


            Unit();


        }

        public void Unit()
        {

            pictureBox1.Image = new Bitmap(@"11.jpg");
            pictureBox2.Image = new Bitmap(@"11.jpg");
            pictureBox3.Image = new Bitmap(@"11.jpg");
            pictureBox4.Image = new Bitmap(@"11.jpg");
            pictureBox5.Image = new Bitmap(@"11.jpg");
            pictureBox6.Image = new Bitmap(@@"11.jpg");
            pictureBox7.Image = new Bitmap(@"11.jpg");
            pictureBox8.Image = new Bitmap(@"11.jpg");
            pictureBox9.Image = new Bitmap(@"11.jpg");
            pictureBox10.Image = new Bitmap(@"11.jpg");
            pictureBox11.Image = new Bitmap(@"11.jpg");
            pictureBox12.Image = new Bitmap(@"11.jpg");
            pictureBox13.Image = new Bitmap(@"11.jpg");
            pictureBox14.Image = new Bitmap(@"11.jpg");
            pictureBox15.Image = new Bitmap(@"11.jpg");
            pictureBox16.Image = new Bitmap(@"11.jpg");
            pictureBox17.Image = new Bitmap(@"11.jpg");
            pictureBox18.Image = new Bitmap(@"11.jpg");
            pictureBox19.Image = new Bitmap(@"11.jpg");
            pictureBox20.Image = new Bitmap(@"11.jpg");
            pictureBox21.Image = new Bitmap(@"11.jpg");
            pictureBox22.Image = new Bitmap(@"11.jpg");
            pictureBox23.Image = new Bitmap(@"11.jpg");
            pictureBox24.Image = new Bitmap(@"11.jpg");
            pictureBox25.Image = new Bitmap(@"11.jpg");
          


            Change();
        }

        private void Change()
        {
            if (hope)
            {
                num = rnd.Next(1, 26);
                hope = false;
            }


        }

        
        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            if (num == 2)
            {
                pictureBox2.Image = (Image)new Bitmap(@"2.jpg");

                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();

              
            }
            else { pictureBox2.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            if (num == 3)
            {
                
                pictureBox3.Image = new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox3.Image =  new Bitmap (@"3.jpg"); }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            if (num == 4)
            {
                pictureBox4.Image = new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox4.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
            if (num == 9)
            {
                pictureBox9.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox9.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
            if (num == 10)
            {
                pictureBox10.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox10.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
            if (num == 11)
            {
                pictureBox11.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox11.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           
            if (num == 12)
            {
                pictureBox12.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox12.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
           
            if (num == 13)
            {
                pictureBox13.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox13.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
           
            if (num == 14)
            {
                pictureBox14.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox14.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
           
            if (num == 15)
            {
                pictureBox15.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox15.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           
            if (num == 16)
            {
                pictureBox16.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox16.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
            if (num == 17)
            {
                pictureBox17.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox17.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
           
            if (num == 18)
            {
                pictureBox18.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();

            }
            else { pictureBox18.Image = (Image)new Bitmap(@"3.jpg"); }


        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
           
            if (num == 19)
            {
                pictureBox19.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox19.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
           
            if (num == 20)
            {
                pictureBox20.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox20.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
           
            if (num == 21)
            {

                pictureBox21.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox21.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
           
            if (num == 22)
            {
                pictureBox22.Image = new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox22.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
          
            if (num == 23)
            {
                pictureBox23.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox23.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            
            if (num == 24)
            {
                pictureBox24.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox24.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
           
            if (num == 25)
            {

                pictureBox25.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox25.Image = (Image)new Bitmap(@"3.jpg"); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if (num == 1)
            {
                pictureBox1.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox1.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            if (num == 5)
            {
                pictureBox5.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox5.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            if (num == 6)
            {
                pictureBox6.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
                
            }
            else { pictureBox6.Image = (Image)new Bitmap(@"3.jpg"); }
        }

       

       
        private void pictureBox7_Click(object sender, EventArgs e)
        {
          

            if (num == 7)
            {
                pictureBox7.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }
            else { pictureBox7.Image = (Image)new Bitmap(@"3.jpg"); }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            if (num == 8)
            {
                pictureBox8.Image = (Image)new Bitmap(@"2.jpg");
                hope = true;
                win++;
                Thread.Sleep(2000);
                Unit();
               
            }

            else { pictureBox8.Image = (Image)new Bitmap(@"3.jpg"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
              s = s - 1;
                if (s == -1)
                {
                    m = m - 1;
                    s = 59;
                }
                if (m == 0 && s == 0)
                {
                   if (win < 10)
                   {
                    timer.Stop();
                    SkreamerShow wow = new SkreamerShow();
                     wow.ShowDialog();
                   }
                   else
                   {
                    timer.Stop();
                    Winer el = new Winer();
                    el.ShowDialog();
                    }

                    StreamWriter sw = new StreamWriter("C:\\Resalts.txt");
                    string h = Convert.ToString(win);
                    sw.WriteLine(count + " " + h);
                    sw.Close();

                }

                label1.Text = Convert.ToString($"{m}:{s}");

            
           

        }




    }
}
