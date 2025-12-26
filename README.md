ToDo list : Blocket


- LogIn form 
	Logged in required to edit and to add items to database 
	Check SuperStarRecepies to learn login maybe
	And / or look at ShotgunGambling aswell

- database
	Who
	Categories
	Date of entry
	Price

- Let users create new Ads in program

- Search with category filter
	Result is in listBox
	Click on item in listBox to select

- List is to be sorted by price OR by date

- Sort by price and date




optional code: 

public FormAdvert()
{
// same as before
}


// Optional: constructor that accepts the existing login and blocket forms (recommended)
public FormAdvert(FormLogin loginForm, FormBlocket blocketForm) : this()
{
    _loginForm = loginForm ?? _loginForm;
    // use the provided BlocketForm if supplied
    if (blocketForm != null) _blocketForm = blocketForm;
}

private void btnSave_Click(object sender, EventArgs e)
{
    User user = new User();
    Advert advert = new Advert();
    Category category = new Category();


// continue from here
}