using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");
        #region xx
        //public void AddDummy(String Name)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "INSERT INTO dummy VALUES ('" + Name + "')";
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        //public void DeleteDummy(int Delete_ID)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "DELETE  FROM dummy WHERE ID = " + Delete_ID + "";
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        //public DataTable ViewDummy()
        //{
        //    //  SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "SELECT * FROM Dummy";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    // datagridview.datasource = dt;
        //    con.Close();
        //    return dt;   // use  dt DataTable as datasource

        //}
        //public DataTable SearchDummy(String inputName)
        //{

        //    SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "SELECT * FROM Dummy Where Name = '" + inputName + "'";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    // datagridview.datasource = dt;
        //    con.Close();
        //    return dt;   // use  dt DataTable as datasource

        //}

        //public void UpdateDummy(int inputID, String Name)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "UPDATE dummy Set Name = '" + Name + "' WHERE ID = " + inputID + "";
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        #endregion
        public DataSet view_Dummy()
        {

            SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Select * from dummy";
            SqlDataAdapter sda = new SqlDataAdapter("SelectALL_Dummy", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            return ds;
        }
        public void insert_Dummy(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Insert_Dummy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
        public void update_Dummy(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Update_Dummy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
        public void Delete_Dummy(SqlCommand cmd)
        {


            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Delete_Dummy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

        }
        public void Search_dummy(SqlCommand cmd)
        {


            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SearchDummy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

        }

    
    }
}



        
