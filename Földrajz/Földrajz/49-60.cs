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
    public partial class _49_60 : Form
    {
        public _49_60()
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
            Megoldas("SELECT orszag FROM orszagok ORDER BY(gdp / nepesseg) ASC LIMIT 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok ORDER BY terulet ASC LIMIT 1 OFFSET 39");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok ORDER BY(nepesseg * 1000) / terulet ASC LIMIT 1 OFFSET 14");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok ORDER BY(nepesseg * 1000) / terulet DESC LIMIT 1 OFFSET 60");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE orszag != 'Magyarország' GROUP BY orszag ORDER BY ABS((terulet - (SELECT terulet FROM orszagok WHERE orszag = 'Magyarország'))) ASC LIMIT 3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(nepesseg) / (SELECT SUM(nepesseg) FROM orszagok) AS eredmény FROM orszagok WHERE foldr_hely LIKE '%ázsia%'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(terulet) / (SELECT SUM(terulet) FROM orszagok) AS eredmény FROM orszagok WHERE orszag = 'oroszország'");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(nepesseg) / (SELECT SUM(nepesseg) FROM orszagok) AS eredmény FROM orszagok WHERE penzjel = 'EUR'");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT (SUM(gdp) / (SELECT SUM(gdp) FROM orszagok)) * 100 AS eredmény FROM orszagok WHERE orszag = 'Amerikai Egyesült Államok'");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT (SUM(gdp) / (SELECT SUM(gdp) FROM orszagok)) * 100 AS eredmény FROM orszagok WHERE penzjel LIKE 'EUR'");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE gdp > (SELECT AVG(gdp) FROM orszagok) AND foldr_hely NOT LIKE '%Európa%' AND foldr_hely NOT LIKE '%Amerika%'");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT DISTINCT allamforma FROM orszagok WHERE foldr_hely LIKE '%európa%'");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kivalaszto f2 = new Kivalaszto();
            f2.ShowDialog();
        }
    }
}
