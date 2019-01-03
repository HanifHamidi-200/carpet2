using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOWHN
{
    public partial class Form1 : Form
    {
        private List<String> _col1 = new List<string> { null, null, null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null, null, null };
        private int mnItem;
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 7; i++)
            {
                _col1[i - 1] = Convert.ToString(rnd1.Next(1, 401));
                _col2[i - 1] = Convert.ToString(rnd1.Next(1, 401));
            }

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                mnItem = 1;
            }
            else
            {
                mnItem = 2;
            }

            fUpdateDisplay();
        }

        private void fSave()
        {
            if (mnItem == 1)
            {
                _col1[0] = txt1.Text;
                _col1[1] = txt2.Text;
                _col1[2] = txt3.Text;
                _col1[3] = txt4.Text;
                _col1[4] = txt5.Text;
                _col1[5] = txt6.Text;
                _col1[6] = txt7.Text;
            }
            else
            {
                _col2[0] = txt1.Text;
                _col2[1] = txt2.Text;
                _col2[2] = txt3.Text;
                _col2[3] = txt4.Text;
                _col2[4] = txt5.Text;
                _col2[5] = txt6.Text;
                _col2[6] = txt7.Text;

            }
        }
        private void fUpdateDisplay()
        {
            if (mnItem == 1)
            {
                txt1.Text = _col1[0];
                txt2.Text = _col1[1];
                txt3.Text = _col1[2];
                txt4.Text = _col1[3];
                txt5.Text = _col1[4];
                txt6.Text = _col1[5];
                txt7.Text = _col1[6];
            }
            else
            {
                txt1.Text = _col2[0];
                txt2.Text = _col2[1];
                txt3.Text = _col2[2];
                txt4.Text = _col2[3];
                txt5.Text = _col2[4];
                txt6.Text = _col2[5];
                txt7.Text = _col2[6];

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst1_Click(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
            fUpdateDisplay();
        }
    }
}
