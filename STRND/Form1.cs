using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRND
{
    public partial class Form1 : Form
    {
        private List<bool> _bLetterNumber = new List<bool> { true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        private List<String> _sTextLeft = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _nNumberRight = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private int mnItem;

        private void fReset()
        {
            Random rnd1 = new Random();
            char sLetter;

            for (int i = 1; i <= 14; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _bLetterNumber[i - 1] = true;
                }
                else
                {
                    _bLetterNumber[i - 1] = false;
                }
                sLetter =(char)(rnd1.Next(1, 27) + 64);
                _sTextLeft[i - 1] = Convert.ToString(sLetter);
                _nNumberRight[i - 1] = rnd1.Next(1, 401);
            }

            mnItem = rnd1.Next(1, 15);
            fUpdateDisplay();
        }


        private void fUpdateDisplay()
        {
            lblLetter1.BackColor = Color.Yellow;
            lblLetter2.BackColor = Color.Yellow;
            lblLetter3.BackColor = Color.Yellow;
            lblLetter4.BackColor = Color.Yellow;
            lblLetter5.BackColor = Color.Yellow;
            lblLetter6.BackColor = Color.Yellow;
            lblLetter7.BackColor = Color.Yellow;
            lblLetter8.BackColor = Color.Yellow;
            lblLetter9.BackColor = Color.Yellow;
            lblLetter10.BackColor = Color.Yellow;
            lblLetter11.BackColor = Color.Yellow;
            lblLetter12.BackColor = Color.Yellow;
            lblLetter13.BackColor = Color.Yellow;
            lblLetter14.BackColor = Color.Yellow;

            lblNumber1.BackColor = Color.Yellow;
            lblNumber2.BackColor = Color.Yellow;
            lblNumber3.BackColor = Color.Yellow;
            lblNumber4.BackColor = Color.Yellow;
            lblNumber5.BackColor = Color.Yellow;
            lblNumber6.BackColor = Color.Yellow;
            lblNumber7.BackColor = Color.Yellow;
            lblNumber8.BackColor = Color.Yellow;
            lblNumber9.BackColor = Color.Yellow;
            lblNumber10.BackColor = Color.Yellow;
            lblNumber11.BackColor = Color.Yellow;
            lblNumber12.BackColor = Color.Yellow;
            lblNumber13.BackColor = Color.Yellow;
            lblNumber14.BackColor = Color.Yellow;


            if (_bLetterNumber[0])
            {
                lblLetter1.Text = _sTextLeft[0];
                lblNumber1.Text = Convert.ToString(_nNumberRight[0]);
                lblNumber1.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter1.Text = Convert.ToString(_nNumberRight[0]);
                lblNumber1.Text = _sTextLeft[0];
                lblLetter1.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[1])
            {
                lblLetter2.Text = _sTextLeft[1];
                lblNumber2.Text = Convert.ToString(_nNumberRight[1]);
                lblNumber2.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter2.Text = Convert.ToString(_nNumberRight[1]);
                lblNumber2.Text = _sTextLeft[1];
                lblLetter2.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[2])
            {
                lblLetter3.Text = _sTextLeft[2];
                lblNumber3.Text = Convert.ToString(_nNumberRight[2]);
                lblNumber3.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter3.Text = Convert.ToString(_nNumberRight[2]);
                lblNumber3.Text = _sTextLeft[2];
                lblLetter3.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[3])
            {
                lblLetter4.Text = _sTextLeft[3];
                lblNumber4.Text = Convert.ToString(_nNumberRight[3]);
                lblNumber4.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter4.Text = Convert.ToString(_nNumberRight[3]);
                lblNumber4.Text = _sTextLeft[3];
                lblLetter4.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[4])
            {
                lblLetter5.Text = _sTextLeft[4];
                lblNumber5.Text = Convert.ToString(_nNumberRight[4]);
                lblNumber5.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter5.Text = Convert.ToString(_nNumberRight[4]);
                lblNumber5.Text = _sTextLeft[4];
                lblLetter5.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[5])
            {
                lblLetter6.Text = _sTextLeft[5];
                lblNumber6.Text = Convert.ToString(_nNumberRight[5]);
                lblNumber6.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter6.Text = Convert.ToString(_nNumberRight[5]);
                lblNumber6.Text = _sTextLeft[5];
                lblLetter6.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[6])
            {
                lblLetter7.Text = _sTextLeft[6];
                lblNumber7.Text = Convert.ToString(_nNumberRight[6]);
                lblNumber7.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter7.Text = Convert.ToString(_nNumberRight[6]);
                lblNumber7.Text = _sTextLeft[6];
                lblLetter7.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[7])
            {
                lblLetter8.Text = _sTextLeft[7];
                lblNumber8.Text = Convert.ToString(_nNumberRight[7]);
                lblNumber8.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter8.Text = Convert.ToString(_nNumberRight[7]);
                lblNumber8.Text = _sTextLeft[7];
                lblLetter8.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[8])
            {
                lblLetter9.Text = _sTextLeft[8];
                lblNumber9.Text = Convert.ToString(_nNumberRight[8]);
                lblNumber9.BackColor = Color.LightGreen;
            }
            else
            { 
                lblLetter9.Text = Convert.ToString(_nNumberRight[8]);
                lblNumber9.Text = _sTextLeft[8];
                lblLetter9.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[9])
            {
                lblLetter10.Text = _sTextLeft[9];
                lblNumber10.Text = Convert.ToString(_nNumberRight[9]);
                lblNumber10.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter10.Text = Convert.ToString(_nNumberRight[9]);
                lblNumber10.Text = _sTextLeft[9];
                lblLetter10.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[10])
            {
                lblLetter11.Text = _sTextLeft[10];
                lblNumber11.Text = Convert.ToString(_nNumberRight[10]);
                lblNumber11.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter11.Text = Convert.ToString(_nNumberRight[10]);
                lblNumber11.Text = _sTextLeft[10];
                lblLetter11.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[11])
            {
                lblLetter12.Text = _sTextLeft[11];
                lblNumber12.Text = Convert.ToString(_nNumberRight[11]);
                lblNumber12.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter12.Text = Convert.ToString(_nNumberRight[11]);
                lblNumber12.Text = _sTextLeft[11];
                lblLetter12.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[12])
            {
                lblLetter13.Text = _sTextLeft[12];
                lblNumber13.Text = Convert.ToString(_nNumberRight[12]);
                lblNumber13.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter13.Text = Convert.ToString(_nNumberRight[12]);
                lblNumber13.Text = _sTextLeft[12];
                lblLetter13.BackColor = Color.LightGreen;
            }
            if (_bLetterNumber[13])
            {
                lblLetter14.Text = _sTextLeft[13];
                lblNumber14.Text = Convert.ToString(_nNumberRight[13]);
                lblNumber14.BackColor = Color.LightGreen;
            }
            else
            {
                lblLetter14.Text = Convert.ToString(_nNumberRight[13]);
                lblNumber14.Text = _sTextLeft[13];
                lblLetter14.BackColor = Color.LightGreen;
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

        private void lblLetter1_Click(object sender, EventArgs e)
        {
            if (lblLetter1.BackColor == Color.LightGreen)
            {
                mnItem = 1;
            }
        }

        private void lblLetter2_Click(object sender, EventArgs e)
        {
            if (lblLetter2.BackColor == Color.LightGreen)
            {
                mnItem = 2;
            }

        }

        private void lblLetter3_Click(object sender, EventArgs e)
        {
            if (lblLetter3.BackColor == Color.LightGreen)
            {
                mnItem = 3;
            }

        }

        private void lblLetter4_Click(object sender, EventArgs e)
        {
            if (lblLetter4.BackColor == Color.LightGreen)
            {
                mnItem = 4;
            }

        }

        private void lblLetter5_Click(object sender, EventArgs e)
        {
            if (lblLetter5.BackColor == Color.LightGreen)
            {
                mnItem = 5;
            }

        }

        private void lblLetter6_Click(object sender, EventArgs e)
        {
            if (lblLetter6.BackColor == Color.LightGreen)
            {
                mnItem = 6;
            }

        }

        private void lblLetter7_Click(object sender, EventArgs e)
        {
            if (lblLetter7.BackColor == Color.LightGreen)
            {
                mnItem = 7;
            }

        }

        private void lblLetter8_Click(object sender, EventArgs e)
        {
            if (lblLetter8.BackColor == Color.LightGreen)
            {
                mnItem = 8;
            }

        }

        private void lblLetter9_Click(object sender, EventArgs e)
        {
            if (lblLetter9.BackColor == Color.LightGreen)
            {
                mnItem = 9;
            }

        }

        private void lblLetter10_Click(object sender, EventArgs e)
        {
            if (lblLetter10.BackColor == Color.LightGreen)
            {
                mnItem = 10;
            }

        }

        private void lblLetter11_Click(object sender, EventArgs e)
        {
            if (lblLetter11.BackColor == Color.LightGreen)
            {
                mnItem = 11;
            }

        }

        private void lblLetter12_Click(object sender, EventArgs e)
        {
            if (lblLetter12.BackColor == Color.LightGreen)
            {
                mnItem = 12;
            }

        }

        private void lblLetter13_Click(object sender, EventArgs e)
        {
            if (lblLetter13.BackColor == Color.LightGreen)
            {
                mnItem = 13;
            }

        }

        private void lblLetter14_Click(object sender, EventArgs e)
        {
            if (lblLetter14.BackColor == Color.LightGreen)
            {
                mnItem = 14;
            }

        }

        private void lblNumber1_Click(object sender, EventArgs e)
        {
            if (lblNumber1.BackColor == Color.LightGreen)
            {
                mnItem = 1;
            }

        }

        private void lblNumber2_Click(object sender, EventArgs e)
        {
            if (lblNumber2.BackColor == Color.LightGreen)
            {
                mnItem = 2;
            }

        }

        private void lblNumber3_Click(object sender, EventArgs e)
        {
            if (lblNumber3.BackColor == Color.LightGreen)
            {
                mnItem = 3;
            }

        }

        private void lblNumber4_Click(object sender, EventArgs e)
        {
            if (lblNumber4.BackColor == Color.LightGreen)
            {
                mnItem = 4;
            }

        }

        private void lblNumber5_Click(object sender, EventArgs e)
        {
            if (lblNumber5.BackColor == Color.LightGreen)
            {
                mnItem = 5;
            }

        }

        private void lblNumber6_Click(object sender, EventArgs e)
        {
            if (lblNumber6.BackColor == Color.LightGreen)
            {
                mnItem = 6;
            }

        }

        private void lblNumber7_Click(object sender, EventArgs e)
        {
            if (lblNumber7.BackColor == Color.LightGreen)
            {
                mnItem = 7;
            }

        }

        private void lblNumber8_Click(object sender, EventArgs e)
        {
            if (lblNumber8.BackColor == Color.LightGreen)
            {
                mnItem = 8;
            }

        }

        private void lblNumber9_Click(object sender, EventArgs e)
        {
            if (lblNumber9.BackColor == Color.LightGreen)
            {
                mnItem = 9;
            }

        }

        private void lblNumber10_Click(object sender, EventArgs e)
        {
            if (lblNumber10.BackColor == Color.LightGreen)
            {
                mnItem = 10;
            }

        }

        private void lblNumber11_Click(object sender, EventArgs e)
        {
            if (lblNumber11.BackColor == Color.LightGreen)
            {
                mnItem = 11;
            }

        }

        private void lblNumber12_Click(object sender, EventArgs e)
        {
            if (lblNumber12.BackColor == Color.LightGreen)
            {
                mnItem = 12;
            }

        }

        private void lblNumber13_Click(object sender, EventArgs e)
        {
            if (lblNumber13.BackColor == Color.LightGreen)
            {
                mnItem = 13;
            }

        }

        private void lblNumber14_Click(object sender, EventArgs e)
        {
            if (lblNumber14.BackColor == Color.LightGreen)
            {
                mnItem = 14;
            }

        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (_nNumberRight[mnItem - 1] != 14)
            {
                _nNumberRight[mnItem - 1] += 1;
            }
            fUpdateDisplay();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (_nNumberRight[mnItem - 1] != 1)
            {
                _nNumberRight[mnItem - 1] -= 1;
            }
            fUpdateDisplay();

        }
    }
}
