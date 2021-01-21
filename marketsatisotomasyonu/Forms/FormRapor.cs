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
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }
        decimal kar = 0;
        DateTime b, c;
        public FormRapor(int[] a, DateTime b1, DateTime c1)
        {
            InitializeComponent();
            b = b1;
            c = c1;
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
            dataGridView1.Columns[0].Name = "Ürün Adı";
            dataGridView1.Columns[0].Width = 400;
            dataGridView1.Columns[1].Name = "Adet";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Alış";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Name = "Satış";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Kar";
            dataGridView1.Columns[4].Width = 100;
            for (int i = 0; i < a.Length; i++)
            {
                listele(a[i]);
            }
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                kar = kar + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            karLabel.Text = "Toplam Kar: " + kar.ToString();
        }
        private void FormRapor_Load(object sender, EventArgs e)
        {
            
        }
        void listele(int a)
        {            
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select urunadi,urunalisfiyati, urunkdv, b.adet, b.uruntutar from urunler a INNER JOIN(select faturaid, urunbarkod, adet, uruntutar from satistablosu ) b ON a.urunbarkodno = b.urunbarkod and b.faturaid = :pa";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pa", OracleDbType.Int32, a, ParameterDirection.Input);

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("urunadi")),
                        reader.GetInt32(reader.GetOrdinal("adet")),
                        reader.GetDecimal(reader.GetOrdinal("urunalisfiyati")),
                        reader.GetDecimal(reader.GetOrdinal("uruntutar")) / reader.GetInt32(reader.GetOrdinal("adet")),
                       reader.GetInt32(reader.GetOrdinal("adet"))*((reader.GetDecimal(reader.GetOrdinal("uruntutar")) / reader.GetInt32(reader.GetOrdinal("adet"))) - reader.GetDecimal(reader.GetOrdinal("urunalisfiyati"))));
                }
            }

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void yazdirButton_Click(object sender, EventArgs e)
        {
            ppDialog.ShowDialog();
        }
        Font baslik = new Font("Thoma", 14, FontStyle.Bold);
        Font baslik2 = new Font("Thoma", 12, FontStyle.Bold);
        Font icerik = new Font("Thoma", 10);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void pdPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Satış Raporu", baslik, sb, 100, 90);
            e.Graphics.DrawString(karLabel.Text, baslik, sb, 500, 90);
            e.Graphics.DrawString(b.ToString(), baslik, sb, 100, 120);
            e.Graphics.DrawString("-", baslik, sb, 400, 120);
            e.Graphics.DrawString(c.ToString(), baslik, sb, 500, 120);
            e.Graphics.DrawString("___________________________________________________________________________________________", baslik, sb, 0, 140);

            e.Graphics.DrawString("Ürün Adı", baslik2, sb, 50, 180);
            e.Graphics.DrawString("Adet", baslik2, sb, 320, 180);
            e.Graphics.DrawString("Alış Fiyatı", baslik2, sb, 400, 180);
            e.Graphics.DrawString("Satış Fiyatı", baslik2, sb, 530, 180);
            e.Graphics.DrawString("Kar", baslik2, sb, 660, 180);

            int satir = 200;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), icerik, sb, 50, satir);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), icerik, sb, 320, satir);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), icerik, sb, 400, satir);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), icerik, sb, 530, satir);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), icerik, sb, 660, satir);
                satir = satir + 20;
            }
        }
    }
}
