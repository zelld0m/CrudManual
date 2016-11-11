using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace DAO_ClassLibrary
{
    public class DAL_Dummy
    {
        //sample


        SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");
        public void AddDummy(String Name)
        {
            SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO dummy VALUES ('" + Name + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteDummy(int Delete_ID)
        {
            SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE  FROM dummy WHERE ID = " + Delete_ID + "";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ViewDummy()
        {
            //  SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Dummy";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // datagridview.datasource = dt;
            con.Close();
            return dt;   // use  dt DataTable as datasource

        }
        public DataTable SearchDummy(String inputName)
        {

            SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Dummy Where Name = '" + inputName + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // datagridview.datasource = dt;
            con.Close();
            return dt;   // use  dt DataTable as datasource

        }

        public void UpdateDummy(int inputID, String Name)
        {
            SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE dummy Set Name = '" + Name + "' WHERE ID = " + inputID + "";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataAdapter viewAllxx(DataTable dtx )
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Dummy";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
    
            da.Fill(dt);
            return da;
        }


    }
}
