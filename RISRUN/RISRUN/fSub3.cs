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
    public partial class fSub3 : Form
    {
        private List<bool> _info = new List<bool> { false, false, false, false };
        private int nNumber;
        private int mnScore;

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

        private void fPrint(bool b1,int nMode)
        {
            String sText=null;

            if (b1)
            {
                sText = "TRUE";
            }
            else
            {
                sText = "#false";
            }

            switch (nMode)
            {
                case 1:
                    txt1.Text = sText;
                    break;
                case 2:
                    txt2.Text = sText;
                    break;
                case 3:
                    txt3.Text = sText;
                    break;
                default:
                    txt4.Text = sText;
                    break;
            }
        }
        private void fReset()
        {
            _info[0] = fToss();
            _info[1] = fToss();
            _info[2] = fToss();
            _info[3] = fToss();
            mnScore = 0;
            txtScore.Text = "0";

            fPrint(_info[0], 1);
            fPrint(_info[1], 2);
            fPrint(_info[2], 3);
            fPrint(_info[3], 4);
        }
        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
