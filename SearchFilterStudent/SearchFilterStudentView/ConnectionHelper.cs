

using System.Data;
using System.Data.SqlClient;

namespace SearchFilterStudentView
{
    /// <summary>
    /// This class makes the connection with the database
    /// and execute the commands to make actions(select) in the database;
    /// </summary>
    public class ConnectionHelper
    {
        /// <summary>
        /// This parts has the required data to access to the database
        /// </summary>
        private string CnnConnection = "Data Source=LAPTOP-V2RVQ2SL; Initial Catalog=db1 ;Integrated Security= True";
        SqlConnection connection;

        /// <summary>
        /// Function to input the data to establish a connection with the database;
        /// </summary>
        /// <returns></returns>
        public SqlConnection makeConnection()
        {
            this.connection = new SqlConnection(this.CnnConnection);
            return this.connection;
        }
        /// <summary>
        /// This function execute the query commands to get information from the tables
        /// </summary>
        /// <param name="command">
        /// command:Query commando to be executed.
        /// </param>
        /// <returns>Returns the results of the search</returns>
        public DataSet ExecuteCommand(SqlCommand command)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand thiSqlCommand = new SqlCommand();
                thiSqlCommand = command;
                thiSqlCommand.Connection = makeConnection();
                adapter.SelectCommand = thiSqlCommand;
                connection.Open();
                adapter.Fill(dataSet);
                connection.Close();
                return dataSet;
            }
            catch
            {
                return dataSet;
            }
        }
    }
}