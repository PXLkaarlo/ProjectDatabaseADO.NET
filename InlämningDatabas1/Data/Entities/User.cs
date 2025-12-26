namespace InlämningDatabas1.Data.Entities
{
    public class User
    {
        public int UserID { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }


        public string? Email { get; set; } // ? to allow null values.  IMPORTANT TO REMEMBER


        public string? PhoneNumber { get; set; }

        public User(int userID, string userName, string password)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
        }
    }
}
