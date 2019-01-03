using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROBOT
{
    public partial class Form1 : Form
    {
        private int mnItem;

        private void fReset()
        {
            Random rnd1 = new Random();

            mnItem = rnd1.Next(1, 4);
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lst1.Visible = false;
            lst2.Visible = false;
            lst3.Visible = false;

            switch (mnItem)
            {
                case 1:
                    lst1.Visible = true;
                    break;
                case 2:
                    lst2.Visible = true;
                    break;
                default:
                    lst3.Visible = true;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
            lst2.Left = lst1.Left;
            lst2.Top = lst1.Top;
            lst3.Left = lst1.Left;
            lst3.Top = lst1.Top;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
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

        private void btn3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fUpdateDisplay();

        }
    }
}
