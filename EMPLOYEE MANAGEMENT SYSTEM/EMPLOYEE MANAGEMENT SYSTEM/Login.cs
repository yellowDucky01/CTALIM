namespace EMPLOYEE_MANAGEMENT_SYSTEM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Button btnLogin;

        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtbox_firstname = new TextBox();
            txtbox_password = new TextBox();
            this.label_status = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(170, 170);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.TabStop = false;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtbox_firstname
            // 
            txtbox_firstname.Location = new Point(83, 64);
            txtbox_firstname.Name = "txtbox_firstname";
            txtbox_firstname.Size = new Size(100, 23);
            txtbox_firstname.TabIndex = 1;
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new Point(268, 64);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(100, 23);
            txtbox_password.TabIndex = 2;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new Point(302, 195);
            this.label_status.Name = "label_status";
            this.label_status.Size = new Size(45, 15);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "Status: ";
            // 
            // Login
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(486, 328);
            Controls.Add(this.label_status);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_firstname);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Employee Management System";
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            string user = txtbox_firstname.Text;
            string pass = txtbox_password.Text;

            if (db.CheckLogin(user, pass))
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        private TextBox txtbox_firstname;
        private TextBox txtbox_password;
    }
}
