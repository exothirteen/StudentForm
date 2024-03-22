using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using static StudentInfoForm.Form1;
using static System.Formats.Asn1.AsnWriter;

namespace StudentInfoForm
{

    public partial class Form5 : AcrylicForm
    {
        // List to store scores for the new student
        private List<int> scores = new List<int>();
        // List to store existing students
        private List<Student> students;

        // Event for notifying when a new student is added
        public event EventHandler<NewStudentEventArgs> NewStudentAdded;

        // Constructor
        public Form5(List<Student> students)
        {
            InitializeComponent();
            this.students = students;

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.IsAcrylic = true;
            this.Text = "New Student Record";
            this.BackColor = Colors.GreyBackground;
        }
        // Event arguments for new student event
        public class NewStudentEventArgs : EventArgs
        {
            public Student NewStudent { get; }

            public NewStudentEventArgs(Student newStudent)
            {
                NewStudent = newStudent;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        // Event handler for adding a score
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score))
            // Check if the score is within valid range
            {
                if (score >= 0 && score <= 100)
                {
                    scores.Add(score); // Add the score to the list
                    UpdateScoresLabel(); // Update the displayed scores
                    txtScore.Clear(); // Clear the score TextBox
                }
                else
                {
                    MessageBox.Show("Please enter a score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid score.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to update the displayed scores
        private void UpdateScoresLabel()
        {
            txtScores.Text = string.Join(", ", scores);
        }
        // Event handler for clearing scores
        private void btnClearScore_Click(object sender, EventArgs e)
        {
            scores.Clear(); // Clear the scores list
            txtScores.Clear(); // Clear the displayed score
        }

        // Event handler for the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ConfirmCancel()) // Confirm if the user wants to cancel
            this.Close(); // Close the form
        }
        // Method to confirm cancellation
        private bool ConfirmCancel()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        // Event handler for the OK button
        private void btnOK_Click(object sender, EventArgs e)
        {
            string newStudentName = NewStudentName; // Get the new student's name from the TextBox

            try
            {
                scores = GetScoresFromTextBox(txtScores); // Get the scores entered for the new student
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Score Format", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display error message for invalid score format
                return; // Return without proceeding further
            }

            Student newStudent = new Student(newStudentName); // Create a new student object
            newStudent.Scores.AddRange(scores); // Add scores to the new student

            // Invoke the event to notify listeners about the new student
            NewStudentAdded?.Invoke(this, new NewStudentEventArgs(newStudent));

            this.Close(); // Close the form
        }

        // Property to get the new student's name from the TextBox
        public string NewStudentName
        {
            get
            {
                return txtName.Text;
            }
        }

        // Method to extract scores from the TextBox
        private List<int> GetScoresFromTextBox(TextBox textBox)
        {
            List<int> scores = new List<int>();

            string[] scoreStrings = textBox.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // Iterate through each score string
            foreach (string scoreString in scoreStrings)
            {
                // Attempt to parse the score string
                if (int.TryParse(scoreString, out int score))
                {
                    scores.Add(score);// Add the parsed score to the list
                }
                else
                {
                    throw new FormatException("Invalid score format. Please enter valid integers separated by commas or spaces.");// Throw an exception for invalid score format
                }
            }

            return scores; // Return the list of scores
        }

    }
}
