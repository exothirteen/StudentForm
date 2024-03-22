namespace StudentInfoForm
{
    partial class Form4
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
            txtNewScore = new AcrylicUI.Controls.AcrylicTextBox();
            lblScore = new AcrylicUI.Controls.AcrylicLabel();
            btnUpdate = new AcrylicUI.Controls.AcrylicButton();
            btnCancel = new AcrylicUI.Controls.AcrylicButton();
            SuspendLayout();
            // 
            // txtNewScore
            // 
            txtNewScore.BackColor = Color.FromArgb(31, 31, 31);
            txtNewScore.BorderStyle = BorderStyle.FixedSingle;
            txtNewScore.ForeColor = Color.FromArgb(245, 245, 245);
            txtNewScore.Location = new Point(135, 62);
            txtNewScore.Name = "txtNewScore";
            txtNewScore.Size = new Size(283, 31);
            txtNewScore.TabIndex = 2;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = Color.FromArgb(192, 192, 192);
            lblScore.Location = new Point(50, 64);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(60, 25);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score:";
            // 
            // btnUpdate
            // 
            btnUpdate.Default = false;
            btnUpdate.Image = null;
            btnUpdate.ImagePadding = 244;
            btnUpdate.Location = new Point(135, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(5);
            btnUpdate.Size = new Size(111, 48);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Default = false;
            btnCancel.Image = null;
            btnCancel.ImagePadding = 244;
            btnCancel.Location = new Point(293, 135);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(115, 48);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(489, 207);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblScore);
            Controls.Add(txtNewScore);
            Location = new Point(0, 0);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal AcrylicUI.Controls.AcrylicTextBox txtNewScore;
        private AcrylicUI.Controls.AcrylicLabel lblScore;
        private AcrylicUI.Controls.AcrylicButton btnUpdate;
        private AcrylicUI.Controls.AcrylicButton btnCancel;
    }
}