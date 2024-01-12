using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangaugeLearningApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlConnection Con = new SqlConnection(connectionString);

        private void Clear()
        {
            Username.Text = string.Empty;
            Password.Text = string.Empty;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                Homes homes = new Homes();
                homes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials. Please try again.");
            }
            Clear();
        }
        private bool ValidateLogin(string username, string password)
        {
            try
            {
                Con.Open();

                // SQL command to retrieve user information based on the username
                string selectQuery = "SELECT PasswordHash FROM LoginTable WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(selectQuery, Con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    // Execute the command and retrieve the stored password hash
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPasswordHash = result.ToString();

                        // You should use a secure password hashing and verification library in a real-world scenario
                        // This example uses a simple string comparison for demonstration purposes
                        if (PasswordHasher.VerifyPassword(Password.Text, storedPasswordHash))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Con.Close();
            return false;
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
