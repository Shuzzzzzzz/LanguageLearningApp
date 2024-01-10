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

namespace LangaugeLearningApp
{
    public partial class Word : Form
    {
        public Word()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zhangshu\Documents\LanguageLearningDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            wordText.Text = string.Empty;
            definitionText.Text = string.Empty;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(wordText.Text == "" || definitionText.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO VocabularyTable (word, definition) VALUES (@word, @definition)", Con);
                    cmd.Parameters.AddWithValue("@word", wordText.Text);
                    cmd.Parameters.AddWithValue("@definition", definitionText.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New word added");
                    Con.Close();
                    Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }     
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            AllWords allWords = new AllWords(); 
            allWords.Show();
            this.Hide();
        }
    }
}
