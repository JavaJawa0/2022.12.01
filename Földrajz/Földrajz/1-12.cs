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

    public partial class _1_12 : Form
    {

        public _1_12()
        {
            InitializeComponent();
        }

        private void _1_12_Load(object sender, EventArgs e)
        {

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
            Megoldas("SELECT fovaros FROM orszagok WHERE orszag = 'Madagaszkár'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE fovaros = 'OUAGADOUGOU'");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE autojel = 'TT'");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE penzjel = 'SGD'");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT orszag FROM orszagok WHERE telefon = '61'");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT terulet FROM orszagok WHERE orszag = 'Monaco'");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT nepesseg * 1000 AS népesség FROM orszagok WHERE orszag = 'Málta'");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT (nepesseg * 1000 / terulet) AS népsűrűség FROM orszagok WHERE orszag = 'Japán'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(nepesseg * 1000) AS összlakos FROM orszagok");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT SUM(terulet) AS összterület FROM orszagok; ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT AVG(nepesseg * 1000) AS átlaglakos FROM orszagok");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Megoldas("SELECT AVG(terulet) AS átlagterület FROM orszagok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kivalaszto f2 = new Kivalaszto();
            f2.ShowDialog();
        }
    }
}
