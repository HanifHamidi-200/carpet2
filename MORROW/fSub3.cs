﻿using System;
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
    public partial class fSub3 : Form
    {
        private void fReset()
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;

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
