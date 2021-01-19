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
    public partial class FormGecmis : Form
    {
        public FormGecmis()
        {
            InitializeComponent();
        }

        private void FormGecmis_Load(object sender, EventArgs e)
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
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Durum";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Barkod No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Ürün Adı";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Name = "Alış Fiyatı";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Satış Fiyatı";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Name = "Kategori id";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Name = "Marka id";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Name = "KDV";
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Name = "Stok Miktarı";
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Name = "Tarih";
            dataGridView1.Columns[9].Width = 200;

            listele();
 
        }
        void listele()
        {
            dataGridView1.Rows.Clear();
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from logs";

            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("logtype")),
                    reader.GetInt32(reader.GetOrdinal("urunbarkodno")),
                    reader.GetString(reader.GetOrdinal("urunadi")),
                    reader.GetDecimal(reader.GetOrdinal("urunalisfiyati")),
                    reader.GetDecimal(reader.GetOrdinal("urunsatisfiyati")),
                    reader.GetInt32(reader.GetOrdinal("kategoriid")),
                    reader.GetInt32(reader.GetOrdinal("markaid")),
                    reader.GetDecimal(reader.GetOrdinal("urunkdv")),
                    reader.GetInt32(reader.GetOrdinal("urunstokmiktari")),
                    reader.GetDateTime(reader.GetOrdinal("logtime"))
                    );
            }

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
