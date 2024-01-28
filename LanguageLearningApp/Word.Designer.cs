using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LangaugeLearningApp
{
    partial class Word
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\zhangshu\Documents\LanguageLearningDb.mdf;Integrated Security = True; Connect Timeout = 30");
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.definitionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.saveButton);
            this.addPanel.Controls.Add(this.definitionText);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.wordText);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Location = new System.Drawing.Point(166, 12);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(622, 426);
            this.addPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(46, 285);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // definitionText
            // 
            this.definitionText.Location = new System.Drawing.Point(43, 176);
            this.definitionText.Name = "definitionText";
            this.definitionText.Size = new System.Drawing.Size(546, 22);
            this.definitionText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Definition";
            // 
            // wordText
            // 
            this.wordText.Location = new System.Drawing.Point(43, 93);
            this.wordText.Name = "wordText";
            this.wordText.Size = new System.Drawing.Size(369, 22);
            this.wordText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(30, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 32);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add new word";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(30, 206);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(114, 32);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View all words";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(30, 314);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(114, 29);
            this.logout.TabIndex = 6;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox definitionText;
        private Button saveButton;
        private Button logout;
    }
}