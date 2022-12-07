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
    public partial class _25_36 : Form
    {
        public _25_36()
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
            Megoldas("SELECT orszag FROM orszagok WHERE penznem LIKE '%korona%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(terulet) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%európa%'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(nepesseg * 1000) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%európa%'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT (SUM(nepesseg * 1000) / SUM(terulet)) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%európa%'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%afrika%'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(nepesseg * 1000) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%afrika%'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT (SUM(nepesseg * 1000) / SUM(terulet)) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%afrika%'");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE foldr_hely LIKE '%szigetország%'; ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE allamforma LIKE '%hercegség%' OR allamforma LIKE '%királyság%'");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(orszag) FROM orszagok WHERE autojel = ''");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT valtopenz FROM orszagok WHERE valtopenz NOT LIKE '100 %''");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT COUNT(id) FROM orszagokWHERE terulet < (SELECT terulet FROM orszagok WHERE orszag LIKE 'Magyarország')");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kivalaszto f2 = new Kivalaszto();
            f2.ShowDialog();
        }
    }
}
