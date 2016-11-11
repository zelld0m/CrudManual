using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAO_ClassLibrary;
namespace DAO_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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

        DataAccessLayer IService1.DummyViewALL()
        {
            throw new NotImplementedException();
        }

        DataAccessLayer IService1.DummyDelete(int inputID)
        {
            throw new NotImplementedException();
        }

        DataAccessLayer IService1.DummyAdd(string name)
        {

           
            return dt;
            throw new NotImplementedException();
        }

        DataAccessLayer IService1.DummySearch(string inputname)
        {
            throw new NotImplementedException();
        }

        DataAccessLayer IService1.DummyUpdate(int inputID, string name)
        {
            throw new NotImplementedException();
        }

        DataAccessLayer IService1.viewall()
        {
            throw new NotImplementedException();
        }


        #region Declaration
        DAO_ClassLibrary.DataAccessLayer DAL = new DAO_ClassLibrary.DataAccessLayer();
        DataAccessLayer dt = new DataAccessLayer();
        #endregion Declaration

        #region COding



       
        #endregion Codings
    }
}
