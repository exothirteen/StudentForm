namespace StudentInfoForm
{
    partial class Form5
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
            lblName = new AcrylicUI.Controls.AcrylicLabel();
            lblScore = new AcrylicUI.Controls.AcrylicLabel();
            lblScores = new AcrylicUI.Controls.AcrylicLabel();
            txtName = new AcrylicUI.Controls.AcrylicTextBox();
            txtScore = new AcrylicUI.Controls.AcrylicTextBox();
            txtScores = new AcrylicUI.Controls.AcrylicTextBox();
            btnAddScore = new AcrylicUI.Controls.AcrylicButton();
            btnOK = new AcrylicUI.Controls.AcrylicButton();
            btnCancel = new AcrylicUI.Controls.AcrylicButton();
            btnClearScore = new AcrylicUI.Controls.AcrylicButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(192, 192, 192);
            lblName.Location = new Point(85, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = Color.FromArgb(192, 192, 192);
            lblScore.Location = new Point(88, 109);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(60, 25);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score:";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.ForeColor = Color.FromArgb(192, 192, 192);
            lblScores.Location = new Point(80, 164);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(68, 25);
            lblScores.TabIndex = 2;
            lblScores.Text = "Scores:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(31, 31, 31);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.FromArgb(245, 245, 245);
            txtName.Location = new Point(190, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 31);
            txtName.TabIndex = 3;
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.FromArgb(31, 31, 31);
            txtScore.BorderStyle = BorderStyle.FixedSingle;
            txtScore.ForeColor = Color.FromArgb(245, 245, 245);
            txtScore.Location = new Point(190, 107);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(163, 31);
            txtScore.TabIndex = 4;
            // 
            // txtScores
            // 
            txtScores.BackColor = Color.FromArgb(31, 31, 31);
            txtScores.BorderStyle = BorderStyle.FixedSingle;
            txtScores.ForeColor = Color.FromArgb(245, 245, 245);
            txtScores.Location = new Point(190, 162);
            txtScores.Name = "txtScores";
            txtScores.ReadOnly = true;
            txtScores.Size = new Size(310, 31);
            txtScores.TabIndex = 5;
            // 
            // btnAddScore
            // 
            btnAddScore.Default = false;
            btnAddScore.Image = null;
            btnAddScore.ImagePadding = 109;
            btnAddScore.Location = new Point(359, 105);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Padding = new Padding(5);
            btnAddScore.Size = new Size(141, 33);
            btnAddScore.TabIndex = 6;
            btnAddScore.Text = "Add Score";
            btnAddScore.UseVisualStyleBackColor = false;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // btnOK
            // 
            btnOK.Default = false;
            btnOK.Image = null;
            btnOK.ImagePadding = 163;
            btnOK.Location = new Point(190, 275);
            btnOK.Name = "btnOK";
            btnOK.Padding = new Padding(5);
            btnOK.Size = new Size(141, 33);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Default = false;
            btnCancel.Image = null;
            btnCancel.ImagePadding = 163;
            btnCancel.Location = new Point(359, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(141, 33);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClearScore
            // 
            btnClearScore.Default = false;
            btnClearScore.Image = null;
            btnClearScore.ImagePadding = 163;
            btnClearScore.Location = new Point(359, 220);
            btnClearScore.Name = "btnClearScore";
            btnClearScore.Padding = new Padding(5);
            btnClearScore.Size = new Size(141, 33);
            btnClearScore.TabIndex = 9;
            btnClearScore.Text = "Clear Scores";
            btnClearScore.UseVisualStyleBackColor = false;
            btnClearScore.Click += btnClearScore_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(607, 342);
            Controls.Add(btnClearScore);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(btnAddScore);
            Controls.Add(txtScores);
            Controls.Add(txtScore);
            Controls.Add(txtName);
            Controls.Add(lblScores);
            Controls.Add(lblScore);
            Controls.Add(lblName);
            Location = new Point(0, 0);
            Name = "Form5";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicLabel lblName;
        private AcrylicUI.Controls.AcrylicLabel lblScore;
        private AcrylicUI.Controls.AcrylicLabel lblScores;
        private AcrylicUI.Controls.AcrylicTextBox txtName;
        private AcrylicUI.Controls.AcrylicTextBox txtScore;
        private AcrylicUI.Controls.AcrylicTextBox txtScores;
        private AcrylicUI.Controls.AcrylicButton btnAddScore;
        private AcrylicUI.Controls.AcrylicButton btnOK;
        private AcrylicUI.Controls.AcrylicButton btnCancel;
        private AcrylicUI.Controls.AcrylicButton btnClearScore;
    }
}