using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace CGS_Database
{
    public partial class CGS : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D9754PO;Initial Catalog=CGS;Integrated Security=True");
        public CGS()
        {
            InitializeComponent();
        }

        public void DisplayTable() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Curator";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            CuratorDataGridView.DataSource = dt;
            con.Close();
        }
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Curator VALUES ('"+textBoxCurID.Text+"', '"+textBoxFN.Text+"', '"+textBoxLN.Text+"', '"+Convert.ToDouble(textBoxComm.Text)+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayTable();
            MessageBox.Show("New Curator added to the table");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Curator SET Firstname='"+textBoxFN.Text+ "', Lastname='"+textBoxLN.Text+ "', Commission='"+Convert.ToDouble(textBoxComm.Text)+ "' WHERE CuratorID='"+textBoxCurID.Text+"' ";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayTable();
            MessageBox.Show("Curator record has been updated!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Curator WHERE CuratorID='"+textBoxCurID.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayTable();
            MessageBox.Show("Record has been successfully deleted!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Curator WHERE CuratorID='"+textBoxCurID.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            CuratorDataGridView.DataSource = dt;
            con.Close();
        }
    }
}
