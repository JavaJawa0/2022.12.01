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
    public partial class _13_24cs : Form
    {
        public _13_24cs()
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
            Megoldas("SELECT (SUM(nepesseg * 1000) / SUM(terulet)) AS népsűrűség FROM orszagok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE terulet > 1000000");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE terulet < 100");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE nepesseg * 1000 < 20000");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE nepesseg * 1000 < 20000 OR terulet < 100");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE terulet BETWEEN 50000 AND 150000 ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE nepesseg * 1000 BETWEEN 8000000 AND 12000000");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT fovaros FROM `orszagok` WHERE nepesseg * 1000 > 20000000");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE(nepesseg * 1000) / terulet > 500");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmény FROM orszagok WHERE allamforma = 'köztársaság'");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE penznem = 'kelet-karib dollár'");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) FROM orszagok WHERE orszag LIKE '%ország%'");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kivalaszto f2 = new Kivalaszto();
            f2.ShowDialog();
        }
    }
}
