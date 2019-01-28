using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Ado_Net_ConnectedMode_HW4
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlCommand comand = null;
        SqlDataReader reader = null;
        string connection = null;
        public Form1()
        {
            connection = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            InitializeComponent();
            AddData();
        }

        private void AddData()
        {
            conn = new SqlConnection(connection);
            string Select = "select table_name from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'base table' and table_name not like 'sys%';";

            try
            {
                conn.Open();
                comand = new SqlCommand(Select, conn);
                reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["table_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn?.Close();
                comand?.Clone();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("Select * from "+ comboBox1.Text,conn);
            DataSet dataSet = new DataSet();
            dataGridView1.DataSource = null;
            Adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
