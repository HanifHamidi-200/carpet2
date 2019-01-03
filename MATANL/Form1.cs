using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATANL
{
    public partial class Form1 : Form
    {
        private List<String> _data = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<int> _mode = new List<int> { 0, 0, 0, 0 };
        private List<String> _text = new List<string> { "Wood", "Paper", "Plastic", "Metal" };

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 4; i++)
            {
                _mode[i - 1] = rnd1.Next(1, 5);
                _data[i - 1] = _text[_mode[i - 1] - 1];
            }
            for (int i = 5; i <= 9; i++)
            {
                _data[i - 1] = null;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            txt1.Text = _data[0];
            txt2.Text = _data[1];
            txt3.Text = _data[2];
            textBox4.Text = _data[3];
            textBox5.Text = _data[4];
            textBox6.Text = _data[5];
            textBox7.Text = _data[6];
            textBox8.Text = _data[7];
            textBox9.Text = _data[8];

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

            private void button1_Click_1(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
