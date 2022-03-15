using System.Data;
using System.Data.SqlClient;

namespace SearchFilterStudentView
{
    /// <summary>
    /// This class saves the data from the database.
    /// </summary>
    public class StudentModel
    {
        /// <summary>
        /// Use the ConnectionHelper to make the calls to the database with the intention to get data.
        /// </summary>
        private ConnectionHelper conexion;

        /// <summary>
        /// Constructor
        /// </summary>
        public StudentModel()
        {
            conexion = new ConnectionHelper();
        }

        /// <summary>
        /// This function makes the query which would be execute with conexion.ExecuteCommand to get the filtered data.
        /// </summary>
        /// <param name="texto">
        /// texto:Text which the user has put in searchTextBox.
        /// </param>
        /// <param name="dataTypeSearch">
        /// NotDate: meaning the text is about name/surname/school's name
        /// Date: meaning the text is date of birth without comparison symbols
        /// Comparison Symbols(>=,<=,>,<) : meaning the text is date of birth with comparison symbols
        /// and "": give all the values in the student table
        /// </param>
        /// <returns>
        /// The return value is the results of the search 
        /// </returns>
        public DataSet SearchStudent(string texto, string dataTypeSearch)
        {
            string commandTextString =
                "select distinct stu.identity_card as 'StudentID',stu.name as 'Name',stu.surnames as 'Surnames',school.name as 'School Name' from student as stu inner join school on stu.id_school=school.id ";
            if (dataTypeSearch=="NotDate")
            {
                commandTextString+="where stu.name='"+texto+"' or stu.surnames='"+texto+"' or  school.name='"+texto+"';";
            }
            else if (dataTypeSearch=="Date")
            {
                commandTextString += "where stu.date_of_birth = '" + texto+"';";
            }
            else if (dataTypeSearch=="<"||dataTypeSearch=="<="||dataTypeSearch==">"||dataTypeSearch==">=")
            {
                commandTextString += "where stu.date_of_birth " + dataTypeSearch + " '" + texto+"';";
            }
            else
            {
                commandTextString += "";
            }
            SqlCommand command = new SqlCommand(commandTextString);

            return conexion.ExecuteCommand(command);

        }
    }
}