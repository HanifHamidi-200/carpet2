using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENACT
{
    public partial class Form1 : Form
    {
        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;

            nValue = rnd1.Next(1, 101);
            lbl1.Text = Convert.ToString(nValue);
            nValue = rnd1.Next(1, 101);
            lbl2.Text = Convert.ToString(nValue);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
