using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Database
{
    public partial class ArtPiece : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D9754PO;Initial Catalog=CGS;Integrated Security=True");
        public ArtPiece()
        {
            InitializeComponent();
        }

        public void DisplayTable()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Artpiece";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridViewPiece.DataSource = dt;
            con.Close();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void buttonAddPiece_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                char status = 'D';
                if (radioButtonOnDisplay.Checked == true)
                {
                    status = 'D';
                }
                else if (radioButtonStorage.Checked == true)
                {
                    status = 'O';
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Artpiece VALUES ('" + textBoxPieceID.Text + "', '" + textBoxArtistID.Text + "', '" + textBoxCurID.Text + "', '" + textBoxTitle.Text + "', '"+Convert.ToInt32(textBoxYear.Text)+"', '" + Convert.ToDouble(textBoxValue.Text) + "', '" + status + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayTable();
                MessageBox.Show("Art Piece inserted succeccfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            */

            //With stored procedure

            char status = 'D';
            if (radioButtonOnDisplay.Checked == true)
            {
                status = 'D';
            }
            else if (radioButtonStorage.Checked == true)
            {
                status = 'O';
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Artpiece", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ArtpieceID", SqlDbType.VarChar).Value = textBoxPieceID.Text;
                cmd.Parameters.AddWithValue("ArtistID", SqlDbType.VarChar).Value = textBoxArtistID.Text;
                cmd.Parameters.AddWithValue("CuratorID", SqlDbType.VarChar).Value = textBoxCurID.Text;
                cmd.Parameters.AddWithValue("Title", SqlDbType.VarChar).Value = textBoxTitle.Text;
                cmd.Parameters.AddWithValue("Year", SqlDbType.Int).Value = Convert.ToInt32(textBoxYear.Text);
                cmd.Parameters.AddWithValue("Value", SqlDbType.Float).Value = Convert.ToDouble(textBoxValue.Text);
                cmd.Parameters.AddWithValue("Status", SqlDbType.VarChar).Value = status;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Artpiece has been added to the table!");
            }
            catch
            {
                MessageBox.Show("AN EXCEPTION HAPPENED!");
            }
            finally
            {
                con.Close();
                DisplayTable();
            }
        }
    }
}
