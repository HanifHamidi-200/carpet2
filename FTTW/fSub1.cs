using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTTW
{
    public partial class fSub1 : Form
    {
        private String fName()
        {
            Random rnd1 = new Random();
            String sLetter;
            String sName = null;

            for (int i = 1; i <= 5; i++)
            {
                sLetter = Convert.ToString((char)(rnd1.Next(1, 27) + 64));
                sName = sName + sLetter;
            }

            return sName;
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sText;

            sText = fName();
            txt1.Text = sText;

            sText = Convert.ToString(rnd1.Next(10000, 100000));
            textBox2.Text = sText;

        }
        public fSub1()
        {
            InitializeComponent();
        }
        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
