using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFAKE
{
    public partial class Form1 : Form
    {
        private List<String> _text1 = new List<string> { "lines going down", "lines going across", "lines going up" };
        private List<String> _text2 = new List<string> { "in the corner", "in the margin", "underneath the closet" };
        private List<String> _text3 = new List<string> { "aligned", "at opposite poles" };
        private List<String> _text4 = new List<string> { "symbol enhanced" };
        private List<String> _text5 = new List<string> { "3d representation of data" };
        private List<int> _sum = new List<int> { 3,3, 2, 1, 1 };
        private int mnCount;
        private List<String> _item = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<bool> _but = new List<bool> { false, false, false, false, false, false, false, false, false, false };
        private List<bool> _check = new List<bool> { false, false, false, false, false, false, false, false, false, false };
        private int nNumber;
        private int mnFake=0, mnReal=0;

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(4, 11);
            int nPos,nSum,nVersion;
            String sText;
            int nVersion2;
            int nCount2;
            char sLetter1,sLetter2;

            mnCount = nCount;
            btnFake.Text = "FAKE" + Convert.ToString(mnFake);
            btnReal.Text = "REAL" + Convert.ToString(mnReal);

            for (int i = 1; i <= nCount; i++)
            {
                nPos = rnd1.Next(1, 6);
                nSum = _sum[nPos - 1];
                nVersion = rnd1.Next(1, nSum + 1);
                switch (nPos)
                {
                    case 1:
                        sText = _text1[nVersion - 1];
                        nCount2 = rnd1.Next(1, 4);
                        sText = Convert.ToString(nCount2) + " " + sText;
                        break;
                    case 2:
                        sText = _text2[nVersion - 1];
                        nVersion2 = rnd1.Next(1, 4);
                        switch (nVersion2)
                        {
                            case 1:
                                sText = "brooch " + sText;
                                break;
                            case 2:
                                sText = "sword " + sText;
                                break;
                           default:
                                sText = "cigarette " + sText;
                                break;
                        }
                        break;
                    case 3:
                        sText = _text3[nVersion - 1];
                        nCount2 = rnd1.Next(1, 4);
                        nVersion2 = rnd1.Next(1, 4);
                        switch (nVersion2)
                        {
                            case 1:
                                sText = Convert.ToString(nCount2) + " swans " + sText;
                                break;
                            case 2:
                                sText = Convert.ToString(nCount2) + " geese " + sText;
                                break;
                            default:
                                sText = Convert.ToString(nCount2) + " tiger " + sText;
                                break;
                        }
                         break;
                    case 4:
                        sText = _text4[nVersion - 1];
                        sLetter1 = (char)(rnd1.Next(1, 27) + 64);
                        sLetter2 = (char)(rnd1.Next(1, 27) + 64);
                        sText = Convert.ToString(sLetter1) + Convert.ToString(sLetter2) + " " + sText;
                             break;
                    default:
                        sText = _text5[nVersion - 1];
                             break;

                }
                _item[i-1] = sText;
              }

            fBut();
            fCheck();
            fUpdateDisplay();
        }

        private void fBut()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= mnCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _but[i - 1] = true;

                }
                else
                {
                    _but[i - 1] = false;
                }
            }
        }
        private void fCheck()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= mnCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _check[i - 1] = true;

                }
                else
                {
                    _check[i - 1] = false;
                }
            }
        }
        private void fUpdateDisplay()
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);

            }

            for (int i = 1; i <= mnCount; i++)
            {
                sText = _item[i - 1];
                if (_but[i - 1])
                {
                    sText = "[BUT]" + sText;
                }
                if (_check[i - 1])
                {
                    sText = "[CHECK]" + sText;
                }
                lst1.Items.Add(sText);
            }
            lst1.Sorted = true;
            lst1.Sorted = false;
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

        private void btnBut_Click(object sender, EventArgs e)
        {
            fBut();
            fUpdateDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mnFake += 1;
            fReset();
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            mnReal += 1;
            fReset();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            fCheck();
            fUpdateDisplay();
        }
    }
}
