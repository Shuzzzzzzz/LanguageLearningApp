using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangaugeLearningApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            timer1.Start();
        }

        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            progress.Value = startP;
            percentage.Text = startP + "%";
            if(progress.Value == 100 )
            {
                progress.Value = 0;
                Login login = new Login();
                login.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
