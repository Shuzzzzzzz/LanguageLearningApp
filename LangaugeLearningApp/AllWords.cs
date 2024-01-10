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
    public partial class AllWords : Form
    {
        public AllWords()
        {
            InitializeComponent();
            LoadData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zhangshu\Documents\LanguageLearningDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void LoadData()
        {
            try
            {
                Con.Open();

                string selectQuery = "SELECT * FROM VocabularyTable";
                using (SqlCommand cmd = new SqlCommand(selectQuery, Con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    allWordsGridView.DataSource = dataTable;
                    allWordsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            word.Show();
            this.Hide();
        }

        private void gameLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.example.com");
        }
    }
}
