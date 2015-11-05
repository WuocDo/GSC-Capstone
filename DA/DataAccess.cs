using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShowControls.DA
{
    class DataAccess
    {
        public SqlConnection con;
        public SqlDataAdapter adapter;
        public SqlCommand cmd;

        GameShowControls.Properties.Settings Game = new Properties.Settings();
        string conString;
        //select from database
        public DataTable SelectDatabase(string query)
        {
            conString = Game.DB;
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                adapter.Fill(dtb);
                con.Close();
                return dtb;
            }
            catch (Exception ex)
            {
                if (Game.Test)
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //Insert new catalogue to database
        public bool InsertDatabase(string query)
        {
            conString = Game.DB;
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hệ thống thêm thành công!");
                return true;
            }
            catch (Exception ex)
            {
                if (Game.Test)
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Update infomation of catalouge in database
        public bool UpdateDatabase(string query)
        {
            conString = Game.DB;
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hệ thống Cập nhật thành công!");
                return true;
            }
            catch (Exception ex)
            {
                if (Game.Test)
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Delete catalogue in database
        public bool DeleteDatabase(string query)
        {
            conString = Game.DB;
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hệ thống xóa thành công!");
                return true;
            }
            catch (Exception ex)
            {
                if (Game.Test)
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Row count
        public int RowCountTable(string query)
        {
            conString = Game.DB;
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand(query, con);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                if (Game.Test)
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
