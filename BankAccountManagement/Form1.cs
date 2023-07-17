using Repository.Services;

namespace BankAccountManagement
{
    public partial class Form1 : Form
    {
        public UserService UserService;
        public Form1()
        {
            UserService = new UserService();
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPass.Text;
            //Kiểm tra username password có trong db ko role = 1
            var user = UserService.GetAll().Where(p => p.UserName.Equals(userName)  && p.Password.Equals(password) && p.UserRole == 1).FirstOrDefault();
            if(user != null)
            {
                FrmMangement frm = new FrmMangement();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not allowed to access this function!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}