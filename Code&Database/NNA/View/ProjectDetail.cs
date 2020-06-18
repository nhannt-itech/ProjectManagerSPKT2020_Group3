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


namespace NNA.View
{
    public partial class ProjectDetail : Form
    {
        clsResize _form_resize;
        string checkid;
        BindingSource studentList = new BindingSource();


        public ProjectDetail(string id)
        {
            checkid = id;
            InitializeComponent();
            ProjectBinding();
            _form_resize = new clsResize(this);
            this.Load += ProjectDetail_Load;
            this.Resize += ProjectDetail_Resize;
        }


        void ProjectBinding()
        {
            DataTable project = ProjectController.Instance.GetProjectDetailByID(checkid);
            txbID.DataBindings.Add(new Binding("Text", project, "sID"));
            txbName.DataBindings.Add(new Binding("Text", project, "sName"));
            txbCategory.DataBindings.Add(new Binding("Text", project, "sCategory"));
            txbSubject.DataBindings.Add(new Binding("Text", project, "sSubject"));
            txbGrade.DataBindings.Add(new Binding("Text", project, "iGrade"));
            txbTeacher.DataBindings.Add(new Binding("Text", project, "teacher_ID"));
            dtFromDate.DataBindings.Add(new Binding("Text", project, "dtFromDate"));
            dtToDate.DataBindings.Add(new Binding("Text", project, "dtToDate"));
            txbDescription.DataBindings.Add(new Binding("Text", project, "sDescription"));
            txbLink.DataBindings.Add(new Binding("Text", project, "sLink"));


            int iTime;
            DataTable proComment = ProjectController.Instance.GetCommentProjectByID(checkid);
            try
            {
                iTime = proComment.Rows[0].Field<int>("iTime");
            }
            catch
            {
                iTime = 0;
            }

            if (iTime == 0)
            {
                cbProgress.DataSource = new List<string> { "Đề tài chưa được báo cáo" };
                cbProgress.Enabled = false;
            }
            if (iTime == 1)
            {
                cbProgress.DataSource = new List<string> { "Chọn","Lần 1"};
                pgbProgress.Value = 30;
            }
            if (iTime == 2)
            {
                cbProgress.DataSource = new List<string> { "Chọn", "Lần 1", "Lần 2" };
                pgbProgress.Value = 60;
            }
            if (iTime == 3)
            {
                cbProgress.DataSource = new List<string> { "Chọn", "Lần 1", "Lần 2", "Lần 3" };
                pgbProgress.Value = 100;

            }

            dtgvStudent.DataSource = studentList;
            studentList.DataSource = StudentController.Instance.SearchStudentOfProject(checkid);

        }


        

        private void ProjectDetail_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();

        }

        private void ProjectDetail_Resize(object sender, EventArgs e)
        {
            _form_resize._resize();

        }

        private void CbProgress_TextChanged(object sender, EventArgs e)
        {
            DataTable proComment = ProjectController.Instance.GetCommentProjectByID(checkid);
            if (this.cbProgress.Text == "Lần 1")
            {
                this.txbProgress.Text = proComment.Rows[0].Field<string>("sComment1");
            }
            if (this.cbProgress.Text == "Lần 2")
            {
                this.txbProgress.Text = proComment.Rows[0].Field<string>("sComment2");
            }
            if (this.cbProgress.Text == "Lần 3")
            {
                this.txbProgress.Text = proComment.Rows[0].Field<string>("sComment3");
            }
            if (this.cbProgress.Text == "Chọn")
            {
                this.txbProgress.Text = " ";
            }

        }
    }
}
