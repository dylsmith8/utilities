namespace SearchDir
{
    partial class MainForm
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
            this.lblDir = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.openDir = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtBoxExtension = new System.Windows.Forms.TextBox();
            this.grpBoxResults = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(23, 23);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Directory:";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(82, 21);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(403, 20);
            this.txtDir.TabIndex = 1;
            // 
            // openDir
            // 
            this.openDir.Location = new System.Drawing.Point(491, 21);
            this.openDir.Name = "openDir";
            this.openDir.Size = new System.Drawing.Size(30, 20);
            this.openDir.TabIndex = 2;
            this.openDir.Text = "...";
            this.openDir.UseVisualStyleBackColor = true;
            this.openDir.Click += new System.EventHandler(this.openDir_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(82, 76);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(403, 20);
            this.txtSearchText.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(32, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(19, 52);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(56, 13);
            this.lblExtension.TabIndex = 7;
            this.lblExtension.Text = "Extension:";
            // 
            // txtBoxExtension
            // 
            this.txtBoxExtension.Location = new System.Drawing.Point(82, 49);
            this.txtBoxExtension.Name = "txtBoxExtension";
            this.txtBoxExtension.Size = new System.Drawing.Size(75, 20);
            this.txtBoxExtension.TabIndex = 8;
            // 
            // grpBoxResults
            // 
            this.grpBoxResults.Controls.Add(this.txtResults);
            this.grpBoxResults.Location = new System.Drawing.Point(26, 106);
            this.grpBoxResults.Name = "grpBoxResults";
            this.grpBoxResults.Size = new System.Drawing.Size(680, 321);
            this.grpBoxResults.TabIndex = 9;
            this.grpBoxResults.TabStop = false;
            this.grpBoxResults.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(17, 30);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(657, 285);
            this.txtResults.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(631, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(541, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 505);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxResults);
            this.Controls.Add(this.txtBoxExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.openDir);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.lblDir);
            this.Name = "MainForm";
            this.Text = "Search Dir";
            this.grpBoxResults.ResumeLayout(false);
            this.grpBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button openDir;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtBoxExtension;
        private System.Windows.Forms.GroupBox grpBoxResults;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

