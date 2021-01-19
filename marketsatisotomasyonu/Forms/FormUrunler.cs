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
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();           
        }

        private void FormUrunler_Load(object sender, EventArgs e)
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
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Ürün id";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Name = "Barkod No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Ürün Adı";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Name = "Alış Fiyatı";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Name = "Satış Fiyatı";
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Name = "Kategori";
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Name = "Marka";
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Name = "KDV";
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].Name = "Stok Miktarı";
            dataGridView1.Columns[8].Width = 100;
            fillcombokategori();
            fillcombomarka();           
        }

        void fillcombokategori()
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            string query = "select * from Kategori";
            OracleConnection conn = new OracleConnection(connstring);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                kategoriCombo.Items.Add(reader.GetString(reader.GetOrdinal("kategoriAdi")));
            }
            conn.Close();
            kategoriCombo.SelectedIndex = 0;
        }
        void fillcombomarka()
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            string query = "select * from Marka";
            OracleConnection conn = new OracleConnection(connstring);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                markaCombo.Items.Add(reader.GetString(reader.GetOrdinal("markaAdi")));
            }
            conn.Close();
            markaCombo.SelectedIndex = 0;
        }
        
        int urunid = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("degerimiz bu aga : " + e.RowIndex);
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex != (dataGridView1.RowCount - 1))
                {
                    urunid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    barkodText.Text = row.Cells[1].Value.ToString();
                    urunAdiText.Text = row.Cells[2].Value.ToString();
                    alisFiyatiText.Text = row.Cells[3].Value.ToString();
                    satisFiyatiText.Text = row.Cells[4].Value.ToString();
                    kategoriCombo.SelectedIndex = Convert.ToInt32(row.Cells[5].Value.ToString()) - 1;
                    markaCombo.SelectedIndex = Convert.ToInt32(row.Cells[6].Value.ToString()) - 1;
                    kdvText.Text = row.Cells[7].Value.ToString();
                    stokMiktariText.Text = row.Cells[8].Value.ToString();
                }
            }
            catch (Exception)
            {
            }            
        }       
        void listele()
        {           
            dataGridView1.Rows.Clear();
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from urunler";

            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("urunid")),
                    reader.GetInt32(reader.GetOrdinal("urunbarkodno")),
                    reader.GetString(reader.GetOrdinal("urunadi")),
                    reader.GetDecimal(reader.GetOrdinal("urunalisfiyati")),
                    reader.GetDecimal(reader.GetOrdinal("urunsatisfiyati")),
                    reader.GetInt32(reader.GetOrdinal("kategoriid")),
                    reader.GetInt32(reader.GetOrdinal("markaid")),
                    reader.GetDecimal(reader.GetOrdinal("urunkdv")),
                    reader.GetInt32(reader.GetOrdinal("urunstokmiktari"))
                    );
            }

            cmd.ExecuteNonQuery();
            conn.Close();
            barkodText.Text = "";
            urunAdiText.Text = "";
            alisFiyatiText.Text = "";
            satisFiyatiText.Text = "";
            kategoriCombo.SelectedIndex = 0;
            markaCombo.SelectedIndex = 0;
            kdvText.Text = "";
            stokMiktariText.Text = "";
        }
        private void listeleButton_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Urunler(URUNID,URUNBARKODNO,URUNADI,URUNALISFIYATI,URUNSATISFIYATI,KATEGORIID,MARKAID,URUNKDV,URUNSTOKMIKTARI) VALUES (urunartis.nextval,:pURUNBARKODNO,:pURUNADI,:pURUNALISFIYATI,:pURUNSATISFIYATI,:pKATEGORIID,:pMARKAID,:pURUNKDV,:pURUNSTOKMIKTARI)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pURUNBARKODNO", OracleDbType.Int32, Convert.ToInt32(barkodText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNADI", OracleDbType.Varchar2, urunAdiText.Text, ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNALISFIYATI", OracleDbType.Decimal, Convert.ToDecimal(alisFiyatiText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNSATISFIYATI", OracleDbType.Decimal, Convert.ToDecimal(satisFiyatiText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pKATEGORIID", OracleDbType.Int32, Convert.ToInt32(kategoriCombo.SelectedIndex + 1), ParameterDirection.Input);
            cmd.Parameters.Add(":pMARKAID", OracleDbType.Int32, Convert.ToInt32(markaCombo.SelectedIndex + 1), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNKDV", OracleDbType.Decimal, Convert.ToDecimal(kdvText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNSTOKMIKTARI", OracleDbType.Int32, Convert.ToInt32(stokMiktariText.Text), ParameterDirection.Input);


            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Urunler WHERE URUNID = :PURUNID";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pURUNID", OracleDbType.Int32, urunid, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Urunler SET URUNBARKODNO = :pURUNBARKODNO,URUNADI = :pURUNADI,URUNALISFIYATI = :pURUNALISFIYATI,URUNSATISFIYATI = :pURUNSATISFIYATI,KATEGORIID = :pKATEGORIID,MARKAID = :pMARKAID,URUNKDV = :pURUNKDV,URUNSTOKMIKTARI = :pURUNSTOKMIKTARI where URUNID = :pURUNID";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pURUNBARKODNO", OracleDbType.Int32, Convert.ToInt32(barkodText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNADI", OracleDbType.Varchar2, urunAdiText.Text, ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNALISFIYATI", OracleDbType.Decimal, Convert.ToDecimal(alisFiyatiText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNSATISFIYATI", OracleDbType.Decimal, Convert.ToDecimal(satisFiyatiText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pKATEGORIID", OracleDbType.Int32, Convert.ToInt32(kategoriCombo.SelectedIndex + 1), ParameterDirection.Input);
            cmd.Parameters.Add(":pMARKAID", OracleDbType.Int32, Convert.ToInt32(markaCombo.SelectedIndex + 1), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNKDV", OracleDbType.Decimal, Convert.ToDecimal(kdvText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNSTOKMIKTARI", OracleDbType.Int32, Convert.ToInt32(stokMiktariText.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":pURUNID", OracleDbType.Int32, urunid, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            UrunEkle frm = new UrunEkle();
            frm.ShowDialog();
        }

        private void gecmisButton_Click(object sender, EventArgs e)
        {
            FormGecmis frm = new FormGecmis();
            frm.ShowDialog();
        }

        private void zamButton_Click(object sender, EventArgs e)
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "urun_zam";

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
        }
    }
}
