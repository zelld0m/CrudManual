﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace BusinessLayer
{
    public class Business
    {
        DataAccess da = new DataAccess();
        public int id { get; set; }
        public String name { get; set; }
        SqlCommand cmd = new SqlCommand();

        public DataSet view_dummy() //  view
        {
            return da.view_Dummy(); 
        }
        public void insert_Dummy(String _name)   //Insert
        {
            cmd.Parameters.AddWithValue("@name", name);//
            da.insert_Dummy(cmd);       // Method created in dataaccesslayer
        }

        public void update_Dummy(int _id, String _name)// Update
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            da.update_Dummy(cmd);
        }
        public void delete_Dummy(int _id)   //Delete
        {
            cmd.Parameters.AddWithValue("@id", id);
            da.Delete_Dummy(cmd);
        }
        public void Search_dummy(int _id)   //Search
        {
            cmd.Parameters.AddWithValue("@id", id);
            da.Search_dummy(cmd);
        }
    }
    
}
