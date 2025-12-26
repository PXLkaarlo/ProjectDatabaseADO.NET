using InlämningDatabas1.Data.Entities;
using InlämningDatabas1.Data.Repos;
using InlämningDatabas1.Forms;

namespace InlämningDatabas1
{
    public partial class FormBlocket : Form
    {
        private FormLogin _loginForm;

        public FormBlocket()
        {
            _loginForm = new FormLogin();
            InitializeComponent();
        }

        public object? _selectedAdvert { get; private set; } = null;


        private void SetButtonsForLoggedInUser()
        {
            btnLogin.Enabled = false;
            btnCreate.Enabled = true;
        }


        private void FillListBox()
        {
            string searchCondition = txtSearch.Text?.Trim();
            string selectedFilter = cmbFilter.SelectedItem?.ToString();


            if (cmbFilter.SelectedItem != null)
            {
                selectedFilter = cmbFilter.Text;
            }

            List<Advert> adverts = AdvertRepo.GetAdvertList(searchCondition, selectedFilter);


            // Price filter
            if ((nudMinPrice.Value != nudMaxPrice.Value) && !(nudMaxPrice.Value < nudMinPrice.Value)
                || (rdbLowestPrice.Checked || rdbHighestPrice.Checked))
            {
                adverts = adverts
                        .Where(a => a.Price >= nudMinPrice.Value
                                && a.Price <= nudMaxPrice.Value)
                        .ToList();
                lblDeclarePrice.Text = null;
            }
            else
            {
                lblDeclarePrice.Text = "No price filter";
            }



            if (rdbOldFirst.Checked)        // Priority oldest items first
            {
                adverts = adverts
                    .OrderBy(a => a.DateOfRelease)
                    .ToList();
            }
            else if (rdbNewFirst.Checked)   // Priority newest items first
            {
                adverts = adverts
                    .OrderByDescending(a => a.DateOfRelease)
                    .ToList();
            }


            else if (rdbLowestPrice.Checked)    // Priority lowest price first
            {
                adverts = adverts
                        .OrderBy(a => a.Price)
                        .ToList();
            }
            else if (rdbHighestPrice.Checked)   // Priority Highest price first
            {
                adverts = adverts
                        .OrderByDescending(a => a.Price)
                        .ToList();
            }

            else if ((nudMaxPrice.Value < nudMinPrice.Value)
                    && (rdbLowestPrice.Checked || rdbHighestPrice.Checked))
            {
                MessageBox.Show("There is no Advert " +
                                "with these conditions possible.");
                return;
            }


            listBoxResult.DisplayMember = "AdvertName";
            listBoxResult.ValueMember = "AdvertID";

            listBoxResult.DataSource = adverts;
        }


        private void FormBlocket_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnCreate.Enabled = false;

            cmbFilter.DisplayMember = "CategoryName";
            cmbFilter.ValueMember = "CategoryID";

            cmbFilter.DataSource = CategoryRepo.GetCategoryList();

            FillListBox();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            _loginForm.ShowDialog();
            // Next lines of code happens after the login form is closed
            // Vital

            if (_loginForm.LoggedIn)
            {
                SetButtonsForLoggedInUser();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillListBox();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Pass the loginForm and "this" blocketForm to the advertForm
            FormAdvert advertForm = new FormAdvert(_loginForm, this);
            _selectedAdvert = null;
            advertForm.ShowDialog();

            FillListBox();
        }


        private void listBoxResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormAdvert advertForm = new FormAdvert(_loginForm, this);
            _selectedAdvert = listBoxResult.SelectedItem;

            if (_selectedAdvert != null)
            {
                advertForm.ShowDialog();
            }

            if (_loginForm != null && _loginForm?.LoggedIn != null)
            {
                FillListBox();
            }
        }
    }
}
