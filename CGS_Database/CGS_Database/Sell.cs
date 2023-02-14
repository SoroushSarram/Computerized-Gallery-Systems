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
    public partial class Sell : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D9754PO;Initial Catalog=CGS;Integrated Security=True");

        public void DisplayPiece()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Artpiece";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridViewPieces.DataSource = dt;
            con.Close();
        }

        public void DisplayComm()
        {
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT Firstname, Lastname, Commission FROM Curator";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);
            dataGridViewComms.DataSource = dt2;
            con.Close();
        }
        public Sell()
        {
            InitializeComponent();
            DisplayPiece();
            DisplayComm();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Value FROM Artpiece WHERE ArtpieceID='"+textBoxPieceID.Text+"'", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ValuetextBox.Text = reader["Value"].ToString();
                double value = Convert.ToDouble(reader["Value"].ToString());
                double price = Convert.ToDouble(textBoxPrice.Text);
                if (price >= value)
                {
                    reader.Close();
                    SqlCommand cmds = new SqlCommand("update Artpiece set Status = 'S' where ArtpieceID = ('" + textBoxPieceID.Text + "')", con);
                    cmds.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("select * from Curator where CuratorID = (select CuratorID from Artpiece where ArtpieceID = ('" + textBoxPieceID.Text + "'))", con);
                    SqlDataReader reader2;
                    reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        double comm = Convert.ToDouble(reader2["Commission"].ToString());
                        string cid = reader2["CuratorID"].ToString();
                        double commission = (price - value) * 0.1;
                        double total = commission + comm;
                        reader2.Close();
                        SqlCommand cmdc = new SqlCommand("update Curator set Commission = '" + total + "' where CuratorID = ('" + cid + "')", con);
                        cmdc.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Eror no data found ");
                        reader2.Close();
                    }

                }
                else 
                {
                    MessageBox.Show("Error! The entered price is below the artpice value!" +
                        "But do not worry, Zahra is going to buy Pizza for you on Friday!");
                }
            }
            else {
                MessageBox.Show("ERROR! There is no such record in the DB!");
            }
            con.Close();
            DisplayPiece();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
