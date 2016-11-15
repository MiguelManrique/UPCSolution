using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DataAccess.StudentRepository
{
    
    public class StudentRepository : IStudentRepository
    {

        public void InsertStudent(Entities.Student student)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UPCConnectionString"].ConnectionString;
            
            // define INSERT query with parameters
            string query = "INSERT INTO Students (Code, Name, Age, GradeAverage) " +
                           "VALUES (@Code, @Name, @Age, @GradeAverage) ";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@Code", SqlDbType.VarChar, 15).Value = student.Code;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = student.Name;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = student.Age;
                cmd.Parameters.Add("@GradeAverage", SqlDbType.Decimal).Value = student.GradeAverage;
               

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateStudent(Entities.Student student)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UPCConnectionString"].ConnectionString;

            // define INSERT query with parameters
            string storeProcedure = "usp_Students_UpdateStudent";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(storeProcedure, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // define parameters and their values
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = student.Id;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar, 15).Value = student.Code;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = student.Name;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = student.Age;
                cmd.Parameters.Add("@GradeAverage", SqlDbType.Decimal).Value = student.GradeAverage;


                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public Entities.Student GetStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Student> GetAllStudent()
        {
            List<Entities.Student> studentList = new List<Entities.Student>();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UPCConnectionString"].ConnectionString;

            // define INSERT query with parameters
            string storeProcedure = "usp_Students_GetListOfStudents";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(storeProcedure, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // define parameters and their values
                // open connection, execute INSERT, close connection
                cn.Open();
                //Read records from store procedure with ADO.NET
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Entities.Student objStudent = new Entities.Student();
                        objStudent.Age = Convert.ToInt32(reader["Age"]);
                        objStudent.Code = Convert.ToString(reader["Code"]);
                        objStudent.GradeAverage = Convert.ToDecimal(reader["GradeAverage"]);
                        objStudent.Id = Convert.ToInt32(reader["Id"]);
                        objStudent.Name = Convert.ToString(reader["Name"]);
                        studentList.Add(objStudent);
                    }
                }
                reader.Close();                
                cn.Close();
            }
            return studentList;
        }
    }
}
