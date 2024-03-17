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
    public partial class Form2 : Form
    {
        string credentails = "User Id=scott;Password=tiger;Data Source=orcl";
        OracleConnection conn;

        public void Connect()
        {
            conn = new OracleConnection(credentails);
            conn.Open();
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Connect();

            Date_Rented.Text = DateTime.Now.ToString();
            Date_Due_Back.Text = DateTime.Now.AddDays(3).ToString();

        }

        private void Show_Available_Copies_Btn_Click(object sender, EventArgs e)
        {
            // command to get the id of film given the title
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select filmId from filmTitles where filmTitle = :title";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("title", Film_Title.Text);

            OracleDataReader dr = cmd.ExecuteReader();

            string filmId = "";
            if (dr.Read())
            {
                filmId = dr[0].ToString();
            }

            dr.Close();

            // remove all parameters
            cmd.Parameters.Clear();

            // command to get the available copies of the film
            cmd.CommandText = "select copyID from filmCopies where filmId = :id and currentlyRented = 'n'";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", filmId);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                copy_IDS.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void Rent_Btn_Click(object sender, EventArgs e)
        {
            // command to get the max rental id found in the database
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetRentID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("rentId", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            // get the max rental id
            int rentId = 0;
            try
            {
                rentId = Convert.ToInt32(cmd.Parameters["rentId"].Value.ToString());
                rentId++;
            }
            catch
            {
                rentId = 1;
            }


            // remove all parameters
            cmd.Parameters.Clear();

            // command to get the id of film given the title
            cmd.CommandText = "select filmId from filmTitles where filmTitle = :title";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("title", Film_Title.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            string filmId = "";
            if (dr.Read())
            {
                filmId = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Film not found");
                return;
            }

            dr.Close();

            // remove all parameters
            cmd.Parameters.Clear();

            // command to insert the rental into the database
            cmd.CommandText = "Insert_Rental";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("rentId", rentId);
            cmd.Parameters.Add("memberId", Member_ID.Text);
            cmd.Parameters.Add("copyId", copy_IDS.SelectedItem.ToString());
            cmd.Parameters.Add("rentDate", Convert.ToDateTime(Date_Rented.Text));
            cmd.Parameters.Add("dueDate", Convert.ToDateTime(Date_Due_Back.Text));
            cmd.Parameters.Add("cost", Cost.Text);

            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Rental Successful");
            }
            else
            {
                MessageBox.Show("Rental Failed");
            }

            // remove all parameters
            cmd.Parameters.Clear();

            // command to update the film copy to rented
            cmd.CommandText = "UPDATE_STATUS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", copy_IDS.SelectedItem.ToString());
            cmd.Parameters.Add("filmId", filmId);

            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Film Copy Updated");
            }
            else
            {
                MessageBox.Show("Film Copy Update Failed");
            }

        }
    }
}
