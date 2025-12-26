using InlämningDatabas1.Data.Entities;
using InlämningDatabas1.Data.Repos;

namespace InlämningDatabas1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public bool LoggedIn { get; private set; } = false;
        public User LoggedInUser { get; private set; }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblHidden.Text = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter both username and password.");
                return;
                // Early exit if either field is empty
            }


            var user = UserRepo.GetUser(username, password);


            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            else
            {
                LoggedIn = true;
                LoggedInUser = user;
                this.Close();
            } // Successful login
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;


            // Same as login validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter both username and password.");
                return;
            }


            if (UserRepo.UserExists(username))
            {
                MessageBox.Show("User already exists.");
            }
            else
            {
                UserRepo.AddNewUser(username, password);

                lblHidden.ForeColor = System.Drawing.Color.Green;
                lblHidden.Text = "User registered successfully.";
            }
        }
    }
}
