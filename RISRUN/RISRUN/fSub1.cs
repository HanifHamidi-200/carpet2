using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISRUN
{
    public partial class fSub1 : Form
    {
        private int mnLeft, mnRight;
        private List<String> _uml1 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _uml2 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _uml3 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _uml4 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private int mnUML;

        private void fSave()
        {
            switch (mnUML)
            {
                case 1:
                    _uml1[0] = btn1.Text;
                    _uml1[1] = btn2.Text;
                    _uml1[2] = btn3.Text;
                    _uml1[3] = btn4.Text;
                    _uml1[4] = btn5.Text;
                    _uml1[5] = btn6.Text;
                    _uml1[6] = btn7.Text;
                    _uml1[7] = btn8.Text;
                    _uml1[8] = btn9.Text;
                    _uml1[9] = btn10.Text;
                    break;
                case 2:
                    _uml2[0] = btn1.Text;
                    _uml2[1] = btn2.Text;
                    _uml2[2] = btn3.Text;
                    _uml2[3] = btn4.Text;
                    _uml2[4] = btn5.Text;
                    _uml2[5] = btn6.Text;
                    _uml2[6] = btn7.Text;
                    _uml2[7] = btn8.Text;
                    _uml2[8] = btn9.Text;
                    _uml2[9] = btn10.Text;
                    break;
                case 3:
                    _uml3[0] = btn1.Text;
                    _uml3[1] = btn2.Text;
                    _uml3[2] = btn3.Text;
                    _uml3[3] = btn4.Text;
                    _uml3[4] = btn5.Text;
                    _uml3[5] = btn6.Text;
                    _uml3[6] = btn7.Text;
                    _uml3[7] = btn8.Text;
                    _uml3[8] = btn9.Text;
                    _uml3[9] = btn10.Text;
                    break;
                default:
                    _uml4[0] = btn1.Text;
                    _uml4[1] = btn2.Text;
                    _uml4[2] = btn3.Text;
                    _uml4[3] = btn4.Text;
                    _uml4[4] = btn5.Text;
                    _uml4[5] = btn6.Text;
                    _uml4[6] = btn7.Text;
                    _uml4[7] = btn8.Text;
                    _uml4[8] = btn9.Text;
                    _uml4[9] = btn10.Text;
                    break;
            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nPlus;
            String sText;

            mnLeft = rnd1.Next(1, 101);
            mnRight = rnd1.Next(1, 101);
            txtLeft.Text = Convert.ToString(mnLeft);
            txtRight.Text = Convert.ToString(mnRight);
            mnUML = rnd1.Next(1, 5);
            txtChange.Text = null;

            nPlus = rnd1.Next(1, 10);
            for(int i = 1; i <= 10; i++)
            {
                if (i <= nPlus)
                {
                    sText = "+";
                }
                else
                {
                    sText = "-";
                }
                _uml1[i - 1] = sText;
            }

            nPlus = rnd1.Next(1, 10);
            for (int i = 1; i <= 10; i++)
            {
                if (i <= nPlus)
                {
                    sText = "+";
                }
                else
                {
                    sText = "-";
                }
                _uml2[i - 1] = sText;
            }

            nPlus = rnd1.Next(1, 10);
            for (int i = 1; i <= 10; i++)
            {
                if (i <= nPlus)
                {
                    sText = "+";
                }
                else
                {
                    sText = "-";
                }
                _uml3[i - 1] = sText;
            }

            nPlus = rnd1.Next(1, 10);
            for (int i = 1; i <= 10; i++)
            {
                if (i <= nPlus)
                {
                    sText = "+";
                }
                else
                {
                    sText = "-";
                }
                _uml4[i - 1] = sText;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            switch (mnUML)
            {
                case 1:
                    btn1.Text = _uml1[0];
                    btn2.Text = _uml1[1];
                    btn3.Text = _uml1[2];
                    btn4.Text = _uml1[3];
                    btn5.Text = _uml1[4];
                    btn6.Text = _uml1[5];
                    btn7.Text = _uml1[6];
                    btn8.Text = _uml1[7];
                    btn9.Text = _uml1[8];
                    btn10.Text = _uml1[9];
                    break;
                case 2:
                    btn1.Text = _uml2[0];
                    btn2.Text = _uml2[1];
                    btn3.Text = _uml2[2];
                    btn4.Text = _uml2[3];
                    btn5.Text = _uml2[4];
                    btn6.Text = _uml2[5];
                    btn7.Text = _uml2[6];
                    btn8.Text = _uml2[7];
                    btn9.Text = _uml2[8];
                    btn10.Text = _uml2[9];
                    break;
                case 3:
                    btn1.Text = _uml3[0];
                    btn2.Text = _uml3[1];
                    btn3.Text = _uml3[2];
                    btn4.Text = _uml3[3];
                    btn5.Text = _uml3[4];
                    btn6.Text = _uml3[5];
                    btn7.Text = _uml3[6];
                    btn8.Text = _uml3[7];
                    btn9.Text = _uml3[8];
                    btn10.Text = _uml3[9];
                    break;
                default:
                    btn1.Text = _uml4[0];
                    btn2.Text = _uml4[1];
                    btn3.Text = _uml4[2];
                    btn4.Text = _uml4[3];
                    btn5.Text = _uml4[4];
                    btn6.Text = _uml4[5];
                    btn7.Text = _uml4[6];
                    btn8.Text = _uml4[7];
                    btn9.Text = _uml4[8];
                    btn10.Text = _uml4[9];
                    break;
            }

        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            mnUML = 1;
            fUpdateDisplay();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            mnUML = 2;
            fUpdateDisplay();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            mnUML = 3;
            fUpdateDisplay();

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            mnUML = 4;
            fUpdateDisplay();

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = txtChange.Text;
            txtChange.Text = null;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            btn10.Text = txtChange.Text;
            txtChange.Text = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
