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

namespace Skreamer
{
    public partial class Registration : Form
    {
        int m, s;

        public Registration(int m, int s)
        {
            this.m = m;
            this.s = s;
            InitializeComponent();
            
        }

        

        public void Start_Click(object sender, EventArgs e)
        {
            
            Play pictures = new Play(m, s, richTextBox1.Text);
            pictures.ShowDialog();

           


        }
       

    }
}

