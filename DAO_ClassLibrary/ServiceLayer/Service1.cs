﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        string IService1.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        #region Code
        Business b = new Business();
        void IService1.addDummy(string name)
        {
            b.name = name;
            b.insert_Dummy();
          
        }

        void IService1.deleteDummy(int ID)
        {
            b.id = ID;
            b.delete_Dummy(b.id);
           
        }



      

        void IService1.UpdateDummy(int ID, string Name)
        {
            b.id = ID;
            b.name = Name;
            b.update_Dummy(b.id);
        
        }

       

        DataSet IService1.SearchDummy(int ID_toSearch)
        {
            b.id = ID_toSearch;
            b.Search_dummy(b.id);
            DataSet ds = new DataSet();
            ds = b.view_dummy();
            throw new NotImplementedException();
        }

        DataSet IService1.viewALLDummy()
        {
            DataSet ds = new DataSet();
            ds = b.view_dummy();
            return ds;
            throw new NotImplementedException();
        }
        #endregion
    }

}