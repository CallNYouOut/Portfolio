using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace group_project_i_brownie_bandits
{
    public partial class LoginForm : Form
    {
        private readonly User user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Call the function to register a new user
            RegisterUser(txtUsername.Text, txtPassword.Text);
        }

        private void RegisterUser(string username, string password)
        {
            using (var db = new DatabaseContext())
            {
                // Check if username already exists
                if (db.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }

                // Hash the password before storing
                string hashedPassword = HashPassword(password);
                var newUser = new User { Username = username, PasswordHash = hashedPassword };

                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("User registered successfully!");
            }
        }
        public bool ValidateUser(string username, string password)
        {
            // Check to see if the user exists
            using (var db = new DatabaseContext())
            {
                {
                    string hashedPassword = HashPassword(password);

                    return db.Users.Any(u => u.Username == username && u.PasswordHash == hashedPassword);
                }
            }
        }
        public string HashPassword(string password)
        {
            // Hash the passwords for security
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form and exit the program
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string hashedPassword = HashPassword(password);

                // Retrieve the user from the database
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == hashedPassword);

                if (user != null)
                {
                    MessageBox.Show("Login successful!");

                    // Pass the user object to the ProfileForm
                    HomeForm homeForm = new HomeForm(user);
                    homeForm.ShowDialog();
                    this.Close(); // close the login form
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
