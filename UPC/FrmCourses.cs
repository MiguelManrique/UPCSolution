using BusinessLogic.CareerService;
using BusinessLogic.CourseService;
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
    public partial class FrmCourses : Form
    {
        private ICareerService CareerService;
        private ICourseService CourseService;
        public FrmCourses()
        {
            InitializeComponent();
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {
            try
            {
                this.CareerService = new CareerService();
                this.CourseService = new CourseService();

                cbCareer.DataSource = this.CareerService.GetAllCareers();
                cbCareer.SelectedIndex = 0;

                this.LoadAllCourses();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadAllCourses()
        {
            dgvCourses.DataSource = this.CourseService.GetAllCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cours objCourse = new Cours();
                objCourse.Area = this.txtArea.Text;
                objCourse.CareerId = Convert.ToInt32(this.cbCareer.SelectedValue);
                objCourse.Credits = Convert.ToInt32(this.txtCredits.Text);
                objCourse.Name = this.txtName.Text;
                this.CourseService.InsertCourse(objCourse);
                this.LoadAllCourses();
                MessageBox.Show("The course was saved!", "Success");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cours objCourse = new Cours();
                objCourse.Id = Convert.ToInt32(this.txtId.Text);
                objCourse.Area = this.txtArea.Text;
                objCourse.CareerId = Convert.ToInt32(this.cbCareer.SelectedValue);
                objCourse.Credits = Convert.ToInt32(this.txtCredits.Text);
                objCourse.Name = this.txtName.Text;
                this.CourseService.UpdateCourse(objCourse);
                this.LoadAllCourses();
                MessageBox.Show("The course was saved!", "Success");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvCourses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Record #" + e.RowIndex + " was selected!");
            if (e.RowIndex >= 0)
            {
                int courseId = Convert.ToInt32(dgvCourses.Rows[e.RowIndex].Cells["IdColumn"].Value);
                Cours objCourse = this.CourseService.GetCourseById(courseId);
                this.txtId.Text = objCourse.Id.ToString();
                this.txtName.Text = objCourse.Name;
                this.txtArea.Text = objCourse.Area;
                this.txtCredits.Text = objCourse.Credits.ToString();
                this.cbCareer.SelectedValue = objCourse.CareerId;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count > 0)
            {
                string thisText = "this record?";
                if (dgvCourses.SelectedRows.Count > 1)
                {
                    thisText = "these records?";
                }
                if (MessageBox.Show("Are you sure you want to delete " + thisText,
                    "Confirmation", 
                    MessageBoxButtons.YesNoCancel) == 
                    System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < dgvCourses.SelectedRows.Count; i++)
                    {
                        int courseId = Convert.ToInt32(dgvCourses.SelectedRows[i].Cells["IdColumn"].Value);
                        this.CourseService.DeleteCourse(courseId);
                    }                    
                    this.LoadAllCourses();
                }
            }
        }
    }
}
