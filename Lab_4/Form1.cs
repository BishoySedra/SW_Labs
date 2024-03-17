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

namespace Manage_Data_By_DataAdapter
{
    public partial class Form1 : Form
    {
        string creadentials = "User Id=scott;Password=tiger;Data Source=orcl";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public void connect()
        {
            conn = new OracleConnection(creadentials);
            conn.Open();
        }

        public void disconnect()
        {
            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "";

            if (radioButton1.Checked)
            {
                cmd = "select * from Members";
            }
            else if (radioButton2.Checked)
            {
                cmd = "select * from Actors";
            }

            adapter = new OracleDataAdapter(cmd, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmd = @"SELECT FilmTitle, ReleaseDate  
                           FROM FilmTitle ft, FilmActors fa, Actors a
                           WHERE a.ActorID = fa.ActorID 
                           AND ft.FilmID = fa.FilmID
                           AND a.ActorName = :n";

            OracleDataAdapter adapter_1 = new OracleDataAdapter(cmd, conn);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            DataSet ds = new DataSet();
            adapter_1.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
