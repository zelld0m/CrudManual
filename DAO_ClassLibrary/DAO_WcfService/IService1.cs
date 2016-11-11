using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAO_ClassLibrary;


using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace DAO_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        DAO_ClassLibrary.DataAccessLayer DummyViewALL();
        [OperationContract]
        DAO_ClassLibrary.DataAccessLayer DummyDelete(int inputID);
        [OperationContract]
        DAO_ClassLibrary.DataAccessLayer DummyAdd(String name);
        [OperationContract]
        DAO_ClassLibrary.DataAccessLayer DummySearch(String inputname);
        [OperationContract]
        DAO_ClassLibrary.DataAccessLayer DummyUpdate(int inputID, String name);

        [OperationContract]
        DAO_ClassLibrary.DataAccessLayer viewall();

    
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
