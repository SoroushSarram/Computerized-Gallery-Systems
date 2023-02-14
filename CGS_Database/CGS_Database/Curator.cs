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
    public partial class Curator : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D9754PO;Initial Catalog=CGS;Integrated Security=True");

        public void DisplayTable()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Curator";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridViewCur.DataSource = dt;
            con.Close();
        }
        public Curator()
        {
            InitializeComponent();
        }

        private void PleaseRefreshMyCuratorDGV()
        {
            string query = "SELECT * FROM Curator";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Curator");
            dataGridViewCur.DataSource = ds.Tables[0];
        }
        private void buttonAddCur_Click(object sender, EventArgs e)
        {
            // WITHOUT STORED PROCEDURE
            /*
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Curator VALUES ('" + textBoxCurID.Text + "', '" + textBoxFN.Text + "', '" + textBoxLN.Text + "', '" + Convert.ToDouble(textBoxComm.Text) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayTable();
                MessageBox.Show("New Curator added to the table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            */

            // WITH STORED PROCEDURE
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Curator", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CuratorID", SqlDbType.VarChar).Value = textBoxCurID.Text;
                cmd.Parameters.AddWithValue("Firstname", SqlDbType.VarChar).Value = textBoxFN.Text;
                cmd.Parameters.AddWithValue("Lastname", SqlDbType.VarChar).Value = textBoxLN.Text;
                cmd.Parameters.AddWithValue("Commission", SqlDbType.Float).Value = Convert.ToDouble(textBoxComm.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curator has been added to the Table");
                PleaseClearAllMyTextBoxes();
            }
            catch
            {
                MessageBox.Show("AN EXCEPTION HAPPENED!");
            }
            finally { 
                con.Close();
                //DisplayTable();
            }

        }

        private void PleaseClearAllMyTextBoxes()
        {
            Action<Control.ControlCollection> myActionEventsHandler = null;
            myActionEventsHandler = (controls) =>{
                foreach (Control control in controls) {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else {
                        myActionEventsHandler(control.Controls);
                    }
                }
            };
            myActionEventsHandler(Controls);

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PleaseRefreshMyCuratorDGV();
            timer1.Start();
        }

        private void Curator_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dataGridViewCur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
