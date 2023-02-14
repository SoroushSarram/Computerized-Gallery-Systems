using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_Lib;


namespace CGS_Windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = UsernametextBox.Text;
            string password = PasswordtextBox.Text;
            bool flag = false;
            using (StreamReader sr = new StreamReader(@"C:\Users\Lenovo\Documents\Multi-tier Applications\CGS_Windows\Files\Login.txt"))
            {
                while (sr.Peek() > 0)
                {
                    string str;
                    string[] strarray;
                    str = sr.ReadLine();
                    strarray = str.Split(',');
                    if (username == strarray[0] && password == strarray[1])
                    {
                        flag = true;
                    }  
                }
                if (flag == true)
                {
                    this.Visible = false;
                    MessageBox.Show("Welcome to the system!");

                    mainForm mainForm = new mainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
