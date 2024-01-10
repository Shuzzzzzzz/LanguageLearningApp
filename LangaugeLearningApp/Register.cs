using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LangaugeLearningApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zhangshu\Documents\LanguageLearningDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            Username.Text = string.Empty;
            Password.Text = string.Empty;
            PasswordConfirm.Text = string.Empty;
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            if(Password.Text == PasswordConfirm.Text)
            {
                try
                {
                    string hashedPassword = PasswordHasher.HashPassword(Password.Text);
                    Con.Open();

                    // SQL command to insert username and hashed password into the database
                    string insertQuery = "INSERT INTO LoginTable (Username, PasswordHash) VALUES (@Username, @PasswordHash)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, Con))
                    {
                        // Parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Username", Username.Text);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account created successfully!");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Passwords not match.");
            }
            Clear();
        }        
    }
}
