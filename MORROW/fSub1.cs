using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MORROW
{
    public partial class fSub1 : Form
    {
        private void fReset()
        {
            txt11.Text = null;
            txt12.Text = null;
            txt13.Text = null;
            txt14.Text = null;

            txt21.Text = null;
            txt22.Text = null;
            txt23.Text = null;
            txt24.Text = null;

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
