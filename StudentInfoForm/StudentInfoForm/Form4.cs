using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using static StudentInfoForm.Form1;
using static System.Formats.Asn1.AsnWriter;

namespace StudentInfoForm
{
    public partial class Form4 : AcrylicForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.IsAcrylic = true;
            this.Text = "Update Records";
            this.BackColor = Colors.GreyBackground;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
