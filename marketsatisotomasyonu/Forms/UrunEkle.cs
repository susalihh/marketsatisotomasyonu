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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
            
        }
        void listele()
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            OracleCommand command = new OracleCommand();

            command.Connection = conn;
            string sqlselect = "select * from kategori";
            command.CommandText = sqlselect;
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;

            DataTable dataListe = new DataTable();
            adapter.Fill(dataListe);
            dataGridView1.DataSource = dataListe;
            conn.Close();
            adiText.Text = "";
        }
        void listele2()
        {
            string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
            OracleConnection conn = new OracleConnection(connstring);
            OracleCommand command = new OracleCommand();

            command.Connection = conn;
            string sqlselect = "select * from Marka";
            command.CommandText = sqlselect;
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;

            DataTable dataListe = new DataTable();
            adapter.Fill(dataListe);
            dataGridView1.DataSource = dataListe;
            conn.Close();
            adiText.Text = "";
            idText.Text = "";
        }
        private void ekleButton_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Kategori(KATEGORIID,KATEGORIADI) VALUES (kategoriartis.nextval,:pKATEGORIADI)";

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(":pKATEGORIADI", OracleDbType.Varchar2, adiText.Text, ParameterDirection.Input);


                cmd.ExecuteNonQuery();
                conn.Close();
                listele();
            }
            else if (radioButton2.Checked == true)
            {
                string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Marka(MARKAID,MARKAADI) VALUES (markaartis.nextval,:pMARKAADI)";

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(":pMARKAADI", OracleDbType.Varchar2, adiText.Text, ParameterDirection.Input);


                cmd.ExecuteNonQuery();
                conn.Close();
                listele2();
            }
            
        }

        private void UrunEkle_Load(object sender, EventArgs e)
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
            radioButton1.Checked = true;
            listele();            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    idText.Text = row.Cells[0].Value.ToString();
                    adiText.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {            
            if (radioButton1.Checked == true)
            {
                string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE KATEGORI SET KATEGORIADI = :pKATEGORIADI where KATEGORIID = :pKATEGORIID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(":pKATEGORIADI", OracleDbType.Varchar2, adiText.Text, ParameterDirection.Input);
                cmd.Parameters.Add(":pKATEGORIID", OracleDbType.Int32, Convert.ToInt32(idText.Text), ParameterDirection.Input);

                cmd.ExecuteNonQuery();
                conn.Close();
                listele();
            }
            else if (radioButton2.Checked == true)
            {
                string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE MARKA SET MARKAADI = :pMARKAADI where MARKAID = :pMARKAID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(":pMARKAADI", OracleDbType.Varchar2, adiText.Text, ParameterDirection.Input);
                cmd.Parameters.Add(":pMARKAID", OracleDbType.Int32, Convert.ToInt32(idText.Text), ParameterDirection.Input);

                cmd.ExecuteNonQuery();
                conn.Close();
                listele2();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.BackColor = Color.DarkSlateBlue;
            radioButton1.BackColor = Color.FromArgb(34, 33, 74);
            listele2();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.DarkSlateBlue;
            radioButton2.BackColor = Color.FromArgb(34, 33, 74);
            listele();
            
        }
    }
}
