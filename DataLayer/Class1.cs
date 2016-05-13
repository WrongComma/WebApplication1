using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataLayer
{
    public class DataConnector
    {
        protected SqlDataAdapter DataAdapter1 = new SqlDataAdapter();
        public string ErrorMessage = "";
        public DataConnector(string ConnectionString)
        {
            SqlConnection Connection1 = new SqlConnection(ConnectionString);
            this.DataAdapter1.SelectCommand = new SqlCommand("", Connection1);
            this.DataAdapter1.InsertCommand = new SqlCommand("", Connection1);

        }
        public DataTable DataSelect (string query)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAdapter1.SelectCommand.CommandText = query;
                DataAdapter1.SelectCommand.Connection.Open();
                DataAdapter1.Fill(dt);
                DataAdapter1.SelectCommand.Connection.Close();
                ErrorMessage = "";
            }
            catch(Exception err)
            {
                ErrorMessage = err.Message;
                DataAdapter1.SelectCommand.Connection.Close();
            }
            return dt;
        }
        public int DataInsert(string query)
        {
            int Result=0;
            try
            {
                DataAdapter1.InsertCommand.CommandText = query;
                DataAdapter1.InsertCommand.Connection.Open();
                Result = DataAdapter1.InsertCommand.ExecuteNonQuery();
                DataAdapter1.InsertCommand.Connection.Close();
                ErrorMessage = "";
                return Result;
            }
            catch (Exception err)
            {
                ErrorMessage = err.Message;
                DataAdapter1.InsertCommand.Connection.Close();
                return 0;
            }
            
        }

        public int DataUpdate(string query)
        {
            return DataInsert(query);
        }
        public int DataDelete(string query)
        {
            return DataDelete(query);
        }
    }
}
