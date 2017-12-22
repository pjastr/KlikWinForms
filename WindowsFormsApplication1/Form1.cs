using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Klikniecie(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == button1) MessageBox.Show("Przycisk 1");
            else if (btn == button2) MessageBox.Show("Przycisk 2");
        }
    }
}
