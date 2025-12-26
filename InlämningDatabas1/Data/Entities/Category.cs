namespace InlämningDatabas1.Data.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }


        public string CategoryName { get; set; }


        // Constructor
        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}
