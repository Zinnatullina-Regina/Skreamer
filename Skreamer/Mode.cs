using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skreamer
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            int m = 5;
            int s = 0;
           
            Registration naming = new Registration(m, s);
            naming.ShowDialog();
           
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            int m = 2;
            int s = 0;
           
            Registration naming = new Registration(m, s);
            naming.ShowDialog();
           
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            int m = 0;
            int s = 30;
           
            Registration naming = new Registration(m, s);
            naming.ShowDialog();

        }
        
       
    }
}
