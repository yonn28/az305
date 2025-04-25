using sqlapp.Models;
using System.Data.SqlClient;

namespace sqlapp.Services
{
    public class CourseService
    {
        private static string db_source = "db24042025.database.windows.net";
        private static string db_user = "dbadmin";
        private static string db_password = "Password12345";
        private static string db_database = "courses";

        private SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = db_source;
            builder.UserID = db_user;
            builder.Password = db_password;
            builder.InitialCatalog = db_database;

            return new SqlConnection(builder.ConnectionString);
        }

        public List<Course> GetCourses()
        {
            List<Course> _courseList = new List<Course>();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT CourseID, ExamImage, CourseName, Rating FROM Course";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Course course = new Course()
                            {
                                CourseID = reader.GetInt32(0),
                                ExamImage = reader.GetString(1),
                                CourseName = reader.GetString(2),
                                Rating = reader.GetDecimal(3)
                            };

                            _courseList.Add(course);
                        }
                    }
                }
            }

            return _courseList;
        }
    }
}
