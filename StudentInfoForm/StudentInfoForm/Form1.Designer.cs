namespace StudentInfoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new AcrylicUI.Controls.AcrylicLabel();
            btnAddNew = new AcrylicUI.Controls.AcrylicButton();
            btnUpdate = new AcrylicUI.Controls.AcrylicButton();
            btnDelete = new AcrylicUI.Controls.AcrylicButton();
            btnExit = new AcrylicUI.Controls.AcrylicButton();
            txtScoreTotal = new AcrylicUI.Controls.AcrylicTextBox();
            txtScoreCount = new AcrylicUI.Controls.AcrylicTextBox();
            txtAverage = new AcrylicUI.Controls.AcrylicTextBox();
            lblScoreTotal = new AcrylicUI.Controls.AcrylicLabel();
            lblScoreCount = new AcrylicUI.Controls.AcrylicLabel();
            lblAverage = new AcrylicUI.Controls.AcrylicLabel();
            listName = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(192, 192, 192);
            lblName.Location = new Point(36, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnAddNew
            // 
            btnAddNew.Default = false;
            btnAddNew.Image = null;
            btnAddNew.ImagePadding = 366;
            btnAddNew.Location = new Point(475, 66);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Padding = new Padding(5);
            btnAddNew.Size = new Size(172, 48);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Default = false;
            btnUpdate.Image = null;
            btnUpdate.ImagePadding = 549;
            btnUpdate.Location = new Point(475, 150);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(5);
            btnUpdate.Size = new Size(172, 48);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Default = false;
            btnDelete.Image = null;
            btnDelete.ImagePadding = 549;
            btnDelete.Location = new Point(475, 241);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5);
            btnDelete.Size = new Size(172, 48);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Default = false;
            btnExit.Image = null;
            btnExit.ImagePadding = 823;
            btnExit.Location = new Point(459, 490);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5);
            btnExit.Size = new Size(172, 48);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.BackColor = Color.FromArgb(31, 31, 31);
            txtScoreTotal.BorderStyle = BorderStyle.FixedSingle;
            txtScoreTotal.ForeColor = Color.FromArgb(245, 245, 245);
            txtScoreTotal.Location = new Point(289, 390);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(150, 31);
            txtScoreTotal.TabIndex = 6;
            txtScoreTotal.TextChanged += txtScoreTotal_TextChanged;
            // 
            // txtScoreCount
            // 
            txtScoreCount.BackColor = Color.FromArgb(31, 31, 31);
            txtScoreCount.BorderStyle = BorderStyle.FixedSingle;
            txtScoreCount.ForeColor = Color.FromArgb(245, 245, 245);
            txtScoreCount.Location = new Point(289, 450);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(150, 31);
            txtScoreCount.TabIndex = 7;
            txtScoreCount.TextChanged += txtScoreCount_TextChanged;
            // 
            // txtAverage
            // 
            txtAverage.BackColor = Color.FromArgb(31, 31, 31);
            txtAverage.BorderStyle = BorderStyle.FixedSingle;
            txtAverage.ForeColor = Color.FromArgb(245, 245, 245);
            txtAverage.Location = new Point(289, 507);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(150, 31);
            txtAverage.TabIndex = 8;
            txtAverage.TextChanged += txtAverage_TextChanged;
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.AutoSize = true;
            lblScoreTotal.ForeColor = Color.FromArgb(192, 192, 192);
            lblScoreTotal.Location = new Point(145, 392);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(102, 25);
            lblScoreTotal.TabIndex = 9;
            lblScoreTotal.Text = "Score Total:";
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.ForeColor = Color.FromArgb(192, 192, 192);
            lblScoreCount.Location = new Point(134, 452);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(113, 25);
            lblScoreCount.TabIndex = 10;
            lblScoreCount.Text = "Score Count:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.ForeColor = Color.FromArgb(192, 192, 192);
            lblAverage.Location = new Point(166, 509);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(81, 25);
            lblAverage.TabIndex = 11;
            lblAverage.Text = "Average:";
            // 
            // listName
            // 
            listName.BackColor = Color.FromArgb(64, 64, 64);
            listName.ForeColor = SystemColors.Window;
            listName.FormattingEnabled = true;
            listName.ItemHeight = 25;
            listName.Location = new Point(36, 49);
            listName.Name = "listName";
            listName.Size = new Size(417, 304);
            listName.TabIndex = 14;
            listName.SelectedIndexChanged += listName_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(659, 562);
            Controls.Add(listName);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(lblName);
            ForeColor = SystemColors.ActiveCaptionText;
            Location = new Point(0, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicLabel lblName;
        private AcrylicUI.Controls.AcrylicButton btnAddNew;
        private AcrylicUI.Controls.AcrylicButton btnUpdate;
        private AcrylicUI.Controls.AcrylicButton btnDelete;
        private AcrylicUI.Controls.AcrylicButton btnExit;
        private AcrylicUI.Controls.AcrylicTextBox txtScoreTotal;
        private AcrylicUI.Controls.AcrylicTextBox txtScoreCount;
        private AcrylicUI.Controls.AcrylicTextBox txtAverage;
        private AcrylicUI.Controls.AcrylicLabel lblScoreTotal;
        private AcrylicUI.Controls.AcrylicLabel lblScoreCount;
        private AcrylicUI.Controls.AcrylicLabel lblAverage;
        private ListBox listName;
    }
}
