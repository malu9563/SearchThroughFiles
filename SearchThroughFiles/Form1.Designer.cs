namespace SearchThroughFiles
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.directoryTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searWordsTxtBox = new System.Windows.Forms.TextBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultDirectoryTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sökväg:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(85, 81);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Sök";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // directoryTxtBox
            // 
            this.directoryTxtBox.Location = new System.Drawing.Point(85, 25);
            this.directoryTxtBox.Name = "directoryTxtBox";
            this.directoryTxtBox.Size = new System.Drawing.Size(485, 20);
            this.directoryTxtBox.TabIndex = 3;
            this.directoryTxtBox.Text = "C:\\Users\\Wobbler\\Desktop\\Josefina Konsulter CV\\FPGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sökord:";
            // 
            // searWordsTxtBox
            // 
            this.searWordsTxtBox.Location = new System.Drawing.Point(85, 55);
            this.searWordsTxtBox.Name = "searWordsTxtBox";
            this.searWordsTxtBox.Size = new System.Drawing.Size(485, 20);
            this.searWordsTxtBox.TabIndex = 6;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(35, 143);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(535, 186);
            this.resultListBox.TabIndex = 7;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultat av sökningen:";
            // 
            // resultDirectoryTxtBox
            // 
            this.resultDirectoryTxtBox.Location = new System.Drawing.Point(35, 335);
            this.resultDirectoryTxtBox.Name = "resultDirectoryTxtBox";
            this.resultDirectoryTxtBox.Size = new System.Drawing.Size(535, 20);
            this.resultDirectoryTxtBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 363);
            this.Controls.Add(this.resultDirectoryTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.searWordsTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directoryTxtBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox directoryTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searWordsTxtBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultDirectoryTxtBox;
    }
}

