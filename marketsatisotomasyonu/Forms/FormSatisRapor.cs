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
    public partial class FormSatisRapor : Form
    {
        public FormSatisRapor()
        {
            InitializeComponent();
        }

        private void FormSatisRapor_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddHours(23.9999);
            /////////////////////////////////////////////////////
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
            dataGridView1.Columns[0].Name = "Fatura id";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Satış Türü";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Belge Tarihi";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Name = "Toplam Tutar";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Kasa";
            dataGridView1.Columns[4].Width = 100;
            listele(dateTimePicker1.Value,dateTimePicker2.Value);
        }
       
        void listele(DateTime a,DateTime b) 
        {
            dataGridView1.Rows.Clear();
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from faturalar where belgetarihi between :pa and :pb";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pa", OracleDbType.Date, a, ParameterDirection.Input);
            cmd.Parameters.Add(":pb", OracleDbType.Date, b, ParameterDirection.Input);

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(reader.GetOrdinal("faturaid")),
                        reader.GetString(reader.GetOrdinal("satisturu")),
                        reader.GetDateTime(reader.GetOrdinal("belgetarihi")),
                        reader.GetDecimal(reader.GetOrdinal("toplamtutar")),
                        reader.GetString(reader.GetOrdinal("kasa")));
                }                
            }           
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        int faturaid = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex != (dataGridView1.RowCount - 1))
                {
                    faturaid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception)
            {
            }
        }

        private void bugunButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddHours(23.9999);
            listele(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dunButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-1);
            dateTimePicker2.Value = DateTime.Today.AddDays(-1).AddHours(23.9999);
            listele(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void haftaButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-7);
            dateTimePicker2.Value = DateTime.Today.AddDays(-1).AddHours(23.9999);
            listele(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void seciliButton_Click(object sender, EventArgs e)
        {
            listele(dateTimePicker1.Value, dateTimePicker2.Value.AddHours(-0.0001));
        }

        private void detayButton_Click(object sender, EventArgs e)
        {
            FormFaturaDetay frm = new FormFaturaDetay(faturaid, Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value), dataGridView1.CurrentRow.Cells[4].Value.ToString());
            frm.ShowDialog();
        }
       
        private void raporButton_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[dataGridView1.RowCount - 1];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }
            FormRapor frm = new FormRapor(dizi,Convert.ToDateTime( dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value));
            frm.ShowDialog();
        }
    }
}
