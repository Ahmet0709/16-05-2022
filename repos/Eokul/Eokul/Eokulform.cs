using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Eokul
{
    public partial class Eokulform : Form
    {
        public Eokulform()
        {
            InitializeComponent();
        }
            sqlbaglanti db = new sqlbaglanti();

            DataTable dt = new DataTable();
            MySqlCommand kmt = new MySqlCommand();
        private void dersyukle()
        {
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.Font = new Font("Verdana", 12);
            dt.Columns.Clear();
            dt.Clear(); 
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from dersler", db.baglan());
            adtr.Fill(dt);
            dataGridView4.DataSource = dt; 
            dataGridView4.Columns["derskodu"].HeaderText = "Ders Kodu"; 
             dataGridView4.Columns["dersadi"].HeaderText = "Ders Adı";
        }

        private void tabctrleokul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrleokul.SelectedIndex==0)
            {

            }
            else if (tabctrleokul.SelectedIndex==1)
            {

            }
            else if (tabctrleokul.SelectedIndex==2)
            {

            }
            else
            {
                dersyukle();
            }
        }
    }
}
