using InlämningDatabas1.Data.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InlämningDatabas1.Data.Repos
{
    public class AdvertRepo
    {
        // ADO.NET
        public static List<Advert> GetAdvertList(string condition, string filter)
        {
            string sql =
                "SELECT a.AdvertID, a.AdvertName, a.Price, a.Description, a.DateOfRelease, " +
                "c.CategoryID, c.CategoryName, u.UserID, u.UserName " +
                "FROM Adverts a " +
                "INNER JOIN Category c on a.CategoryID = c.CategoryID " +
                "INNER JOIN Users u on a.UserCreatorUserId = u.UserID " +
                "WHERE a.AdvertName LIKE @i AND c.CategoryName LIKE @filter;";

            // Handels seach i safly to avoid SQL injection
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@i", "%" + condition + "%"));
            parameters.Add(new SqlParameter("@filter", "%" + filter + "%"));

            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);

            List<Advert> adverts = new List<Advert>();


            // Because the data in the database is in a different format
            // We need to map the data to our entities
            foreach (DataRow row in result.Rows)
            {
                User user = new User(
                    (int)row["UserID"],
                    row["UserName"].ToString()!,
                    "");
                // ! tells the program that the coloumn will not be null

                Category category = new Category(
                    (int)row["CategoryID"],
                    row["CategoryName"].ToString()!
                    );

                Advert advert = new Advert(
                    (int)row["AdvertID"],
                    row["AdvertName"].ToString()!,
                    (int)row["Price"],
                    user, category,
                    row["Description"].ToString()!,
                    (DateTime)row["DateOfRelease"]
                    );

                adverts.Add(advert);
            }
            return adverts;
        }

        // gets all relavant properties from database into constructor class
        public static Advert? GetAdvert(string advertName)
        {
            string sql =
                "SELECT TOP 1 a.AdvertID, a.AdvertName, a.Price, a.Description, a.DateOfRelease, " +
                "c.CategoryID, c.CategoryName, u.UserID, u.UserName " +
                "FROM Adverts a " +
                "INNER JOIN Category c ON a.CategoryID = c.CategoryID " +
                "INNER JOIN Users u ON a.UserCreatorUserID = u.UserID " +
                "WHERE a.AdvertName LIKE @name;";


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", advertName));

            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);

            if (result.Rows.Count == 0)
                return null;

            DataRow row = result.Rows[0];

            User user = new User(
                (int)row["UserID"],
                row["UserName"].ToString()!,
                ""
                );

            Category category = new Category(
                (int)row["CategoryID"],
                row["CategoryName"].ToString()!
                );

            Advert advert = new Advert(
                (int)row["AdvertID"],
                row["AdvertName"].ToString()!,
                (int)row["Price"],
                user, category,
                row["Description"].ToString()!,
                (DateTime)row["DateOfRelease"]
                );


            return advert;
        }

        public static void AddNewAdvert(string name, int price, string description, DateTime date, int creator, int category)
        {
            string[] paramNames = { "@name", "@price", "@description", "@date", "@creator", "@category" };
            object[] argument = { name, price, description, date, creator, category };

            string sql =
                "INSERT INTO Adverts " +
                "(AdvertName, Price, Description, DateOfRelease, UserCreatorUserID, CategoryID) " +
                "VALUES (@name, @price, @description, @date, @creator, @category);";

            List<SqlParameter> parameters = new List<SqlParameter>();

            for (int i = 0; i < paramNames.Length; i++)
            {
                parameters.Add(new SqlParameter(paramNames[i], argument[i]));
            }


            BlocketContext.ExecuteNonQuery(sql, parameters);
        }

        public static void UpdateAdvert(int id, string name, int price, string description, DateTime date, int category)
        {
            string[] paramNames = { "@name", "@price", "@description", "@date", "@category", "@id" };
            object[] objects = { name, price, description, date, category, id };

            string sql =
                "UPDATE Adverts " +
                "SET AdvertName = @name, Price = @price, Description = @description, DateOfRelease = @date, CategoryID = @category " +
                "WHERE AdvertID = @id;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            for (int i = 0; i < paramNames.Length; i++)
            {
                parameters.Add(new SqlParameter(paramNames[i], objects[i]));
            }

            BlocketContext.ExecuteNonQuery(sql, parameters);
        }

        
        public static void DeleteAdvert(int id)
        {
            string sql =
                "DELETE FROM Adverts" +
                "WHERE AdvertID = @id;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@id", id));

            BlocketContext.ExecuteNonQuery(sql, parameters);
        }
    }
}
