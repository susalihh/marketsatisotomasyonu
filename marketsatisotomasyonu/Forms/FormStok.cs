using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace marketsatisotomasyonu.Forms
{
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }
        int sayac = 3;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex != (dataGridView1.RowCount - 1))
                {
                    
                }
            }
            catch (Exception)
            {
            }
        }
        void listele(int a)
        {
            dataGridView1.Rows.Clear();
            int limit = a;
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select urunid,urunbarkodno,urunadi,urunstokmiktari from Urunler where urunstokmiktari between :pa and :pb";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pa", OracleDbType.Int32, -100, ParameterDirection.Input);
            cmd.Parameters.Add(":pb", OracleDbType.Int32, limit, ParameterDirection.Input);

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();

            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(reader.GetOrdinal("urunid")),
                        reader.GetInt32(reader.GetOrdinal("urunbarkodno")),
                        reader.GetString(reader.GetOrdinal("urunadi")),
                        reader.GetInt32(reader.GetOrdinal("urunstokmiktari"))
                        );
                }
                
            }
            else
            {
                MessageBox.Show("Stok durumu kritik ürün bulunamadı");
            }
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(34, 33, 74);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Ürün id";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Barkod No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Ürün Adı";
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Name = "Stok Miktarı";
            dataGridView1.Columns[3].Width = 100;
            textBox1.Text = sayac.ToString();
            listele(3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void azaltButton_Click(object sender, EventArgs e)
        {
            
            if (sayac>1)
            {
                sayac--;
                textBox1.Text = sayac.ToString();
                listele(sayac);
            }
        }

        private void arttirButton_Click(object sender, EventArgs e)
        {
            sayac++;
            textBox1.Text = sayac.ToString();
            listele(sayac);
            
        }
    }
}
