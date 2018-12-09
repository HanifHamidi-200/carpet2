using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUG
{
    public partial class Form1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private String msRotate;
        private List<int> _numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<String> _slot1 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot2 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot3 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot4 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot5 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot6 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot7 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot8 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slot9 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _slota = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int nNumber;
        private int mnWin;
        private int mnMax;

        private void fResults()
        {
            int nTotal = 0;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            nTotal = _numbers[0];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX1");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  "+_slot1[i - 1]);
                }
            }
            nTotal = _numbers[1];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX2");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot2[i - 1]);
                }
            }
            nTotal = _numbers[2];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX3");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot3[i - 1]);
                }
            }
            nTotal = _numbers[3];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX4");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot4[i - 1]);
                }
            }
            nTotal = _numbers[4];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX5");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot5[i - 1]);
                }
            }
            nTotal = _numbers[5];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX6");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot6[i - 1]);
                }
            }
            nTotal = _numbers[6];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX7");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot7[i - 1]);
                }
            }
            nTotal = _numbers[7];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX8");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot8[i - 1]);
                }
            }
            nTotal = _numbers[8];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX9");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slot9[i - 1]);
                }
            }
            nTotal = _numbers[9];
            if (nTotal != 0)
            {
                lst1.Items.Add("BOX10");
                for (int i = 1; i <= nTotal; i++)
                {
                    lst1.Items.Add("  " + _slota[i - 1]);
                }
            }
        }
        private void fClick(int nMode)
        {
            int nTotal = _numbers[nMode - 1];
            int nPos = 0;

            if (nTotal == mnMax)
            {
                mnWin += 1;
                MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                fReset();
                goto endline;
            }

            nPos = nTotal + 1;
            _numbers[nMode - 1] = nPos;

            switch (nMode)
            {
                case 1:
                    _slot1[nPos - 1] = txtJob.Text;
                    break;
                case 2:
                    _slot2[nPos - 1] = txtJob.Text;
                    break;
                case 3:
                    _slot3[nPos - 1] = txtJob.Text;
                    break;
                case 4:
                    _slot4[nPos - 1] = txtJob.Text;
                    break;
                case 5:
                    _slot5[nPos - 1] = txtJob.Text;
                    break;
                case 6:
                    _slot6[nPos - 1] = txtJob.Text;
                    break;
                case 7:
                    _slot7[nPos - 1] = txtJob.Text;
                    break;
                case 8:
                    _slot8[nPos - 1] = txtJob.Text;
                    break;
                case 9:
                    _slot9[nPos - 1] = txtJob.Text;
                    break;
                case 10:
                    _slota[nPos - 1] = txtJob.Text;
                    break;
            }


            fUpdateDisplay();
            fJob();

        endline:;
        }
        private void fJob()
        {
            Random rnd1 = new Random();
            String sText = null;
            char sLetter;

            nNumber = rnd1.Next(1, 201);
            sLetter =(char)(rnd1.Next(1, 27) + 64);
            sText = Convert.ToString(sLetter);
            sLetter = (char)(rnd1.Next(1, 27) + 64 + 32);
            sText = sText+Convert.ToString(sLetter);
            sText = sText + "-" + Convert.ToString(nNumber);

            txtJob.Text = sText;
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;

            msShuffle = "1111111111";
            msShuffle2 = null;
            msRotate = null;
            mnWin = 0;
            mnMax = rnd1.Next(4, 21);

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for (int i = 1; i <= 10; i++)
            {
                nValue = rnd1.Next(1, 5);
                msShuffle2 = msShuffle2 + Convert.ToString(nValue);
                if (nValue == 4)
                {
                    nValue = rnd1.Next(1, 5);
                }
                else
                {
                    nValue = 1;
                }
                msRotate = msRotate + Convert.ToString(nValue);
            }
            for (int i = 1; i <= 10; i++)
            {
                _numbers[i - 1] = 0;
            }

            fUpdateDisplay();
            fJob();
        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F letter_1P.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F letter_2U.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F letter_3G.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F walled.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
       
            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                default:
                    _pic2 = picture5;
                    break;
            }
        }
        
         private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 1,ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic1.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic2.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic3.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic4.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 5, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic5.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic6.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic7.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic8.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 9, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic9.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pica.Image = _pic.Image;

            lbl1.Text = Convert.ToString(_numbers[0]);
            lbl2.Text = Convert.ToString(_numbers[1]);
            lbl3.Text = Convert.ToString(_numbers[2]);
            lbl4.Text = Convert.ToString(_numbers[3]);
            lbl5.Text = Convert.ToString(_numbers[4]);
            lbl6.Text = Convert.ToString(_numbers[5]);
            lbl7.Text = Convert.ToString(_numbers[6]);
            lbl8.Text = Convert.ToString(_numbers[7]);
            lbl9.Text = Convert.ToString(_numbers[8]);
            lbla.Text = Convert.ToString(_numbers[9]);

        }
        private int fHoletype(String sShuffle, int nSquare,ref int nRotate)
        {
            int nType = 0;
         
            nType = Convert.ToInt32(sShuffle.Substring(nSquare -1, 1));
            nRotate = Convert.ToInt32(msRotate.Substring(nSquare -1, 1));

            return nType;
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

        private void btnSkipJob_Click(object sender, EventArgs e)
        {
            fJob();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            fClick(8);
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            fClick(9);
        }

        private void pica_Click(object sender, EventArgs e)
        {
            fClick(10);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            fResults();
        }
    }
}
