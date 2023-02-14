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


namespace CGS_Database
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D9754PO;Initial Catalog=CGS;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {
                string query = "SELECT * FROM login WHERE Username='"+textBoxUsername.Text+"' AND Password='"+textBoxPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Curator cur = new Curator();
                    cur.ShowDialog();
                    Artist artist = new Artist();
                    artist.ShowDialog();
                    ArtPiece piece = new ArtPiece();
                    piece.ShowDialog();
                }
                else {
                    MessageBox.Show("Error! Credentials are incorrect!");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
            }
            catch {
                MessageBox.Show("An Exception happened!");
            }
            finally { 
                conn.Close();
            }
        }
    }
}
