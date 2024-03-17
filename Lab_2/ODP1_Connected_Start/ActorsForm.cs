using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{
    public partial class ActorsForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        public ActorsForm()
        {
            InitializeComponent();
        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ActorID from Actors";
            cmd.CommandType = CommandType.Text;

            // select -> ExecuteReader
            // u, i, d -> 

            OracleDataReader dr = cmd.Ex();
            while (dr.Read())
            {
                cmb_ID.Items.Add(dr[0]);
            }
            dr.Close();


        }

        private void cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write the code here
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = "select actorName, gender from Actors where ActorID=:id";
            oracleCommand.CommandType = CommandType.Text;
            oracleCommand.Parameters.Add("id", cmb_ID.SelectedItem.ToString());

            OracleDataReader dr = oracleCommand.ExecuteReader();
            if (dr.Read())
            {
                txt_Name.Text = dr[0].ToString();
                txt_Gender.Text = dr[1].ToString();
            }

            dr.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //Write the code here

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // command to check if the id exists
            cmd.CommandText = "select ActorID from Actors where ActorID=:id";
            cmd.Parameters.Add("id", cmb_ID.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("This actor already exists!");
                dr.Close();
                return;
            }
            dr.Close();

            // remove the old parameters
            cmd.Parameters.Clear();

            // command to insert the actor
            cmd.CommandText = "insert into Actors values(:id, :name, :gender)";
            cmd.Parameters.Add("id", cmb_ID.Text);
            cmd.Parameters.Add("name", txt_Name.Text);
            cmd.Parameters.Add("gender", txt_Gender.Text);

            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                cmb_ID.Items.Add(cmb_ID.Text);
                MessageBox.Show("Actor Inserted!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Write the code here

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // command to check if the id not exists
            cmd.CommandText = "select ActorID from Actors where ActorID=:id";
            cmd.Parameters.Add("id", cmb_ID.Text);
       
            OracleDataReader dr = cmd.ExecuteReader();
           
            if (!dr.Read())
            {
                MessageBox.Show("This actor does not exist to be updated!");
                dr.Close();
                return;
            }

            dr.Close();

            // remove the old parameters
            cmd.Parameters.Clear();

            // command to update the actor
            cmd.CommandText = "UPDATE Actors set actorName=:name, gender=:gender where ActorID=:id";
            cmd.Parameters.Add("name", txt_Name.Text);
            cmd.Parameters.Add("gender", txt_Gender.Text);
            cmd.Parameters.Add("id", cmb_ID.SelectedItem.ToString());

            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Actor Updated!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Write the code here
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // command to check if the id not exists
            cmd.CommandText = "select ActorID from Actors where ActorID=:id";
            cmd.Parameters.Add("id", cmb_ID.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("This actor does not exist to be deleted!");
                dr.Close();
                return;
            }

            dr.Close();

            // remove the old parameters
            cmd.Parameters.Clear();

            // command to delete the actor
            cmd.CommandText = "delete from Actors where ActorID=:id";
            cmd.Parameters.Add("id", cmb_ID.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_ID.Items.Remove(cmb_ID.SelectedItem);
                MessageBox.Show("Actor Deleted!");
            }

        }

        private void ActorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Gender_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
