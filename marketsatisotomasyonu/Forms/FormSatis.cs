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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }
        string kasa = "";
        public FormSatis(string a)
        {
            InitializeComponent();
            kasa = a;
        }
        decimal toplamtutar = 0;
        
        private void FormSatis_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[0].Name = "Barkod";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Name = "Adet";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Name = "Tutar";
            dataGridView1.Columns[3].Width = 100; 
            dataGridView1.Columns[4].Name = "Toplam Tutar";
            dataGridView1.Columns[4].Width = 100;
        }
        
        private void satisEkraniButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Faturalar(faturaid,satisturu,belgetarihi,toplamtutar,kasa) VALUES (faturaartis.nextval,:psatisturu,sysdate,:ptoplamtutar,:pkasa)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(":psatisturu", OracleDbType.Varchar2, "Nakit", ParameterDirection.Input);
                cmd.Parameters.Add(":ptoplamtutar", OracleDbType.Decimal, Convert.ToDecimal(label5.Text), ParameterDirection.Input);
                cmd.Parameters.Add(":pkasa", OracleDbType.Varchar2, kasa, ParameterDirection.Input);
                cmd.ExecuteNonQuery();
                conn.Close();

                for (int i = 0; i <= dataGridView1.RowCount - 2; i++)
                {
                    satiskaydet(i);
                    uruneksilt(i);
                }
                dataGridView1.Rows.Clear();
                label5.Text = "0,00";
                label4.Text = "0";
            }
            else
            {
                MessageBox.Show("Satış yapabilmek için en az bir ürün girişi yapılmalıdır!", "Hata");
            }
            barkodText.Focus();
            barkodText.Text = "";
        }
        int faturaidgetir()
        {
            int faturaid = 0;
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            string query = "select MAX(faturaid) from Faturalar";
            OracleConnection conn = new OracleConnection(connstring);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                faturaid = reader.GetInt32(reader.GetOrdinal("max(Faturaid)"));
            }
            conn.Close();
            return faturaid;
        }
        void satiskaydet(int j)
        {
            int i = j;
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Satistablosu(satisid,faturaid,urunbarkod,adet,uruntutar) VALUES (satisartis.nextval,:pfaturaid,:purunbarkod,:padet,:puruntutar)";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":pfaturaid", OracleDbType.Int32, faturaidgetir(), ParameterDirection.Input);
            cmd.Parameters.Add(":purunbarkod", OracleDbType.Int32, Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), ParameterDirection.Input);
            cmd.Parameters.Add(":padet", OracleDbType.Int32, Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), ParameterDirection.Input);
            cmd.Parameters.Add(":puruntutar", OracleDbType.Decimal, Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value), ParameterDirection.Input);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        void uruneksilt(int j)
        {
            int i = j;
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE urunler SET urunstokmiktari = urunstokmiktari - :pu where urunbarkodno = :pb";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":pu", OracleDbType.Int32, Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), ParameterDirection.Input);
            cmd.Parameters.Add(":pb", OracleDbType.Int32, Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), ParameterDirection.Input);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void barkodText_Click(object sender, EventArgs e)
        {
            barkodText.Text = "";
        }
        decimal degeradet = 0;
        int degerid = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex != (dataGridView1.RowCount - 1))
                {
                    degerid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    degeradet = Convert.ToInt32(row.Cells[2].Value.ToString());
                }
            }
            catch (Exception)
            {

            }

        }        

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
               string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Faturalar(faturaid,satisturu,belgetarihi,toplamtutar,kasa) VALUES (faturaartis.nextval,:psatisturu,sysdate,:ptoplamtutar,:pkasa)";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(":psatisturu", OracleDbType.Varchar2, "Pos", ParameterDirection.Input);
                cmd.Parameters.Add(":ptoplamtutar", OracleDbType.Decimal, Convert.ToDecimal(label5.Text), ParameterDirection.Input);
                cmd.Parameters.Add(":pkasa", OracleDbType.Varchar2, kasa, ParameterDirection.Input);
                cmd.ExecuteNonQuery();
                conn.Close();

                for (int i = 0; i <= dataGridView1.RowCount - 2; i++)
                {
                    satiskaydet(i);
                    uruneksilt(i);
                }               
                dataGridView1.Rows.Clear();
                label5.Text = "0,00";
                label4.Text = "0";
                
            }
            else
            {
                MessageBox.Show("Satış yapabilmek için en az bir ürün girişi yapılmalıdır!", "Hata");
            }
            barkodText.Focus();
            barkodText.Text = "";
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentRow.Index != dataGridView1.RowCount-1)
            {
                toplamtutar = toplamtutar - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
                label5.Text = toplamtutar.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);                
            }
            int sayac = dataGridView1.RowCount - 1;
            label4.Text = sayac.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fat : " + faturaidgetir());
        }

        private void arttırButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 1)
            {
                if (dataGridView1.CurrentRow.Index != dataGridView1.RowCount - 1)
                {
                    int a = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                    dataGridView1.CurrentRow.Cells[2].Value = (a + 1);
                    toplamtutar = toplamtutar + Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                    label5.Text = toplamtutar.ToString();
                    dataGridView1.CurrentRow.Cells[4].Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);

                }
            }
        }
        void ekle(int barkodno)
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select URUNBARKODNO,URUNADI,URUNSATISFIYATI from Urunler where URUNBARKODNO = :pURUNBARKODNO";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pURUNBARKODNO", OracleDbType.Int32, barkodno, ParameterDirection.Input);

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();

            string urunadi = "";
            decimal satisfiyati = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    urunadi = reader.GetString(reader.GetOrdinal("URUNADI"));
                    satisfiyati = reader.GetDecimal(reader.GetOrdinal("URUNSATISFIYATI"));
                }
                dataGridView1.Rows.Add(barkodno, urunadi, 1, satisfiyati, satisfiyati);
            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
            toplamtutar = toplamtutar + satisfiyati;
            label5.Text = toplamtutar.ToString();
            int sayac = dataGridView1.RowCount - 1;
            label4.Text = sayac.ToString();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void azaltButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 1)
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) > 1 && dataGridView1.CurrentRow.Index != dataGridView1.RowCount - 1 && dataGridView1.CurrentRow != null)
                {
                    int a = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                    dataGridView1.CurrentRow.Cells[2].Value = (a - 1);
                    toplamtutar = toplamtutar - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                    label5.Text = toplamtutar.ToString();
                    dataGridView1.CurrentRow.Cells[4].Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                }
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            int barkodno = Convert.ToInt32(barkodText.Text);
            ekle(barkodno);
            barkodText.Focus();
            barkodText.Text = "";
        }       

        private void barkodText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ıconButton2_Click((object) sender, (EventArgs) e);
                barkodText.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ekle(122);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ekle(121);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ekle(120);
        }
    }
}
