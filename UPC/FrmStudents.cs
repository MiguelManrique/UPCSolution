using BusinessLogic.StudentService;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPC
{
    public partial class FrmStudents : Form
    {
        private IStudentService studentService = new StudentService();

        public FrmStudents()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {                   
                    Student newStudent = new Student();
                    newStudent.Age = Convert.ToInt32(this.txtAge.Text);
                    newStudent.Code = this.txtCode.Text;
                    newStudent.GradeAverage = Convert.ToDecimal(this.txtGradeAverage.Text);
                    newStudent.Name = this.txtName.Text;

                    studentService.InsertStudent(newStudent);

                    this.UpdateStudentList();

                    MessageBox.Show("Student saved correctly!", "Success");
                }
            }
            catch (Exception ex)
            {
                //Send error log to development team
                
                //Sened error message to user
                MessageBox.Show("An error ocurred. Please try later.", "Error");
                throw (ex);
            }
        }

        public bool ValidateFields()
        {
            bool result = true;
            string errorMessage = string.Empty;
            //Validate age
            int age;
            if(!int.TryParse(this.txtAge.Text, out age))
            {
                errorMessage += "Enter a valid age" + System.Environment.NewLine;
                result = false;                
            }

            //Validate Code
            if(string.IsNullOrEmpty(this.txtCode.Text))
            {
                errorMessage += "Enter a valid code" + System.Environment.NewLine;
                result = false; 
            }

            //Validate Name
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                errorMessage += "Enter a valid name" + System.Environment.NewLine;
                result = false; 
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error");
            }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    Student objStudent = new Student();
                    objStudent.Id = Convert.ToInt32(this.txtId.Text);
                    objStudent.Age = Convert.ToInt32(this.txtAge.Text);
                    objStudent.Code = this.txtCode.Text;
                    objStudent.GradeAverage = Convert.ToDecimal(this.txtGradeAverage.Text);
                    objStudent.Name = this.txtName.Text;

                    studentService.UpdateStudent(objStudent);

                    this.UpdateStudentList();

                    MessageBox.Show("Student updated correctly!", "Success");
                }
            }
            catch (Exception ex)
            {
                //Send error log to development team

                //Sened error message to user
                MessageBox.Show("An error ocurred. Please try later.", "Error");
                throw (ex);
            }
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            this.UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            List<Student> studentList = studentService.GetAllStudents();
            dgvStudents.DataSource = studentList;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("A cell vas clicked!");
        }
    }
}
