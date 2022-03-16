using System;
using System.Collections.ObjectModel;
using System.Data;

namespace weather_retrieval.Common
{
    public class Reader
    {
        protected string CommandText
        {
            get { return "SELECT PersonID, FirstName, LastName, Email FROM tblPerson"; }
        }
        public System.Data.CommandType CommandType
        {
            get { return System.Data.CommandType.Text; }
        }
        public Collection<IDataParameter> GetParameters(IDbCommand command)
        {
            Collection<IDataParameter> collection = new Collection<IDataParameter>();
          
            //// USE THIS IF YOU ACTUALLY HAVE PARAMETERS  
            IDataParameter param1 = command.CreateParameter();
            param1.ParameterName = "paramName 1"; // put parameter name here  
            param1.Value = 5; // put value here;  
            collection.Add(param1);
            return collection;
        }
        public string GetMapper()
        {
          
            return "test";
        }
    }
}
