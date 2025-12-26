using InlämningDatabas1.Data.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InlämningDatabas1.Data.Repos
{
    public class CategoryRepo
    {
        // ADO.NET
        public static List<Category> GetCategoryList()
        {
            string sql =
                "SELECT CategoryID, CategoryName " +
                "FROM Category;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);

            List<Category> categories = new List<Category>();

            foreach (DataRow row in result.Rows)
            {
                Category category = new Category
                    ((int)row["CategoryID"],
                    row["CategoryName"].ToString()
                    );

                categories.Add(category);
            }

            return categories;
        }

        public static Category? GetCategory(string categoryName)
        {
            string sql =
                "SELECT TOP 1 CategoryID, CategoryName " +
                "FROM Category " +
                "WHERE CategoryName LIKE @name;";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@name", categoryName));


            DataTable result = BlocketContext.ExecuteQueryReturnTable(sql, parameters);

            if (result.Rows.Count == 0)
                return null;
            else
            {
                DataRow row = result.Rows[0];

                return new Category(
                    (int)row["CategoryID"],
                    row["CategoryName"].ToString()!
                    );
            }
        }


        public static void AddCategory(string categoryName)
        {
            string sql =
                "INSERT INTO Category (CategoryName) " +
                "VALUES (@CategoryName);";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@CategoryName", categoryName));


            BlocketContext.ExecuteNonQuery(sql, parameters);
        }
    }
}
