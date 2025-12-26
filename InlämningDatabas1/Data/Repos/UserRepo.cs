using InlämningDatabas1.Data.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InlämningDatabas1.Data.Repos
{
    public class UserRepo
    {

        public static List<User> GetUsersList()
        {
            string sql =
                "SELECT UserID, UserName, Password " +
                "FROM Users;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            List<User> users = new List<User>();

            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);


            foreach (DataRow row in result.Rows)
            {
                User user = new User(
                    (int)row["UserID"],
                    row["UserName"].ToString()!,
                    row["Password"].ToString()!);

                users.Add(user);
            }

            return users;
        }


        public static User? GetUser(string userName, string password)
        {
            string sql =
                "SELECT UserID, UserName " +
                "FROM Users " +
                "WHERE UserName = @UserName AND Password = @Password;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@UserName", userName));
            parameters.Add(new SqlParameter("@Password", password));

            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);


            if (result.Rows.Count == 0)
                return null;
            else
            {
                DataRow row = result.Rows[0];

                return new User(
                    (int)row["UserID"],
                    row["UserName"].ToString()!,
                    ""
                    );
            }
        }


        public static bool UserExists(string username)
        {
            string sql =
                "SELECT COUNT(*) FROM Users WHERE UserName = @UserName;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@UserName", username));

            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);
            DataRow row = result.Rows[0];

            int count = (int)row[0];

            return count > 0;
        }



        // Method to add a new user to the database
        // Don't really know if this is the right place for it
        // Still should work
        public static void AddNewUser(string username, string password)
        {
            string sql =
                "INSERT INTO Users (UserName, Password) " +
                "VALUES (@UserName, @Password);";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@UserName", username));
            parameters.Add(new SqlParameter("@Password", password));


            BlocketContext.ExecuteNonQuery(sql, parameters);
            // In a real app,
            // hash the password before storing it
        }
    }
}
