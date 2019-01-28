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

namespace Ado.Net_ConnectedMode_HW3
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder SqlConnBuild = new SqlConnectionStringBuilder();
        string User = null, Password = null;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty & textBox2.Text != String.Empty)
            {
                User = textBox1.Text;
                Password = textBox2.Text;
                SqlConnBuild.DataSource= @"COMP806\SQLEXPRESS";
                SqlConnBuild.InitialCatalog= "bookshops";
                SqlConnBuild.UserID = User;
                SqlConnBuild.Password = Password;
                SqlConnection conn = new SqlConnection(SqlConnBuild.ConnectionString);
                try
                {
                    conn.Open();
                    if(conn.State == ConnectionState.Open)
                        MessageBox.Show("You are champ!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn?.Close();
                }
                
            }
        }
    }
}
