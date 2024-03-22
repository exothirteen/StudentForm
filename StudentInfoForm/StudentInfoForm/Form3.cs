using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using static StudentInfoForm.Form1;
using static System.Formats.Asn1.AsnWriter;


namespace StudentInfoForm

{
    public partial class Form3 : AcrylicForm
    {

        public TextBox NewScoreTextBox => this.txtNewScore;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.IsAcrylic = true;
            this.Text = "Add Record";
            this.BackColor = Colors.GreyBackground;

        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtAddScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void acrylicButton1_Click(object sender, EventArgs e)
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
