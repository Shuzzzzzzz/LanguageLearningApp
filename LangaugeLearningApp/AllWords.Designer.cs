namespace LangaugeLearningApp
{
    partial class AllWords
    {
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
            this.allWordsGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.gameLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.allWordsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allWordsGridView
            // 
            this.allWordsGridView.BackgroundColor = System.Drawing.Color.White;
            this.allWordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allWordsGridView.Location = new System.Drawing.Point(188, 12);
            this.allWordsGridView.Name = "allWordsGridView";
            this.allWordsGridView.RowHeadersWidth = 51;
            this.allWordsGridView.RowTemplate.Height = 24;
            this.allWordsGridView.Size = new System.Drawing.Size(800, 466);
            this.allWordsGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(38, 133);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add new word";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "View all words";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(38, 325);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(117, 29);
            this.logout.TabIndex = 5;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // gameLink
            // 
            this.gameLink.AutoSize = true;
            this.gameLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLink.Location = new System.Drawing.Point(772, 499);
            this.gameLink.Name = "gameLink";
            this.gameLink.Size = new System.Drawing.Size(125, 25);
            this.gameLink.TabIndex = 6;
            this.gameLink.TabStop = true;
            this.gameLink.Text = "GameBreak";
            this.gameLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gameLink_LinkClicked);
            // 
            // AllWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.gameLink);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.allWordsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllWords";
            ((System.ComponentModel.ISupportInitialize)(this.allWordsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allWordsGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.LinkLabel gameLink;
    }
}