using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNA.Controller;
using NNA.Model;


namespace NNA
{
    public partial class StudentDetail : Form
    {
        clsResize _form_resize;
        string checkmssv;
        BindingSource projectList = new BindingSource();


        public StudentDetail(string mssv)
        {
            this.AutoSize = true;
            checkmssv = mssv;
            InitializeComponent();
            StudentBinding();
            _form_resize = new clsResize(this);

        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();


        }

        private void StudentDetail_Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        void StudentBinding()
        {
            DataTable student = StudentController.Instance.GetStudentDetailByMSSV(checkmssv);
            txbMSSV.DataBindings.Add(new Binding("Text", student, "sMSSV"));
            txbName.DataBindings.Add(new Binding("Text", student, "sName"));
            cbxSex.DataBindings.Add(new Binding("Text", student, "sSex"));
            dtpkBirthday.DataBindings.Add(new Binding("Text", student, "dtBirth"));
            txbPhone.DataBindings.Add(new Binding("Text", student, "sPhone"));
            txbEmail.DataBindings.Add(new Binding("Text", student, "sEmail"));
            txbFaculty.DataBindings.Add(new Binding("Text", student, "sFaculty"));
            txbYear.DataBindings.Add(new Binding("Text", student, "iYear"));

            dtgvProject.DataSource = projectList;
            projectList.DataSource = ProjectController.Instance.SearchStudentOfProject(checkmssv);
        }
    }
}
