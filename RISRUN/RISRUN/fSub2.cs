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
    public partial class fSub2 : Form
    {
        private List<String> _col1 = new List<string> { null, null, null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null, null };
        private List<bool> _transformA1 = new List<bool> { false, false };
        private List<bool> _transformB1 = new List<bool> { false, false };
        private List<bool> _transformC1 = new List<bool> { false, false };
        private List<bool> _transformD1 = new List<bool> { false, false };
        private List<bool> _transformE1 = new List<bool> { false, false };
        private List<bool> _transformF1 = new List<bool> { false, false };
        private List<double> _weightA1 = new List<double> { 0, 0 };
        private List<double> _weightB1 = new List<double> { 0, 0 };
        private List<double> _weightC1 = new List<double> { 0, 0 };
        private List<double> _weightD1 = new List<double> { 0, 0 };
        private List<double> _weightE1 = new List<double> { 0, 0 };
        private List<double> _weightF1 = new List<double> { 0, 0 };
        private List<bool> _transformA2 = new List<bool> { false, false };
        private List<bool> _transformB2 = new List<bool> { false, false };
        private List<double> _weightA2 = new List<double> { 0, 0 };
        private List<double> _weightB2 = new List<double> { 0, 0 };
        private List<bool> _transformA3 = new List<bool> { false, false, false, false };
        private List<bool> _transformB3 = new List<bool> { false, false, false, false };
        private List<double> _weightA3 = new List<double> { 0, 0,0,0 };
        private List<double> _weightB3 = new List<double> { 0, 0,0,0 };
        private double nNumber;

        private bool fToss()
        {
            Random rnd1 = new Random();

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
               return true;
            }
            else
            {
                return false;
            }

        }
        private void fStage1()
        {
            Random rnd1 = new Random();

            _transformA1[0] = fToss();
            _transformA1[1] = fToss();
            _transformB1[0] = fToss();
            _transformB1[1] = fToss();
            _transformC1[0] = fToss();
            _transformC1[1] = fToss();
            _transformD1[0] = fToss();
            _transformD1[1] = fToss();
            _transformE1[0] = fToss();
            _transformE1[1] = fToss();
            _transformF1[0] = fToss();
            _transformF1[1] = fToss();

            _transformA2[0] = fToss();
            _transformA2[1] = fToss();
            _transformB2[0] = fToss();
            _transformB2[1] = fToss();
        
            _transformA3[0] = fToss();
            _transformA3[1] = fToss();
            _transformA3[2] = fToss();
            _transformA3[2] = fToss();
            _transformB3[0] = fToss();
            _transformB3[1] = fToss();
            _transformB3[2] = fToss();
            _transformB3[3] = fToss();

            fStage2();
        }

        private void fPrint(String sTitle,  double nWeight1,  double nWeight2)
        {
            String sText = sTitle + " = [" + Convert.ToString(nWeight1) + "," + Convert.ToString(nWeight2) + "]";

            lst1.Items.Add(sText);
        }
        private void fPrint2(String sTitle, double nWeight1, double nWeight2, double nWeight3, double nWeight4)
        {
            String sText = sTitle + " = [" + Convert.ToString(nWeight1) + "," + Convert.ToString(nWeight2) + ","+Convert.ToString(nWeight3) + "," + Convert.ToString(nWeight4) + "]";

            lst1.Items.Add(sText);
        }

        private String fChoice(bool b1,bool b2,ref double nWeight1,ref double nWeight2)
        {
            String sText = null;

            if (b1)
            {
                sText = sText + "1";
            }
            else
            {
                sText = sText + "0";
            }
            if (b2)
            {
                sText = sText + "1";
            }
            else
            {
                sText = sText + "0";
            }
            if (sText == "11")
            {
                nWeight1 = 0.5;
                nWeight2 = 0.5;
            }
            else
            {
                if (sText == "10")
                {
                    nWeight1 = 1;
                    nWeight2 = 0;
                }
                else
                {
                    if (sText == "01")
                    {
                        nWeight1 = 0;
                        nWeight2 = 1;
                    }
                    else
                    {
                        nWeight1 = 0;
                        nWeight2 = 0;

                    }

                }
            }

            return sText;
        }
        private String fChoice2(bool b1, bool b2, bool b3, bool b4, ref double nWeight1, ref double nWeight2, ref double nWeight3, ref double nWeight4)
        {
            String sText = null;
            int nCount = 0;
            double nPercent=0;
            int nValue;

            nCount = 0;
            if (b1)
            {
                sText = sText + "1";
                nCount += 1;
            }
            else
            {
                sText = sText + "0";
            }
            if (b2)
            {
                sText = sText + "1";
                nCount += 1;
            }
            else
            {
                sText = sText + "0";
            }
            if (b3)
            {
                sText = sText + "1";
                nCount += 1;
            }
            else
            {
                sText = sText + "0";
            }
            if (b4)
            {
                sText = sText + "1";
                nCount += 1;
            }
            else
            {
                sText = sText + "0";
            }

            switch (nCount)
            {
                case 0:
                    nPercent = 0;
                    break;
                case 1:
                    nPercent = 1;
                    break;
                case 2:
                    nPercent = 0.5;
                    break;
                case 3:
                    nPercent = 0.333;
                    break;
                default:
                    nPercent = 0.25;
                    break;
            }

            nValue = Convert.ToInt32(sText.Substring(0));
            if (nValue == 1)
            {
                nWeight1 = nPercent;
            }
            else
            {
                nWeight1 = 0;
            }
            nValue = Convert.ToInt32(sText.Substring(1));
            if (nValue == 1)
            {
                nWeight2 = nPercent;
            }
            else
            {
                nWeight2 = 0;
            }
            nValue = Convert.ToInt32(sText.Substring(2));
            if (nValue == 1)
            {
                nWeight3 = nPercent;
            }
            else
            {
                nWeight3 = 0;
            }
            nValue = Convert.ToInt32(sText.Substring(3));
            if (nValue == 1)
            {
                nWeight4 = nPercent;
            }
            else
            {
                nWeight4 = 0;
            }
            
            return sText;
        }
        private void fStage2()
        {
            String sText = null;
            double nWeight1=0, nWeight2=0, nWeight3 = 0, nWeight4 = 0;

            sText = fChoice(_transformA1[0], _transformA1[1],ref nWeight1,ref nWeight2);
            _weightA1[0]=nWeight1;
            _weightA1[1]=nWeight2;
            sText = fChoice(_transformB1[0], _transformB1[1], ref nWeight1, ref nWeight2);
            _weightB1[0] = nWeight1;
            _weightB1[1] = nWeight2;
            sText = fChoice(_transformC1[0], _transformC1[1], ref nWeight1, ref nWeight2);
            _weightC1[0] = nWeight1;
            _weightC1[1] = nWeight2;
            sText = fChoice(_transformD1[0], _transformD1[1], ref nWeight1, ref nWeight2);
            _weightD1[0] = nWeight1;
            _weightD1[1] = nWeight2;
            sText = fChoice(_transformE1[0], _transformE1[1], ref nWeight1, ref nWeight2);
            _weightE1[0] = nWeight1;
            _weightE1[1] = nWeight2;
            sText = fChoice(_transformF1[0], _transformF1[1], ref nWeight1, ref nWeight2);
            _weightF1[0] = nWeight1;
            _weightF1[1] = nWeight2;

            sText = fChoice(_transformA2[0], _transformA2[1], ref nWeight1, ref nWeight2);
            _weightA2[0] = nWeight1;
            _weightA2[1] = nWeight2;
            sText = fChoice(_transformB2[0], _transformB2[1], ref nWeight1, ref nWeight2);
            _weightB2[0] = nWeight1;
            _weightB2[1] = nWeight2;

            sText = fChoice2(_transformA3[0], _transformA3[1], _transformA3[2], _transformA3[3], ref nWeight1, ref nWeight2, ref nWeight3, ref nWeight4);
            _weightA3[0] = nWeight1;
            _weightA3[1] = nWeight2;
            _weightA3[2] = nWeight3;
            _weightA3[3] = nWeight4;
            sText = fChoice2(_transformB3[0], _transformB3[1], _transformB3[2], _transformB3[3], ref nWeight1, ref nWeight2, ref nWeight3, ref nWeight4);
            _weightB3[0] = nWeight1;
            _weightB3[1] = nWeight2;
            _weightB3[2] = nWeight3;
            _weightB3[3] = nWeight4;

            fStage3();
        }

        private void fStage3()
        {
            String sTitle = null;
          
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            sTitle = _col1[0] + "1"+ _col1[0] + "2";
            fPrint(sTitle, _weightA1[0], _weightA1[1]);
            sTitle = _col1[1] + "1" + _col1[1] + "2";
            fPrint(sTitle, _weightB1[0], _weightB1[1]);
            sTitle = _col1[2] + "1" + _col1[2] + "2";
            fPrint(sTitle, _weightC1[0], _weightC1[1]);
            sTitle = _col1[3] + "1" + _col1[3] + "2";
            fPrint(sTitle, _weightD1[0], _weightD1[1]);
            sTitle = _col1[4] + "1" + _col1[4] + "2";
            fPrint(sTitle, _weightE1[0], _weightE1[1]);
            sTitle = _col1[5] + "1" + _col1[5] + "2";
            fPrint(sTitle, _weightF1[0], _weightF1[1]);

            sTitle = "1314";
            fPrint(sTitle, _weightA2[0], _weightA2[1]);
            sTitle = "2324";
            fPrint(sTitle, _weightB2[0], _weightB2[1]);

            sTitle = "3" + _col4[0] + "3" + _col4[1] + "3" + _col4[2] + "3" + _col4[3];
            fPrint2(sTitle, _weightA3[0], _weightA3[1], _weightA3[2], _weightA3[3]);
            sTitle = "4" + _col4[0] + "4" + _col4[1] + "4" + _col4[2] + "4" + _col4[3];
            fPrint2(sTitle, _weightB3[0], _weightB3[1], _weightB3[2], _weightB3[3]);
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            double nValue = 0;
            char sLetter;

            for(double i = 1; i <= 6; i++)
            {
                nValue = rnd1.Next(1, 27) + 64;
                sLetter = (char)nValue;
                switch (i)
                {
                    case 1:
                        _col1[0] = Convert.ToString(sLetter);
                        break;
                    case 2:
                        _col1[1] = Convert.ToString(sLetter);
                        break;
                    case 3:
                        _col1[2] = Convert.ToString(sLetter);
                        break;
                    case 4:
                        _col1[3] = Convert.ToString(sLetter);
                        break;
                    case 5:
                        _col1[4] = Convert.ToString(sLetter);
                        break;
                    default:
                        _col1[5] = Convert.ToString(sLetter);
                        break;
                }
            }
            for (double i = 1; i <= 4; i++)
            {
                nValue = rnd1.Next(1, 27) + 64;
                sLetter = (char)nValue;
                switch (i)
                {
                    case 1:
                        _col4[0] = Convert.ToString(sLetter);
                        break;
                    case 2:
                        _col4[1] = Convert.ToString(sLetter);
                        break;
                    case 3:
                        _col4[2] = Convert.ToString(sLetter);
                        break;
                    default:
                        _col4[3] = Convert.ToString(sLetter);
                        break;
                }
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl11.Text = _col1[0];
            lbl12.Text = _col1[1];
            lbl13.Text = _col1[2];
            lbl14.Text = _col1[3];
            lbl15.Text = _col1[4];
            lbl16.Text = _col1[5];
            lbl41.Text = _col4[0];
            lbl42.Text = _col4[1];
            lbl43.Text = _col4[2];
            lbl44.Text = _col4[3];

            fStage1();
        }
        public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnStage1_Click(object sender, EventArgs e)
        {
            fStage1();
        }

        private void btnStage2_Click(object sender, EventArgs e)
        {
            fStage2();
        }

        private void btnStage3_Click(object sender, EventArgs e)
        {
            fStage3();
        }
    }
}
