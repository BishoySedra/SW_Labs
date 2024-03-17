using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Rental_Form_App
{
    public partial class Form1 : Form
    {
        string credentials = "Data Source = orcl; user Id = scott; Password = tiger";
        OracleConnection conn;
        private void connect() {
            conn = new OracleConnection(credentials);
            conn.Open();
        }

        private void disconnect() { 
            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "modifyName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", id_txt.Text);
            cmd.Parameters.Add("name", name_txt.Text);

            int r = cmd.ExecuteNonQuery(); // update, delete, insert
            OracleDataReader dr =  cmd.ExecuteReader(); //-> // select

            if (r != 0)
            {
                MessageBox.Show("C_Name Modified Successfully!");
            }
            else {
                MessageBox.Show("C_Name Modification Failed Successfully!");   
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void Form1_Dispose(object sender, EventArgs e)
        {
            disconnect();
        }
    }
}
