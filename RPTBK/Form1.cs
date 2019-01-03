using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPTBK
{
    public partial class Form1 : Form
    { 
        private int mnItem;


        private void fUpdateDisplay()
        {
            fra1.Visible = false;
            fra2.Visible = false;

            if (mnItem == 1)
            {
                fra1.Visible = true;
            }
            else
            {
                fra2.Visible = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            fra1.Left = fra2.Left;
            fra1.Top = fra2.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fUpdateDisplay();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay();

        }
    }
}
