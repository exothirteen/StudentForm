namespace StudentInfoForm
{
    partial class Form3
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
            lblScore = new AcrylicUI.Controls.AcrylicLabel();
            txtNewScore = new AcrylicUI.Controls.AcrylicTextBox();
            btnAdd = new AcrylicUI.Controls.AcrylicButton();
            btnCancel = new AcrylicUI.Controls.AcrylicButton();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = Color.FromArgb(192, 192, 192);
            lblScore.Location = new Point(50, 64);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(60, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            // 
            // txtNewScore
            // 
            txtNewScore.BackColor = Color.FromArgb(31, 31, 31);
            txtNewScore.BorderStyle = BorderStyle.FixedSingle;
            txtNewScore.ForeColor = Color.FromArgb(245, 245, 245);
            txtNewScore.Location = new Point(135, 62);
            txtNewScore.Name = "txtNewScore";
            txtNewScore.Size = new Size(283, 31);
            txtNewScore.TabIndex = 1;
            txtNewScore.TextChanged += txtAddScore_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Default = false;
            btnAdd.Image = null;
            btnAdd.ImagePadding = 109;
            btnAdd.Location = new Point(135, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(5);
            btnAdd.Size = new Size(111, 48);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += acrylicButton1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Default = false;
            btnCancel.Image = null;
            btnCancel.ImagePadding = 109;
            btnCancel.Location = new Point(293, 135);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(115, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(489, 207);
            Controls.Add(btnAdd);
            Controls.Add(txtNewScore);
            Controls.Add(lblScore);
            Controls.Add(btnCancel);
            Location = new Point(0, 0);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicLabel lblScore;
        private AcrylicUI.Controls.AcrylicTextBox txtAddScore;
        private AcrylicUI.Controls.AcrylicButton btnAdd;
        private AcrylicUI.Controls.AcrylicButton btnCancel;
        private AcrylicUI.Controls.AcrylicTextBox Textbox;
        internal AcrylicUI.Controls.AcrylicTextBox txtNewScore;
    }
}