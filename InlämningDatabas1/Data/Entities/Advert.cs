namespace InlämningDatabas1.Data.Entities
{
    public class Advert
    {
        public int AdvertID { get; set; }


        public string AdvertName { get; set; }


        public int Price { get; set; }


        public User UserCreator { get; set; }


        public Category Category { get; set; }


        public string Description { get; set; }


        public DateTime? DateOfRelease { get; set; }


        // Constructor
        public Advert(int advertID,
            string advertName,
            int price,
            User userCreator,
            Category category,
            string description,
            DateTime? dateOfRelease)
        {
            AdvertID = advertID;
            AdvertName = advertName;
            Price = price;
            UserCreator = userCreator;
            Category = category;
            Description = description;
            DateOfRelease = dateOfRelease;
        }
    }
}
