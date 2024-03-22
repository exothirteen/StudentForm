using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using static StudentInfoForm.Form1;
using static System.Formats.Asn1.AsnWriter;

namespace StudentInfoForm
{
    // Partial class for updating student records
    public partial class Form2 : AcrylicForm
    {
        private List<int> originalScores; // Store original scores before any modificationsx
        public string StudentName { get; set; }
        public List<int> Scores { get; set; }
        public Form2(string studentName, List<int> scores)
        {
            InitializeComponent();

            // Setting form properties
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.IsAcrylic = true;
            this.BackColor = Colors.GreyBackground;
            this.Text = "Update Records";

            // Store original scores
            originalScores = new List<int>(scores);

            // Initialize student name and scores
            StudentName = studentName;
            Scores = scores;

            // Populate student information
            PopulateStudentInfo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listStudentMarks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Method to populate student information in the form   
        private void PopulateStudentInfo()
        {
            txtStudentName.Text = StudentName;

            // Add each score to the list box
            foreach (int score in Scores)
            {
                listStudentMarks.Items.Add(score);
            }
        }

        // Event handler for the button to remove a score
        private void acrylicButton3_Click(object sender, EventArgs e)
        {
            // Check if a score is selected
            if (listStudentMarks.SelectedIndex != -1)
            {
                Scores.RemoveAt(listStudentMarks.SelectedIndex); // Remove the selected score

                RefreshScoreList(); // Refresh the list of scores
            }
        }

        // Method to refresh the list of scores
        private void RefreshScoreList()
        {
            listStudentMarks.Items.Clear();
            foreach (int score in Scores)
            {
                listStudentMarks.Items.Add(score);
            }
        }

        // Event handler for the OK button
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;// Set dialog result to OK
            this.Close();// Close the form
        }

        // Event handler for the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check if any changes were made to the scores
            if (!Scores.SequenceEqual(originalScores))
            {
                DialogResult result = MessageBox.Show("Do you want to discard changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Restore original scores
                    Scores.Clear();
                    Scores.AddRange(originalScores);

                    this.DialogResult = DialogResult.Cancel; // Set dialog result to Cancel
                    this.Close();// Close the form
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;// Set dialog result to Cancel
                this.Close();// Close the form
            }
        }

        // Event handler for the Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            Scores.Clear(); // Clear all scores
            RefreshScoreList(); // Refresh the list of scores
        }

        // Event handler for the Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open form to add a new score
            using (var addScoreForm = new Form3())
            {
                var result = addScoreForm.ShowDialog(); // Show the form as a dialog

                if (result == DialogResult.OK)
                {
                    // Attempt to parse the entered score
                    if (int.TryParse(addScoreForm.txtNewScore.Text, out int newScore))
                    {
                        // Check if the score is within valid range
                        if (newScore >= 0 && newScore <= 100)
                        {
                            Scores.Add(newScore);// Add the new score

                            RefreshScoreList(); // Refresh the list of scores 
                        }
                        else
                        {
                            MessageBox.Show("Please enter a score between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid score. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Event handler for the Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if a score is selected
            if (listStudentMarks.SelectedIndex != -1)
            {
                // Open form to update the selected score
                using (var updateScoreForm = new Form4())
                {
                    var result = updateScoreForm.ShowDialog(); // Show the form as a dialog

                    if (result == DialogResult.OK)
                    {
                        // Attempt to parse the entered score
                        if (int.TryParse(updateScoreForm.txtNewScore.Text, out int newScore))
                        {
                            // Check if the score is within valid range
                            if (newScore >= 0 && newScore <= 100)
                            {
                                Scores[listStudentMarks.SelectedIndex] = newScore; // Update the selected score


                                RefreshScoreList(); // Refresh the list of scores
                            }
                            else
                            {
                                MessageBox.Show("Please enter a score between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid score. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a score to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
