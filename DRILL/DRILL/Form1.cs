using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRILL
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msAddresses;
        private int mnCol;

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount = 0;
            int nValue = 0;
            String sThree = null;
            char sLetter;

            msShuffle1 = "001002003004005006007008009010011012013014015016017018019020021022023024025026027028029030031032033034035036037038039040041042043044045046047048049050051052053054055056057058059060";
            msShuffle2 = null;
            msAddresses = null;
            mnCol = rnd1.Next(1, 11);

            for (int i = 1; i <= 10; i++)
            {
                nCount = rnd1.Next(2, 7);
                for (int j = 1; j <= 6; j++)
                {
                    if (j <= nCount)
                    {
                        nValue = rnd1.Next(1, 201);
                        sThree = Convert.ToString(nValue);
                        if (sThree.Length == 1)
                        {
                            sThree = "00" + sThree;
                        }
                        else
                        {
                            if (sThree.Length == 2)
                            {
                                sThree = "0" + sThree;
                            }
                        }
                        
                    }
                    else
                    {
                        nValue = 0;
                        sThree = "000";
                    }
                    msShuffle2 = msShuffle2 + sThree;
                }

                
            }

            for(int i = 1; i <= 200; i++)
            {
                nValue = rnd1.Next(1, 27) +64;
                sLetter = (char)nValue;
                msAddresses = msAddresses + sLetter;
            }

            fUpdateDisplay();
            fUpdateStatus();
        }

        private void fUpdateInformation()
        {
            Random rnd1 = new Random();
            String sText=null;
            int nValue;
            int nPos;
            String sLetter = null;

            nValue = rnd1.Next(1, 8);
            switch (nValue)
            {
                case 1:
                    sText = "Sunday";
                    break;
                case 2:
                    sText = "Monday";
                    break;
                case 3:
                    sText = "Tuesday";
                    break;
                case 4:
                    sText = "Wednesday";
                    break;
                case 5:
                    sText = "Thursday";
                    break;
                case 6:
                    sText = "Friday";
                    break;
                default:
                    sText = "Saturday";
                    break;
            }
            txt1.Text = sText;

            nValue = rnd1.Next(1, 6);
            switch (nValue)
            {
                case 1:
                    sText = "rainy";
                    break;
                case 2:
                    sText = "snowy";
                    break;
                case 3:
                    sText = "hot";
                    break;
                case 4:
                    sText = "frost";
                    break;
                default:
                    sText = "gales";
                    break;
            }
            txt2.Text = sText;

            sText = null;
            for (int i = 1; i <= 6; i++)
            {
                nPos = (mnCol - 1) * 6 + i;
                nValue = fHoletype(msShuffle2, nPos);
                if (nValue == 0)
                {

                    
                }
                else
                {
                    sLetter = msAddresses.Substring(nValue - 1, 1);
                    sText = sText + sLetter + "x";

                }
            }
            txt3.Text = sText;
            txt4.Text = null;

        }
        private void fUpdateStatus()
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btna.Text = "10";

            switch (mnCol)
            {
                case 1:
                    btn1.Text = "[1]";
                    break;
                case 2:
                    btn2.Text = "[2]";
                    break;
                case 3:
                    btn3.Text = "[3]";
                    break;
                case 4:
                    btn4.Text = "[4]";
                    break;
                case 5:
                    btn5.Text = "[5]";
                    break;
                case 6:
                    btn6.Text = "[6]";
                    break;
                case 7:
                    btn7.Text = "[7]";
                    break;
                case 8:
                    btn8.Text = "[8]";
                    break;
                case 9:
                    btn9.Text = "[9]";
                    break;
                case 10:
                    btna.Text = "[10]";
                    break;
            }

            lbl11.BackColor = Color.Yellow;
            lbl12.BackColor = Color.Yellow;
            lbl13.BackColor = Color.Yellow;
            lbl14.BackColor = Color.Yellow;
            lbl15.BackColor = Color.Yellow;
            lbl16.BackColor = Color.Yellow;

            lbl21.BackColor = Color.Yellow;
            lbl22.BackColor = Color.Yellow;
            lbl23.BackColor = Color.Yellow;
            lbl24.BackColor = Color.Yellow;
            lbl25.BackColor = Color.Yellow;
            lbl26.BackColor = Color.Yellow;

            lbl31.BackColor = Color.Yellow;
            lbl32.BackColor = Color.Yellow;
            lbl33.BackColor = Color.Yellow;
            lbl34.BackColor = Color.Yellow;
            lbl35.BackColor = Color.Yellow;
            lbl36.BackColor = Color.Yellow;

            lbl41.BackColor = Color.Yellow;
            lbl42.BackColor = Color.Yellow;
            lbl43.BackColor = Color.Yellow;
            lbl44.BackColor = Color.Yellow;
            lbl45.BackColor = Color.Yellow;
            lbl46.BackColor = Color.Yellow;

            lbl51.BackColor = Color.Yellow;
            lbl52.BackColor = Color.Yellow;
            lbl53.BackColor = Color.Yellow;
            lbl54.BackColor = Color.Yellow;
            lbl55.BackColor = Color.Yellow;
            lbl56.BackColor = Color.Yellow;

            lbl61.BackColor = Color.Yellow;
            lbl62.BackColor = Color.Yellow;
            lbl63.BackColor = Color.Yellow;
            lbl64.BackColor = Color.Yellow;
            lbl65.BackColor = Color.Yellow;
            lbl66.BackColor = Color.Yellow;

            lbl71.BackColor = Color.Yellow;
            lbl72.BackColor = Color.Yellow;
            lbl73.BackColor = Color.Yellow;
            lbl74.BackColor = Color.Yellow;
            lbl75.BackColor = Color.Yellow;
            lbl76.BackColor = Color.Yellow;

            lbl81.BackColor = Color.Yellow;
            lbl82.BackColor = Color.Yellow;
            lbl83.BackColor = Color.Yellow;
            lbl84.BackColor = Color.Yellow;
            lbl85.BackColor = Color.Yellow;
            lbl86.BackColor = Color.Yellow;

            lbl91.BackColor = Color.Yellow;
            lbl92.BackColor = Color.Yellow;
            lbl93.BackColor = Color.Yellow;
            lbl94.BackColor = Color.Yellow;
            lbl95.BackColor = Color.Yellow;
            lbl96.BackColor = Color.Yellow;

            lbla1.BackColor = Color.Yellow;
            lbla2.BackColor = Color.Yellow;
            lbla3.BackColor = Color.Yellow;
            lbla4.BackColor = Color.Yellow;
            lbla5.BackColor = Color.Yellow;
            lbla6.BackColor = Color.Yellow;

            switch (mnCol)
            {
                case 1:
                    lbl11.BackColor = Color.LightGreen;
                    lbl12.BackColor = Color.LightGreen;
                    lbl13.BackColor = Color.LightGreen;
                    lbl14.BackColor = Color.LightGreen;
                    lbl15.BackColor = Color.LightGreen;
                    lbl16.BackColor = Color.LightGreen;
                    break;
                case 2:
                    lbl21.BackColor = Color.LightGreen;
                    lbl22.BackColor = Color.LightGreen;
                    lbl23.BackColor = Color.LightGreen;
                    lbl24.BackColor = Color.LightGreen;
                    lbl25.BackColor = Color.LightGreen;
                    lbl26.BackColor = Color.LightGreen;
                    break;
                case 3:
                    lbl31.BackColor = Color.LightGreen;
                    lbl32.BackColor = Color.LightGreen;
                    lbl33.BackColor = Color.LightGreen;
                    lbl34.BackColor = Color.LightGreen;
                    lbl35.BackColor = Color.LightGreen;
                    lbl36.BackColor = Color.LightGreen;
                    break;
                case 4:
                    lbl41.BackColor = Color.LightGreen;
                    lbl42.BackColor = Color.LightGreen;
                    lbl43.BackColor = Color.LightGreen;
                    lbl44.BackColor = Color.LightGreen;
                    lbl45.BackColor = Color.LightGreen;
                    lbl46.BackColor = Color.LightGreen;
                    break;
                case 5:
                    lbl51.BackColor = Color.LightGreen;
                    lbl52.BackColor = Color.LightGreen;
                    lbl53.BackColor = Color.LightGreen;
                    lbl54.BackColor = Color.LightGreen;
                    lbl55.BackColor = Color.LightGreen;
                    lbl56.BackColor = Color.LightGreen;
                    break;
                case 6:
                    lbl61.BackColor = Color.LightGreen;
                    lbl62.BackColor = Color.LightGreen;
                    lbl63.BackColor = Color.LightGreen;
                    lbl64.BackColor = Color.LightGreen;
                    lbl65.BackColor = Color.LightGreen;
                    lbl66.BackColor = Color.LightGreen;
                    break;
                case 7:
                    lbl71.BackColor = Color.LightGreen;
                    lbl72.BackColor = Color.LightGreen;
                    lbl73.BackColor = Color.LightGreen;
                    lbl74.BackColor = Color.LightGreen;
                    lbl75.BackColor = Color.LightGreen;
                    lbl76.BackColor = Color.LightGreen;
                    break;
                case 8:
                    lbl81.BackColor = Color.LightGreen;
                    lbl82.BackColor = Color.LightGreen;
                    lbl83.BackColor = Color.LightGreen;
                    lbl84.BackColor = Color.LightGreen;
                    lbl85.BackColor = Color.LightGreen;
                    lbl86.BackColor = Color.LightGreen;
                    break;
                case 9:
                    lbl91.BackColor = Color.LightGreen;
                    lbl92.BackColor = Color.LightGreen;
                    lbl93.BackColor = Color.LightGreen;
                    lbl94.BackColor = Color.LightGreen;
                    lbl95.BackColor = Color.LightGreen;
                    lbl96.BackColor = Color.LightGreen;
                    break;
                case 10:
                    lbla1.BackColor = Color.LightGreen;
                    lbla2.BackColor = Color.LightGreen;
                    lbla3.BackColor = Color.LightGreen;
                    lbla4.BackColor = Color.LightGreen;
                    lbla5.BackColor = Color.LightGreen;
                    lbla6.BackColor = Color.LightGreen;
                    break;
             }

            fUpdateInformation();
        }
        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;
       
            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 3 - 3, 3));
            return nType;
        }

    
        private void fUpdateDisplay()
        {
            int nAddress;
            String sLetter=null;
            String sText=null;

            //1
            nAddress = fHoletype(msShuffle2, 1);
            lbl11.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 2);
            lbl12.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 3);
            lbl13.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 4);
            lbl14.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 5);
            lbl15.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 6);
            lbl16.Text = Convert.ToString(nAddress);

            //2
            nAddress = fHoletype(msShuffle2, 7);
            lbl21.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 8);
            lbl22.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 9);
            lbl23.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 10);
            lbl24.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 11);
            lbl25.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 12);
            lbl26.Text = Convert.ToString(nAddress);

            //3
            nAddress = fHoletype(msShuffle2, 13);
            lbl31.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 14);
            lbl32.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 15);
            lbl33.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 16);
            lbl34.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 17);
            lbl35.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 18);
            lbl36.Text = Convert.ToString(nAddress);

            //4
            nAddress = fHoletype(msShuffle2, 19);
            lbl41.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 20);
            lbl42.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 21);
            lbl43.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 22);
            lbl44.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 23);
            lbl45.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 24);
            lbl46.Text = Convert.ToString(nAddress);

            //5
            nAddress = fHoletype(msShuffle2, 25);
            lbl51.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 26);
            lbl52.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 27);
            lbl53.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 28);
            lbl54.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 29);
            lbl55.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 30);
            lbl56.Text = Convert.ToString(nAddress);

            //6
            nAddress = fHoletype(msShuffle2, 31);
            lbl61.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 32);
            lbl62.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 33);
            lbl63.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 34);
            lbl64.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 35);
            lbl65.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 36);
            lbl66.Text = Convert.ToString(nAddress);

            //7
            nAddress = fHoletype(msShuffle2, 37);
            lbl71.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 38);
            lbl72.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 39);
            lbl73.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 40);
            lbl74.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 41);
            lbl75.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 42);
            lbl76.Text = Convert.ToString(nAddress);

            //8
            nAddress = fHoletype(msShuffle2, 43);
            lbl81.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 44);
            lbl82.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 45);
            lbl83.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 46);
            lbl84.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 47);
            lbl85.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 48);
            lbl86.Text = Convert.ToString(nAddress);


            //9
            nAddress = fHoletype(msShuffle2, 49);
            lbl91.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 50);
            lbl92.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 51);
            lbl93.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 52);
            lbl94.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 53);
            lbl95.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 54);
            lbl96.Text = Convert.ToString(nAddress);

            //10
            nAddress = fHoletype(msShuffle2, 55);
            lbla1.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 56);
            lbla2.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 57);
            lbla3.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 58);
            lbla4.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 59);
            lbla5.Text = Convert.ToString(nAddress);
            nAddress = fHoletype(msShuffle2, 60);
            lbla6.Text = Convert.ToString(nAddress);

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for (int i = 1; i <= 200; i++)
            {
                sLetter = msAddresses.Substring(i - 1, 1);
                sText = Convert.ToString(i) + ") " + sLetter;
                lst1.Items.Add(sText);
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

        private void btn1_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            fUpdateStatus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            fUpdateStatus();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            fUpdateStatus();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            fUpdateStatus();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            fUpdateStatus();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            fUpdateStatus();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            fUpdateStatus();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            fUpdateStatus();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            mnCol = 9;
            fUpdateStatus();

        }

        private void btna_Click(object sender, EventArgs e)
        {
            mnCol = 10;
            fUpdateStatus();

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (txt4.Text == null)
            {

            }
            else
            {
                fReset();
            }
        }
    }
}
