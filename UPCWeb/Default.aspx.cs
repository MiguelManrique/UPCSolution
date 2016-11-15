using BusinessLogic.CareerService;
using BusinessLogic.CourseService;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) //Es impotante
        {
            ICareerService careerService = new CareerService();
            List<Career> careers = careerService.GetAllCareers();

            Career dummycareer = new Career();
            dummycareer.Id = 0;
            dummycareer.Name = "Select a Career...";
            careers.Insert(0, dummycareer);

            ddlCareers.DataSource = careers;
            ddlCareers.DataBind();
        }
        this.LoadCourses();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Cours objCourse = new Cours();

        int courseId = 0;
        if(this.hfCourseId.Value != string.Empty)
        {
            courseId = Convert.ToInt32(this.hfCourseId.Value);
        }
        objCourse.Id = courseId;
        objCourse.Area = this.txtArea.Text;
        objCourse.CareerId = Convert.ToInt32(this.ddlCareers.SelectedValue);
        objCourse.Credits = Convert.ToInt32(this.txtCredit.Text);
        objCourse.Name = txtName.Text;
        ICourseService courseService = new CourseService();

        if (objCourse.Id == 0)
        {
            courseService.InsertCourse(objCourse);
            this.hfCourseId.Value = objCourse.Id.ToString();
        }
        else {
            courseService.UpdateCourse(objCourse);
        }

        this.LoadCourses();
    }

    private void LoadCourses()
    {        
        ICourseService courseService = new CourseService();
        List<Cours> courses = courseService.GetAllCourses();
        this.dgCourses.DataSource = courses;
        this.dgCourses.DataBind();
    }
    protected void dgCourses_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        int courseId = Convert.ToInt32(e.Item.Cells[0].Text);
        ICourseService courseService = new CourseService();
        switch(e.CommandName.ToLower())
        {
            case "delete":
            courseService.DeleteCourse(courseId);
            this.LoadCourses();
            break;

            case "showdetails":
            Cours objCourse = courseService.GetCourseById(courseId);
            this.hfCourseId.Value = objCourse.Id.ToString();
            this.txtArea.Text = objCourse.Area;
            this.txtCredit.Text = objCourse.Credits.ToString();
            this.txtName.Text = objCourse.Name;
            this.ddlCareers.SelectedValue = objCourse.CareerId.ToString();             
            break;

        }
        
    }
    protected void btnClearFields_Click(object sender, EventArgs e)
    {
        this.txtArea.Text =
        this.txtCredit.Text =
        this.txtName.Text = string.Empty;
        this.ddlCareers.SelectedIndex = 0;
        this.hfCourseId.Value = "0";
    }
}