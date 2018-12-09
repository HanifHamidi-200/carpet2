using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADVAN
{
    public partial class Form1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private int mnItem;

        private void fClick(int nCol,int nRow)
        {
            fPlace(mnItem, nCol, nRow);
            fColour(nCol, nRow);
            fUpdateDisplay();
        }

        private void fClear()
        {
            lbl11.BackColor = Color.Yellow;
            lbl12.BackColor = Color.Yellow;
            lbl13.BackColor = Color.Yellow;
            lbl14.BackColor = Color.Yellow;
            lbl15.BackColor = Color.Yellow;
            lbl16.BackColor = Color.Yellow;
            lbl17.BackColor = Color.Yellow;
            lbl18.BackColor = Color.Yellow;
            lbl19.BackColor = Color.Yellow;
            lbl1a.BackColor = Color.Yellow;

            lbl21.BackColor = Color.Yellow;
            lbl22.BackColor = Color.Yellow;
            lbl23.BackColor = Color.Yellow;
            lbl24.BackColor = Color.Yellow;
            lbl25.BackColor = Color.Yellow;
            lbl26.BackColor = Color.Yellow;
            lbl27.BackColor = Color.Yellow;
            lbl28.BackColor = Color.Yellow;
            lbl29.BackColor = Color.Yellow;
            lbl2a.BackColor = Color.Yellow;

            lbl31.BackColor = Color.Yellow;
            lbl32.BackColor = Color.Yellow;
            lbl33.BackColor = Color.Yellow;
            lbl34.BackColor = Color.Yellow;
            lbl35.BackColor = Color.Yellow;
            lbl36.BackColor = Color.Yellow;
            lbl37.BackColor = Color.Yellow;
            lbl38.BackColor = Color.Yellow;
            lbl39.BackColor = Color.Yellow;
            lbl3a.BackColor = Color.Yellow;

            lbl41.BackColor = Color.Yellow;
            lbl42.BackColor = Color.Yellow;
            lbl43.BackColor = Color.Yellow;
            lbl44.BackColor = Color.Yellow;
            lbl45.BackColor = Color.Yellow;
            lbl46.BackColor = Color.Yellow;
            lbl47.BackColor = Color.Yellow;
            lbl48.BackColor = Color.Yellow;
            lbl49.BackColor = Color.Yellow;
            lbl4a.BackColor = Color.Yellow;

            lbl51.BackColor = Color.Yellow;
            lbl52.BackColor = Color.Yellow;
            lbl53.BackColor = Color.Yellow;
            lbl54.BackColor = Color.Yellow;
            lbl55.BackColor = Color.Yellow;
            lbl56.BackColor = Color.Yellow;
            lbl57.BackColor = Color.Yellow;
            lbl58.BackColor = Color.Yellow;
            lbl59.BackColor = Color.Yellow;
            lbl5a.BackColor = Color.Yellow;

            lbl61.BackColor = Color.Yellow;
            lbl62.BackColor = Color.Yellow;
            lbl63.BackColor = Color.Yellow;
            lbl64.BackColor = Color.Yellow;
            lbl65.BackColor = Color.Yellow;
            lbl66.BackColor = Color.Yellow;
            lbl67.BackColor = Color.Yellow;
            lbl68.BackColor = Color.Yellow;
            lbl69.BackColor = Color.Yellow;
            lbl6a.BackColor = Color.Yellow;


        }

        private void fColour(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    switch (nRow)
                    {
                        case 1:
                            lbl11.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            lbl12.BackColor = Color.LightGreen;
                            break;
                        case 3:
                            lbl13.BackColor = Color.LightGreen;
                            break;
                        case 4:
                            lbl14.BackColor = Color.LightGreen;
                            break;
                        case 5:
                            lbl15.BackColor = Color.LightGreen;
                            break;
                        case 6:
                            lbl16.BackColor = Color.LightGreen;
                            break;
                        case 7:
                            lbl17.BackColor = Color.LightGreen;
                            break;
                        case 8:
                            lbl18.BackColor = Color.LightGreen;
                            break;
                        case 9:
                            lbl19.BackColor = Color.LightGreen;
                            break;
                        default:
                            lbl1a.BackColor = Color.LightGreen;
                            break;
                    }
                    break;
                case 2:
                    switch (nRow)
                    {
                        case 1:
                            lbl21.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            lbl22.BackColor = Color.LightGreen;
                            break;
                        case 3:
                            lbl23.BackColor = Color.LightGreen;
                            break;
                        case 4:
                            lbl24.BackColor = Color.LightGreen;
                            break;
                        case 5:
                            lbl25.BackColor = Color.LightGreen;
                            break;
                        case 6:
                            lbl26.BackColor = Color.LightGreen;
                            break;
                        case 7:
                            lbl27.BackColor = Color.LightGreen;
                            break;
                        case 8:
                            lbl28.BackColor = Color.LightGreen;
                            break;
                        case 9:
                            lbl29.BackColor = Color.LightGreen;
                            break;
                        default:
                            lbl2a.BackColor = Color.LightGreen;
                            break;
                    }
                    break;
                case 3:
                    switch (nRow)
                    {
                        case 1:
                            lbl31.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            lbl32.BackColor = Color.LightGreen;
                            break;
                        case 3:
                            lbl33.BackColor = Color.LightGreen;
                            break;
                        case 4:
                            lbl34.BackColor = Color.LightGreen;
                            break;
                        case 5:
                            lbl35.BackColor = Color.LightGreen;
                            break;
                        case 6:
                            lbl36.BackColor = Color.LightGreen;
                            break;
                        case 7:
                            lbl37.BackColor = Color.LightGreen;
                            break;
                        case 8:
                            lbl38.BackColor = Color.LightGreen;
                            break;
                        case 9:
                            lbl39.BackColor = Color.LightGreen;
                            break;
                        default:
                            lbl3a.BackColor = Color.LightGreen;
                            break;
                    }
                    break;
                case 4:
                    switch (nRow)
                    {
                        case 1:
                            lbl41.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            lbl42.BackColor = Color.LightGreen;
                            break;
                        case 3:
                            lbl43.BackColor = Color.LightGreen;
                            break;
                        case 4:
                            lbl44.BackColor = Color.LightGreen;
                            break;
                        case 5:
                            lbl45.BackColor = Color.LightGreen;
                            break;
                        case 6:
                            lbl46.BackColor = Color.LightGreen;
                            break;
                        case 7:
                            lbl47.BackColor = Color.LightGreen;
                            break;
                        case 8:
                            lbl48.BackColor = Color.LightGreen;
                            break;
                        case 9:
                            lbl49.BackColor = Color.LightGreen;
                            break;
                        default:
                            lbl4a.BackColor = Color.LightGreen;
                            break;
                    }
                    break;
                case 5:
                    switch (nRow)
                    {
                        case 1:
                            lbl51.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            lbl52.BackColor = Color.LightGreen;
                            break;
                        case 3:
                            lbl53.BackColor = Color.LightGreen;
                            break;
                        case 4:
                            lbl54.BackColor = Color.LightGreen;
                            break;
                        case 5:
                            lbl55.BackColor = Color.LightGreen;
                            break;
                        case 6:
                            lbl56.BackColor = Color.LightGreen;
                            break;
                        case 7:
                            lbl57.BackColor = Color.LightGreen;
                            break;
                        case 8:
                            lbl58.BackColor = Color.LightGreen;
                            break;
                        case 9:
                            lbl59.BackColor = Color.LightGreen;
                            break;
                        default:
                            lbl5a.BackColor = Color.LightGreen;
                            break;
                    }
                    break;
                default:
                    switch (nRow)
                    {
                        case 1:
                            lbl61.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            lbl62.BackColor = Color.LightGreen;
                            break;
                        case 3:
                            lbl63.BackColor = Color.LightGreen;
                            break;
                        case 4:
                            lbl64.BackColor = Color.LightGreen;
                            break;
                        case 5:
                            lbl65.BackColor = Color.LightGreen;
                            break;
                        case 6:
                            lbl66.BackColor = Color.LightGreen;
                            break;
                        case 7:
                            lbl67.BackColor = Color.LightGreen;
                            break;
                        case 8:
                            lbl68.BackColor = Color.LightGreen;
                            break;
                        case 9:
                            lbl69.BackColor = Color.LightGreen;
                            break;
                        default:
                            lbl6a.BackColor = Color.LightGreen;
                            break;
                    }
                    break;
            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = null;
            int nStars = rnd1.Next(4, 15);
            int nCol = 0, nRow = 0;

            msShuffle = "010203040506070809101112131415161718192021222324252627282930313233343536373839404142434445464748495051525354555657585960";
            msShuffle2 = null;
            mnItem = 2;
            fClear();

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    sTwo = "01";
                    msShuffle2 = msShuffle2 + sTwo;
                }
            }

            for (int i = 1; i <= nStars; i++)
            {
                fFree(ref nCol, ref nRow);
                fPlace(9, nCol, nRow);
                fColour(nCol, nRow);
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            int nType = 0;
            String sText = null;

            //1
            nType = fHoletype(msShuffle2, 1);
            sText = fText(nType);
            lbl11.Text = sText;
            nType = fHoletype(msShuffle2, 2);
            sText = fText(nType);
            lbl12.Text = sText;
            nType = fHoletype(msShuffle2, 3);
            sText = fText(nType);
            lbl13.Text = sText;
            nType = fHoletype(msShuffle2, 4);
            sText = fText(nType);
            lbl14.Text = sText;
            nType = fHoletype(msShuffle2, 5);
            sText = fText(nType);
            lbl15.Text = sText;
            nType = fHoletype(msShuffle2, 6);
            sText = fText(nType);
            lbl16.Text = sText;
            nType = fHoletype(msShuffle2, 7);
            sText = fText(nType);
            lbl17.Text = sText;
            nType = fHoletype(msShuffle2, 8);
            sText = fText(nType);
            lbl18.Text = sText;
            nType = fHoletype(msShuffle2, 9);
            sText = fText(nType);
            lbl19.Text = sText;
            nType = fHoletype(msShuffle2, 10);
            sText = fText(nType);
            lbl1a.Text = sText;

            //2
            nType = fHoletype(msShuffle2, 11);
            sText = fText(nType);
            lbl21.Text = sText;
            nType = fHoletype(msShuffle2, 12);
            sText = fText(nType);
            lbl22.Text = sText;
            nType = fHoletype(msShuffle2, 13);
            sText = fText(nType);
            lbl23.Text = sText;
            nType = fHoletype(msShuffle2, 14);
            sText = fText(nType);
            lbl24.Text = sText;
            nType = fHoletype(msShuffle2, 15);
            sText = fText(nType);
            lbl25.Text = sText;
            nType = fHoletype(msShuffle2, 16);
            sText = fText(nType);
            lbl26.Text = sText;
            nType = fHoletype(msShuffle2, 17);
            sText = fText(nType);
            lbl27.Text = sText;
            nType = fHoletype(msShuffle2, 18);
            sText = fText(nType);
            lbl28.Text = sText;
            nType = fHoletype(msShuffle2, 19);
            sText = fText(nType);
            lbl29.Text = sText;
            nType = fHoletype(msShuffle2, 20);
            sText = fText(nType);
            lbl2a.Text = sText;

            //3
            nType = fHoletype(msShuffle2, 21);
            sText = fText(nType);
            lbl31.Text = sText;
            nType = fHoletype(msShuffle2, 22);
            sText = fText(nType);
            lbl32.Text = sText;
            nType = fHoletype(msShuffle2, 23);
            sText = fText(nType);
            lbl33.Text = sText;
            nType = fHoletype(msShuffle2, 24);
            sText = fText(nType);
            lbl34.Text = sText;
            nType = fHoletype(msShuffle2, 25);
            sText = fText(nType);
            lbl35.Text = sText;
            nType = fHoletype(msShuffle2, 26);
            sText = fText(nType);
            lbl36.Text = sText;
            nType = fHoletype(msShuffle2, 27);
            sText = fText(nType);
            lbl37.Text = sText;
            nType = fHoletype(msShuffle2, 28);
            sText = fText(nType);
            lbl38.Text = sText;
            nType = fHoletype(msShuffle2, 29);
            sText = fText(nType);
            lbl39.Text = sText;
            nType = fHoletype(msShuffle2, 30);
            sText = fText(nType);
            lbl3a.Text = sText;

            //4
            nType = fHoletype(msShuffle2, 31);
            sText = fText(nType);
            lbl41.Text = sText;
            nType = fHoletype(msShuffle2, 32);
            sText = fText(nType);
            lbl42.Text = sText;
            nType = fHoletype(msShuffle2, 33);
            sText = fText(nType);
            lbl43.Text = sText;
            nType = fHoletype(msShuffle2, 34);
            sText = fText(nType);
            lbl44.Text = sText;
            nType = fHoletype(msShuffle2, 35);
            sText = fText(nType);
            lbl45.Text = sText;
            nType = fHoletype(msShuffle2, 36);
            sText = fText(nType);
            lbl46.Text = sText;
            nType = fHoletype(msShuffle2, 37);
            sText = fText(nType);
            lbl47.Text = sText;
            nType = fHoletype(msShuffle2, 38);
            sText = fText(nType);
            lbl48.Text = sText;
            nType = fHoletype(msShuffle2, 39);
            sText = fText(nType);
            lbl49.Text = sText;
            nType = fHoletype(msShuffle2, 40);
            sText = fText(nType);
            lbl4a.Text = sText;

            //5
            nType = fHoletype(msShuffle2, 41);
            sText = fText(nType);
            lbl51.Text = sText;
            nType = fHoletype(msShuffle2, 42);
            sText = fText(nType);
            lbl52.Text = sText;
            nType = fHoletype(msShuffle2, 43);
            sText = fText(nType);
            lbl53.Text = sText;
            nType = fHoletype(msShuffle2, 44);
            sText = fText(nType);
            lbl54.Text = sText;
            nType = fHoletype(msShuffle2, 45);
            sText = fText(nType);
            lbl55.Text = sText;
            nType = fHoletype(msShuffle2, 46);
            sText = fText(nType);
            lbl56.Text = sText;
            nType = fHoletype(msShuffle2, 47);
            sText = fText(nType);
            lbl57.Text = sText;
            nType = fHoletype(msShuffle2, 48);
            sText = fText(nType);
            lbl58.Text = sText;
            nType = fHoletype(msShuffle2, 49);
            sText = fText(nType);
            lbl59.Text = sText;
            nType = fHoletype(msShuffle2, 50);
            sText = fText(nType);
            lbl5a.Text = sText;

            //6
            nType = fHoletype(msShuffle2, 51);
            sText = fText(nType);
            lbl61.Text = sText;
            nType = fHoletype(msShuffle2, 52);
            sText = fText(nType);
            lbl62.Text = sText;
            nType = fHoletype(msShuffle2, 53);
            sText = fText(nType);
            lbl63.Text = sText;
            nType = fHoletype(msShuffle2, 54);
            sText = fText(nType);
            lbl64.Text = sText;
            nType = fHoletype(msShuffle2, 55);
            sText = fText(nType);
            lbl65.Text = sText;
            nType = fHoletype(msShuffle2, 56);
            sText = fText(nType);
            lbl66.Text = sText;
            nType = fHoletype(msShuffle2, 57);
            sText = fText(nType);
            lbl67.Text = sText;
            nType = fHoletype(msShuffle2, 58);
            sText = fText(nType);
            lbl68.Text = sText;
            nType = fHoletype(msShuffle2, 59);
            sText = fText(nType);
            lbl69.Text = sText;
            nType = fHoletype(msShuffle2, 60);
            sText = fText(nType);
            lbl6a.Text = sText;

        }

        private String fText(int nType)
        {
            switch (nType)
            {
                case 1:
                    return "-";
                case 2:
                    return "J";
                case 3:
                    return "T";
                case 4:
                    return "P";
                case 5:
                    return "X";
                case 6:
                    return "A";
                case 7:
                    return "L";
                case 8:
                    return "O";
                default:
                    return "[*]";
            }
        }
        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 -2, 2));
            return nType;
        }

        private void fPlace(int nType, int nCol, int nRow)
        {
            String sTwo;
            int nPos = (nCol - 1) * 10 + nRow;

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sTwo + msShuffle2.Substring(nPos * 2, (60 - nPos) * 2);
        }

        private void fFree(ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nPos;
            int nType;

            do
            {
                nCol = rnd1.Next(1, 7);
                nRow = rnd1.Next(1, 11);
                nPos = (nCol - 1) * 10 + nRow;
                nType = fHoletype(msShuffle2,nPos);
                if (nType == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);
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

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnItem = 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            mnItem = 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            mnItem = 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            mnItem = 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            mnItem = 8;
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            fClick(1, 1);
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            fClick(1, 2);
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            fClick(1, 3);
        }

        private void lbl14_Click(object sender, EventArgs e)
        {
            fClick(1, 4);
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
            fClick(1, 5);
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
            fClick(1, 6);
        }

        private void lbl17_Click(object sender, EventArgs e)
        {
            fClick(1, 7);
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            fClick(1, 8);
        }

        private void lbl19_Click(object sender, EventArgs e)
        {
            fClick(1, 9);
        }

        private void lbl1a_Click(object sender, EventArgs e)
        {
            fClick(1, 10);
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            fClick(2, 1);
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            fClick(2, 2);
        }

        private void lbl23_Click(object sender, EventArgs e)
        {
            fClick(2, 3);
        }

        private void lbl24_Click(object sender, EventArgs e)
        {
            fClick(2, 4);
        }

        private void lbl25_Click(object sender, EventArgs e)
        {
            fClick(2, 5);
        }

        private void lbl26_Click(object sender, EventArgs e)
        {
            fClick(2, 6);
        }

        private void lbl27_Click(object sender, EventArgs e)
        {
            fClick(2, 7);
        }

        private void lbl28_Click(object sender, EventArgs e)
        {
            fClick(2, 8);
        }

        private void lbl29_Click(object sender, EventArgs e)
        {
            fClick(2, 9);
        }

        private void lbl2a_Click(object sender, EventArgs e)
        {
            fClick(2, 10);
        }

        private void lbl31_Click(object sender, EventArgs e)
        {
            fClick(3, 1);
        }

        private void lbl32_Click(object sender, EventArgs e)
        {
            fClick(3, 2);
        }

        private void lbl33_Click(object sender, EventArgs e)
        {
            fClick(3, 3);
        }

        private void lbl34_Click(object sender, EventArgs e)
        {
            fClick(3, 4);
        }

        private void lbl35_Click(object sender, EventArgs e)
        {
            fClick(3, 5);
        }

        private void lbl36_Click(object sender, EventArgs e)
        {
            fClick(3, 6);
        }

        private void lbl37_Click(object sender, EventArgs e)
        {
            fClick(3, 7);
        }

        private void lbl38_Click(object sender, EventArgs e)
        {
            fClick(3, 8);
        }

        private void lbl39_Click(object sender, EventArgs e)
        {
            fClick(3, 9);
        }

        private void lbl3a_Click(object sender, EventArgs e)
        {
            fClick(3, 10);
        }

        private void lbl41_Click(object sender, EventArgs e)
        {
            fClick(4, 1);
        }

        private void lbl42_Click(object sender, EventArgs e)
        {
            fClick(4, 2);
        }

        private void lbl43_Click(object sender, EventArgs e)
        {
            fClick(4, 3);
        }

        private void lbl44_Click(object sender, EventArgs e)
        {
            fClick(4, 4);
        }

        private void lbl45_Click(object sender, EventArgs e)
        {
            fClick(4, 5);
        }

        private void lbl46_Click(object sender, EventArgs e)
        {
            fClick(4, 6);
        }

        private void lbl47_Click(object sender, EventArgs e)
        {
            fClick(4, 7);
        }

        private void lbl48_Click(object sender, EventArgs e)
        {
            fClick(4, 8);
        }

        private void lbl49_Click(object sender, EventArgs e)
        {
            fClick(4, 9);
        }

        private void lbl4a_Click(object sender, EventArgs e)
        {
            fClick(4, 10);
        }

        private void lbl51_Click(object sender, EventArgs e)
        {
            fClick(5, 1);
        }

        private void lbl52_Click(object sender, EventArgs e)
        {
            fClick(5, 2);
        }

        private void lbl53_Click(object sender, EventArgs e)
        {
            fClick(5, 3);
        }

        private void lbl54_Click(object sender, EventArgs e)
        {
            fClick(5, 4);
        }

        private void lbl55_Click(object sender, EventArgs e)
        {
            fClick(5, 5);
        }

        private void lbl56_Click(object sender, EventArgs e)
        {
            fClick(5, 6);
        }

        private void lbl57_Click(object sender, EventArgs e)
        {
            fClick(5, 7);
        }

        private void lbl58_Click(object sender, EventArgs e)
        {
            fClick(5, 8);
        }

        private void lbl59_Click(object sender, EventArgs e)
        {
            fClick(5, 9);
        }

        private void lbl5a_Click(object sender, EventArgs e)
        {
            fClick(5, 10);
        }

        private void lbl61_Click(object sender, EventArgs e)
        {
            fClick(6, 1);
        }

        private void lbl62_Click(object sender, EventArgs e)
        {
            fClick(6, 2);
        }

        private void lbl63_Click(object sender, EventArgs e)
        {
            fClick(6, 3);
        }

        private void lbl64_Click(object sender, EventArgs e)
        {
            fClick(6, 4);
        }

        private void lbl65_Click(object sender, EventArgs e)
        {
            fClick(6, 5);
        }

        private void lbl66_Click(object sender, EventArgs e)
        {
            fClick(6, 6);
        }

        private void lbl67_Click(object sender, EventArgs e)
        {
            fClick(6, 7);
        }

        private void lbl68_Click(object sender, EventArgs e)
        {
            fClick(6, 8);
        }

        private void lbl69_Click(object sender, EventArgs e)
        {
            fClick(6, 9);
        }

        private void lbl6a_Click(object sender, EventArgs e)
        {
            fClick(6, 10);
        }
    }
}
