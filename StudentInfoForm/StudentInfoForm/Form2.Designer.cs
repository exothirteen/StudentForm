namespace StudentInfoForm
{
    partial class Form2
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
            txtStudentName = new AcrylicUI.Controls.AcrylicTextBox();
            lblScores = new AcrylicUI.Controls.AcrylicLabel();
            listStudentMarks = new ListBox();
            btnAdd = new AcrylicUI.Controls.AcrylicButton();
            btnUpdate = new AcrylicUI.Controls.AcrylicButton();
            btnRemove = new AcrylicUI.Controls.AcrylicButton();
            btnClear = new AcrylicUI.Controls.AcrylicButton();
            btnOk = new AcrylicUI.Controls.AcrylicButton();
            btnCancel = new AcrylicUI.Controls.AcrylicButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(192, 192, 192);
            lblName.Location = new Point(39, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.FromArgb(31, 31, 31);
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentName.ForeColor = Color.FromArgb(245, 245, 245);
            txtStudentName.Location = new Point(108, 27);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(453, 31);
            txtStudentName.TabIndex = 1;
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.ForeColor = Color.FromArgb(192, 192, 192);
            lblScores.Location = new Point(39, 78);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(68, 25);
            lblScores.TabIndex = 2;
            lblScores.Text = "Scores:";
            // 
            // listStudentMarks
            // 
            listStudentMarks.BackColor = Color.FromArgb(64, 64, 64);
            listStudentMarks.ForeColor = SystemColors.Window;
            listStudentMarks.FormattingEnabled = true;
            listStudentMarks.ItemHeight = 25;
            listStudentMarks.Location = new Point(108, 78);
            listStudentMarks.Name = "listStudentMarks";
            listStudentMarks.Size = new Size(304, 279);
            listStudentMarks.TabIndex = 3;
            listStudentMarks.SelectedIndexChanged += listStudentMarks_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Default = false;
            btnAdd.Image = null;
            btnAdd.ImagePadding = 109;
            btnAdd.Location = new Point(418, 78);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(5);
            btnAdd.Size = new Size(143, 48);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Default = false;
            btnUpdate.Image = null;
            btnUpdate.ImagePadding = 163;
            btnUpdate.Location = new Point(418, 149);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(5);
            btnUpdate.Size = new Size(143, 48);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Default = false;
            btnRemove.Image = null;
            btnRemove.ImagePadding = 163;
            btnRemove.Location = new Point(418, 220);
            btnRemove.Name = "btnRemove";
            btnRemove.Padding = new Padding(5);
            btnRemove.Size = new Size(143, 48);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += acrylicButton3_Click;
            // 
            // btnClear
            // 
            btnClear.Default = false;
            btnClear.Image = null;
            btnClear.ImagePadding = 163;
            btnClear.Location = new Point(418, 298);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(5);
            btnClear.Size = new Size(143, 48);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear Scores";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnOk
            // 
            btnOk.Default = false;
            btnOk.Image = null;
            btnOk.ImagePadding = 163;
            btnOk.Location = new Point(236, 385);
            btnOk.Name = "btnOk";
            btnOk.Padding = new Padding(5);
            btnOk.Size = new Size(143, 48);
            btnOk.TabIndex = 8;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Default = false;
            btnCancel.Image = null;
            btnCancel.ImagePadding = 163;
            btnCancel.Location = new Point(418, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(143, 48);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(590, 470);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(listStudentMarks);
            Controls.Add(lblScores);
            Controls.Add(txtStudentName);
            Controls.Add(lblName);
            Location = new Point(0, 0);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicLabel lblName;
        private AcrylicUI.Controls.AcrylicTextBox txtStudentName;
        private AcrylicUI.Controls.AcrylicLabel lblScores;
        private ListBox listStudentMarks;
        private AcrylicUI.Controls.AcrylicButton btnAdd;
        private AcrylicUI.Controls.AcrylicButton btnUpdate;
        private AcrylicUI.Controls.AcrylicButton btnRemove;
        private AcrylicUI.Controls.AcrylicButton btnClear;
        private AcrylicUI.Controls.AcrylicButton btnOk;
        private AcrylicUI.Controls.AcrylicButton btnCancel;
    }
}