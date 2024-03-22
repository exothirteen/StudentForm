using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;


namespace StudentInfoForm
{
    public partial class Form1 : AcrylicForm
    {   
        // List to store student objects
        private List<Student> students;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Setting form properties
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.IsAcrylic = true;
            this.BackColor = Colors.GreyBackground;

            // Initialize list of students and add sample data
            this.Text = "Student Scores";
            students = new List<Student>();
            AddSampleStudents();
            RefreshListBox(); // Populate list box with student information
        }

        // Method to add sample students
        private void AddSampleStudents()
        {
            // Adding sample students with their scores
            Student johnDoe = new Student("John Doe");
            johnDoe.Scores.AddRange(new int[] { 1, 1, 1, 1, 1, 1, 1 }); 
            students.Add(johnDoe);

            Student janeSmith = new Student("Jane Smith");
            janeSmith.Scores.AddRange(new int[] { 92, 88, 95 }); 
            students.Add(janeSmith);

            Student aliceJohnson = new Student("Alice Johnson");
            aliceJohnson.Scores.AddRange(new int[] { 80, 75, 82 }); 
            students.Add(aliceJohnson);
        }

        // Method to refresh the list box with updated student information
        public void RefreshListBox()
        {
            listName.Items.Clear();
            foreach (Student student in students)
            {
                string studentInfo = $"{student.Name} | ";
                foreach (int score in student.Scores)
                {
                    studentInfo += $"{score} | ";
                }
                listName.Items.Add(studentInfo.TrimEnd(' ', '|')); 
            }
        }

        // Event handler for exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ConfirmCancel()) // Confirm if the user wants to exit
                this.Close(); // Close the form
        }

        // Method to confirm exit action
        private bool ConfirmCancel()
        {
            DialogResult result = MessageBox.Show("Do you really want to exit this program?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        // Event handler for add new student button click
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var addStudentForm = new Form5(students)) // Open a new form to add a student
            {
                addStudentForm.NewStudentAdded += (s, args) =>
                {
                    Student newStudent = args.NewStudent;

                    students.Add(newStudent);// Add the new student to the list

                    RefreshListBox();// Refresh the list box to display the new student
                };

                var result = addStudentForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshListBox();
                }
            }
        }

        // Event handler for update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listName.SelectedIndex != -1) // Check if a student is selected
            {
                Student selectedStudent = students[listName.SelectedIndex];

                // Open a form to update the selected student's information
                Form2 form2 = new Form2(selectedStudent.Name, selectedStudent.Scores);
                form2.FormClosing += (s, args) =>
                {
                    if (form2.DialogResult == DialogResult.OK)
                    {
                        RefreshListBox();// Refresh the list box if the update is successful
                    }
                };

                form2.ShowDialog();
            }
        }

        // Event handler for delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listName.SelectedIndex != -1) // Check if a student is selected
            {
                int selectedIndex = listName.SelectedIndex;

                students.RemoveAt(selectedIndex);// Remove the selected student from the list

                RefreshListBox();// Refresh the list box to reflect the deletion

                ClearStudentInfoTextBoxes();// Clear the text boxes displaying student information
            }
        }

        // Method to clear text boxes displaying student information
        private void ClearStudentInfoTextBoxes()
        {
            txtScoreTotal.Clear();
            txtScoreCount.Clear();
            txtAverage.Clear();
        }

        private void txtScoreTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScoreCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {

        }
        // Student class to store student information
        public class Student
        {
            public string Name { get; set; }
            public List<int> Scores { get; set; }

            public int TotalScore => Scores.Sum();
            public int ScoreCount => Scores.Count;
            public double AverageScore => Scores.Count > 0 ? Scores.Average() : 0;

            public Student(string name)
            {
                Name = name;
                Scores = new List<int>();
            }
        }

        // Event handler for selected index change in the list box
        private void listName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listName.SelectedIndex != -1)
            {
                Student selectedStudent = students[listName.SelectedIndex];

                txtScoreTotal.Text = selectedStudent.TotalScore.ToString();
                txtScoreCount.Text = selectedStudent.ScoreCount.ToString();
                txtAverage.Text = selectedStudent.AverageScore.ToString("0.00"); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
