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
    public partial class Artist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D9754PO;Initial Catalog=CGS;Integrated Security=True");
        public Artist()
        {
            InitializeComponent();
        }

        public void DisplayTable()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Artist";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridViewArtist.DataSource = dt;
            con.Close();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void buttonAddArtist_Click(object sender, EventArgs e)
        {

            /*
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Artist VALUES ('" + textBoxArtistID.Text + "', '" + textBoxArtistFN.Text + "', '" + textBoxArtistLN.Text + "', '" + textBoxCuratorID.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayTable();
                MessageBox.Show("Artist inserted succeccfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            */

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Artist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ArtistID", SqlDbType.VarChar).Value = textBoxArtistID.Text;
                cmd.Parameters.AddWithValue("Firstname", SqlDbType.VarChar).Value = textBoxArtistFN.Text;
                cmd.Parameters.AddWithValue("Lastname", SqlDbType.VarChar).Value = textBoxArtistLN.Text;
                cmd.Parameters.AddWithValue("CuratorID", SqlDbType.VarChar).Value = textBoxCuratorID.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Artist has been added to the table!");

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
