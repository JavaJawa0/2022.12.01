using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Földrajz
{
    public partial class _37_48 : Form
    {
        public _37_48()
        {
            InitializeComponent();
        }
        public void Megoldas(string lekerdezes)
        {
            string connStr = "server=localhost;user=root;database=foldrajz";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(lekerdezes, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, terulet FROM orszagok ORDER BY terulet DESC LIMIT 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, terulet FROM orszagok ORDER BY terulet ASC LIMIT 1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, nepesseg * 1000 AS népesség FROM orszagok ORDER BY nepesseg * 1000 DESC LIMIT 1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, nepesseg * 1000 AS népesség FROM orszagok ORDER BY nepesseg * 1000 ASC LIMIT 1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, ((nepesseg * 1000) / terulet) AS népsűrűség FROM orszagok ORDER BY((nepesseg * 1000) / terulet) DESC LIMIT 1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, ((nepesseg * 1000) / terulet) AS népsűrűség FROM orszagok ORDER BY terulet ASC LIMIT 1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, terulet FROM orszagok WHERE foldr_hely LIKE '%afrika%' ORDER BY terulet DESC LIMIT 1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag, nepesseg * 1000 FROM orszagok WHERE foldr_hely LIKE '%amerika%' ORDER BY terulet ASC LIMIT 1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE foldr_hely NOT LIKE '%törpeállam%' AND orszag != fovaros ORDER BY((nepesseg * 1000) / terulet) DESC LIMIT 3");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT fovaros FROM orszagok ORDER BY nep_fovaros DESC LIMIT 6");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok ORDER BY(gdp / nepesseg) DESC LIMIT 10");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok ORDER BY gdp DESC LIMIT 10");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kivalaszto f2 = new Kivalaszto();
            f2.ShowDialog();
        }
    }
}
