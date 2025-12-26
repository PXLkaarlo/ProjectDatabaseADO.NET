using InlämningDatabas1.Data.Entities;
using InlämningDatabas1.Data.Repos;

namespace InlämningDatabas1.Forms
{
    public partial class FormAdvert : Form
    {
        private readonly FormLogin _loginForm;
        private FormBlocket _blocketForm;
        private User? _creator;
        public bool _saved { get; private set; }
        // ?. Safely accesses a member (property, field, method or event)
        // of an object that could be null.     GeeksForGeeks



        // Constructor that accepts the existing login and blocket forms
        // Callers must pass the active FormLogin and the parent FormBlocket.
        public FormAdvert(FormLogin loginForm, FormBlocket blocketForm)
        {
            _loginForm = loginForm;
            _blocketForm = blocketForm ?? throw new ArgumentNullException(nameof(blocketForm));
            // ?? means if value is null, do this instead


            InitializeComponent();
        }



        private void FormAdvert_Load(object sender, EventArgs e)
        {
            // To fill ComboBoxes, do the same as a listBoxes
            cmbCategory.Items.Clear();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            cmbCategory.DataSource = CategoryRepo.GetCategoryList();

            var selectedAdvert = _blocketForm?._selectedAdvert as Advert;

            if (_loginForm?.LoggedIn != null)
            { _creator = _loginForm.LoggedInUser; }




            if (selectedAdvert == null)
            {
                lblAdvertName.Text = "Create New Advert";

                cmbCategory.Text = null;

                btnDelete.Enabled = false;
            }
            else // Shows up to view or to edit selectedAdvert
            {
                if (_loginForm != null && _loginForm.LoggedIn
                        && (selectedAdvert != null
                        && selectedAdvert.UserCreator.UserID == _creator.UserID))
                {
                    lblAdvertName.Text = selectedAdvert.AdvertName;
                }

                else { lblAdvertName.Text = $"Name of newAdvert"; }


                txtAdvertName.Text = selectedAdvert.AdvertName;
                txtDescription.Text = selectedAdvert.Description;
                txtPrice.Text = selectedAdvert.Price.ToString();

                cmbCategory.SelectedValue = selectedAdvert.Category.CategoryID;
            }


            // checks if the user is logged in
            // if the user is logged in
            // then the user has to be the correct user
            // in order to be able to edit
            if (_loginForm != null && _loginForm.LoggedIn
                    && (selectedAdvert != null
                    && selectedAdvert.UserCreator.UserID == _creator.UserID))
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;

                txtAdvertName.Enabled = true;
                txtDescription.Enabled = true;
                txtPrice.Enabled = true;

                cmbCategory.Enabled = true;

                lblCategory.Text = "Category";
            }


            else if (_loginForm != null && _loginForm.LoggedIn
                    && selectedAdvert == null)
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = false;

                txtAdvertName.Enabled = true;
                txtDescription.Enabled = true;
                txtPrice.Enabled = true;

                cmbCategory.Enabled = true;

                lblCategory.Text = "Set category.";

            }

            else    // Happens if not logged in OR if wrong user is logged in
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;

                txtAdvertName.ReadOnly = true;
                txtDescription.ReadOnly = true;
                txtPrice.ReadOnly = true;

                cmbCategory.Enabled = false;
            }


            _saved = false;
        }


        private int? ValidatePrice(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
                return null;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedAdvert = _blocketForm._selectedAdvert as Advert;
            var selectedCategory = cmbCategory.SelectedItem as Category;



            // Basic validation
            if (string.IsNullOrWhiteSpace(txtAdvertName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("The item needs a name, a description and a newCategory to be assigned.");
                return;
            }



            // Ensure the ComboBox actually contains a Category object
            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please select or create a valid newCategory.");
                return;
            }



            // If this is a new newAdvert.
            // Checks for duplicates
            var existingAdvert = AdvertRepo.GetAdvert(txtAdvertName.Text.Trim());

            // this could be a problem
            if (existingAdvert != null
                    && existingAdvert?.AdvertID != selectedAdvert?.AdvertID)
            {
                MessageBox.Show("There is already an Advert with the same name.");
                return;
            }

            else if (selectedAdvert == null) // Creating new Advert
            {
                string name = txtAdvertName.Text.Trim();
                string description = txtDescription.Text;
                DateTime date = DateTime.Now;
                int creator = _creator.UserID;
                int price;
                int category;


                if (ValidatePrice(txtPrice.Text.Trim()) == null)
                { return; }
                // just in case
                else price = (int)ValidatePrice(txtPrice.Text.Trim());



                // Selecting an already existing category
                if (selectedCategory != null)
                {
                    category = selectedCategory.CategoryID;
                }

                else // use newly created category
                {
                    string newCategory = cmbCategory.Text.Trim();
                    CategoryRepo.AddCategory(newCategory);

                    category = CategoryRepo.GetCategory(newCategory).CategoryID;

                }


                AdvertRepo.AddNewAdvert(name, price, description, date, creator, category);
            }



            // If editing an existing Advert,
            // update old properties of Advert
            // to new properties, IE Title, Description, Price and Category
            else
            {
                int id = selectedAdvert.AdvertID;
                string name = txtAdvertName.Text;
                string description = txtDescription.Text;
                DateTime date = DateTime.Now;
                int creator = _creator.UserID;
                int price;
                int category;


                if (ValidatePrice(txtPrice.Text.Trim()) == null)
                    return;
                else price = (int)ValidatePrice(txtPrice.Text.Trim());


                // Selecting an already existing category
                if (selectedCategory != null)
                {
                    category = selectedCategory.CategoryID;
                }

                else // use newly created category
                {
                    string newCategory = cmbCategory.Text.Trim();
                    CategoryRepo.AddCategory(newCategory);

                    category = CategoryRepo.GetCategory(newCategory).CategoryID;
                }



                AdvertRepo.UpdateAdvert(id, name, price, description, date, category);
            }


            _saved = true;
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedAdvert = _blocketForm._selectedAdvert as Advert;


            if (selectedAdvert == null)
            {
                MessageBox.Show("Select a newAdvert first if you whant to delete it!");
                return;
            }

            else if (selectedAdvert.UserCreator.UserID == _creator.UserID)
            {
                AdvertRepo.DeleteAdvert(selectedAdvert.AdvertID);

                _saved = true;
                this.Close();
                return;
            }

            else
            {
                MessageBox.Show("I don't know what just happend. ERROR!");
                return;     // Just cause
            }
        }
    }
}
