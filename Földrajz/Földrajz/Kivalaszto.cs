using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Földrajz
{
    public partial class Kivalaszto : Form
    {
        public Kivalaszto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _1_12 f3 = new _1_12();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _13_24cs f4 = new _13_24cs();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _25_36 f5 = new _25_36();
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _37_48 f6 = new _37_48();
            f6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            _49_60 f7 = new _49_60();
            f7.ShowDialog();
        }
    }
}
