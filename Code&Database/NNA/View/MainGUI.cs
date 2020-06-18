using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNA.Model;
using NNA.Controller;
using System.Windows.Forms.DataVisualization.Charting;

namespace NNA.View
{
    public partial class MainGUI : Form
    {
        string checkMSSV;
        string checkMGV;
        string checkID;
        ComboBox cbbProjectResult;
        ComboBox cbbProjectCategory;

        clsResize _form_resize;
        BindingSource studentList = new BindingSource();
        BindingSource teacherList = new BindingSource();
        BindingSource projectList = new BindingSource();
        public MainGUI()
        {


            InitializeComponent();

            dtgvStudent.DataSource = studentList;
            dtgvTeacher.DataSource = teacherList;
            dtgvProject.DataSource = projectList;
            LoadProjects();
            LoadStudents();
            LoadTeachers();
            LoadChartProject();

            tabMain.Appearance = TabAppearance.FlatButtons;
            tabMain.ItemSize = new Size(0, 1);
            tabMain.SizeMode = TabSizeMode.Fixed;

            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }


        // Công Cụ Search
        #region NguyenNhan 
        public void LoadProjects()
        {
            projectList.DataSource = ProjectController.Instance.GetListProject();
        }

        public void LoadChartProject()
        {
            chartALL.DataSource = ProjectController.Instance.GetChartProject();
            chartALL.Series["chartALL"].XValueMember = "sResult";
            chartALL.Series["chartALL"].YValueMembers = "iGrade";
            chartALL.Titles.Clear();
            chartALL.Titles.Add("Tỉ lệ đề tài");

            chartALL.Series[0].ChartType = SeriesChartType.Pie;

        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void BtnSearchStudent_Click(object sender, EventArgs e)
        {
            dtgvStudent.DataSource = studentList;
            studentList.DataSource = StudentController.Instance.SearchStudent(this.txbSearchStudent.Text.Trim(), this.cbSearchStudent.Text.Trim());

        }

        private void BtnSearchTeacher_Click(object sender, EventArgs e)
        {
            dtgvTeacher.DataSource = teacherList;
            teacherList.DataSource = TeacherController.Instance.SearchTeacher(this.txbSearchTeacher.Text.Trim(), this.cbSearchTeacher.Text.Trim());
        }

        private void BtnSearchProject_Click(object sender, EventArgs e)
        {
            dtgvProject.DataSource = projectList;
            projectList.DataSource = ProjectController.Instance.SearchProject(this.txbSearchProject.Text.Trim(), this.cbSearchProject.Text.Trim());
        }


        private void TxbSearchProject_Click(object sender, EventArgs e)
        {
            if (this.cbSearchProject.Text == "Kết Quả")
            {
                cbbProjectResult = new ComboBox();
                cbbProjectResult.Visible = true;
                Rectangle rect = this.txbSearchProject.DisplayRectangle;
                cbbProjectResult.Location = new Point(rect.X, rect.Y);
                cbbProjectResult.Size = new Size(rect.Width, rect.Height);
                cbbProjectResult.Items.Add("Đậu");
                cbbProjectResult.Items.Add("Rớt");
                cbbProjectResult.Items.Add("Đang Thực Hiện");
                cbbProjectResult.DropDownStyle = ComboBoxStyle.DropDown;
                cbbProjectResult.Text = "Ấn để chọn";

                cbbProjectResult.DropDownClosed += CbbProjectResult_DropDownClosed;
                cbbProjectResult.SelectionChangeCommitted += CbbProjectResult_SelectionChangeCommitted;

                this.txbSearchProject.Controls.Add(cbbProjectResult);
            }
            if (this.cbSearchProject.Text == "Loại Đề Tài")
            {
                cbbProjectCategory = new ComboBox();
                cbbProjectCategory.Visible = true;
                Rectangle rect = this.txbSearchProject.DisplayRectangle;
                cbbProjectCategory.Location = new Point(rect.X, rect.Y);
                cbbProjectCategory.Size = new Size(rect.Width, rect.Height);
                cbbProjectCategory.Items.Add("Đồ Án Môn Học");
                cbbProjectCategory.Items.Add("Tiểu Luận Chuyên Ngành");
                cbbProjectCategory.Items.Add("Đồ Án Tốt Nghiệp");
                cbbProjectCategory.DropDownStyle = ComboBoxStyle.DropDown;
                cbbProjectCategory.Text = "Ấn để chọn";

                cbbProjectCategory.DropDownClosed += CbbProjectCategory_DropDownClosed;
                cbbProjectCategory.SelectionChangeCommitted += CbbProjectCategory_SelectionChangeCommitted;

                this.txbSearchProject.Controls.Add(cbbProjectCategory);
            }
            if (this.cbSearchProject.Text == "Tất Cả")
                this.txbSearchProject.ReadOnly = true;
            else this.txbSearchProject.ReadOnly = false;
        }
        private void TxbSearchStudent_Click(object sender, EventArgs e)
        {
            if (this.cbSearchStudent.Text == "Tất Cả")
                this.txbSearchStudent.ReadOnly = true;
            else this.txbSearchStudent.ReadOnly = false;
        }

        private void TxbSearchTeacher_Click(object sender, EventArgs e)
        {
            if (this.cbSearchTeacher.Text == "Tất Cả")
                this.txbSearchTeacher.ReadOnly = true;
            else this.txbSearchTeacher.ReadOnly = false;
        }
        private void CbbProjectCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txbSearchProject.Text = cbbProjectCategory.SelectedItem.ToString();
        }

        private void CbbProjectCategory_DropDownClosed(object sender, EventArgs e)
        {
            cbbProjectCategory.Visible = false;
            cbbProjectCategory.Dispose();
        }

        private void CbbProjectResult_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txbSearchProject.Text = cbbProjectResult.SelectedItem.ToString();
        }

        private void CbbProjectResult_DropDownClosed(object sender, EventArgs e)
        {
            cbbProjectResult.Visible = false;
            cbbProjectResult.Dispose();
        }

        

        private void DtgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            else if (dtgvTeacher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvTeacher.CurrentRow.Selected = true;
                checkMGV = dtgvTeacher.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();//Fix Một xíu cho bản thân
            }
        }
        private void DtgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            else if (dtgvProject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvProject.CurrentRow.Selected = true;
                checkID = dtgvProject.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();//Fix Một xíu cho bản thân
            }
        }
        private void BtnDeleteProject_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvProject.SelectedRows.Count == 0)
            {
                error.SetError(btnDeleteProject, "Vui lòng chọn đề tài bạn muốn xóa");
                return;
            }

            ProjectController.Instance.DeleteProject(this.checkID);
            dtgvProject.DataSource = projectList;
            projectList.DataSource = ProjectController.Instance.ShowProject();
        }
        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvStudent.SelectedRows.Count == 0)
            {
                error.SetError(btnDeleteStudent, "Vui lòng chọn sinh viên bạn muốn xóa");
                return;
            }

            StudentController.Instance.DeleteStudent(this.checkMSSV);
            dtgvStudent.DataSource = studentList;
            studentList.DataSource = StudentController.Instance.ShowStudent();
        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvTeacher.SelectedRows.Count == 0)
            {
                error.SetError(btnDeleteTeacher, "Vui lòng chọn giáo viên bạn muốn xóa");
                return;
            }

            TeacherController.Instance.DeleteTeacher(this.checkMGV);
            dtgvTeacher.DataSource = teacherList;
            teacherList.DataSource = TeacherController.Instance.ShowTeacher();
        }


        #endregion


        #region LuongAnh
        public void LoadTeachers()
        {
            teacherList.DataSource = TeacherController.Instance.GetListTeacher();
        }
        #endregion



        #region TruongNguyen

        public void LoadStudents()
        {
            studentList.DataSource = StudentController.Instance.GetListStudent();
        }

        private void DtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0 || e.ColumnIndex<0)
            {
                return;
            }
            else if (dtgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvStudent.CurrentRow.Selected = true;
                
                checkMSSV = dtgvStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();//Fix Một xíu cho bản thân
            }
        }

        
        #endregion


        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(0);
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(1);

        }
        private void BtnProject_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(3);
        }

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(2);
        }

        private void BtnProject_Click_1(object sender, EventArgs e)
        {
            tabMain.SelectTab(3);
        }
        private void BtnChart_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(4);

        }



        private void BtnAddStudent_Click(object sender, EventArgs e)
        {

            StudentAddUpdate form = new StudentAddUpdate(null); // loi thi them null
            form.UpdateOrAdd("Add");
            form.ShowDialog();
            dtgvStudent.DataSource = studentList;
            LoadStudents();
        }
        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherAddUpdate form = new TeacherAddUpdate(null);
            form.UpdateOrAdd("Add");
            form.ShowDialog();
            dtgvTeacher.DataSource = teacherList;
            LoadTeachers();
        }
        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            ProjectAddUpdate form = new ProjectAddUpdate(null);
            form.UpdateOrAdd("Add");
            form.ShowDialog();
            dtgvProject.DataSource = projectList;
            LoadProjects();
        }

        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvStudent.SelectedRows.Count == 0)
            {
                error.SetError(btnUpdateStudent, "Vui lòng chọn sinh viên");
                return;
            }
            StudentAddUpdate form = new StudentAddUpdate(checkMSSV);
            form.UpdateOrAdd("Update");
            form.ShowDialog();
        }

        

        private void BtnUpdateTeacher_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvTeacher.SelectedRows.Count == 0)
            {
                error.SetError(btnUpdateTeacher, "Vui lòng chọn giáo viên");
                return;
            }
            TeacherAddUpdate form = new TeacherAddUpdate(checkMGV);
            form.UpdateOrAdd("Update");
            form.ShowDialog();
        }

        private void BtnDetailTeacher_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvTeacher.SelectedRows.Count == 0)
            {
                error.SetError(btnDetailTeacher, "Vui lòng chọn giáo viên");
                return;
            }
            TeacherDetail form = new TeacherDetail(checkMGV);
            form.ShowDialog();
        }

        private void BtnDetailStudent_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvStudent.SelectedRows.Count == 0)
            {
                error.SetError(btnDetailStudent, "Vui lòng chọn sinh viên");
                return;
            }
            StudentDetail form = new StudentDetail(checkMSSV);
            form.ShowDialog();
        }

        

        

        private void BtnUpdateProject_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (dtgvProject.SelectedRows.Count == 0)
            {
                error.SetError(btnUpdateProject, "Vui lòng chọn đề tài");
                return;
            }
            ProjectAddUpdate form = new ProjectAddUpdate(checkID);
            form.UpdateOrAdd("Update");
            form.ShowDialog();
        }

        private void BtnDetailProject_Click(object sender, EventArgs e)
        { 

            error.Clear();
            if (dtgvProject.SelectedRows.Count == 0)
            {
                error.SetError(btnDetailProject, "Vui lòng chọn đề tài");
                return;
            }
            ProjectDetail form = new ProjectDetail(checkID);
            form.ShowDialog();
        }

        private void ShowChartProject_Click(object sender, EventArgs e)
        {
            chartALL.DataSource = ProjectController.Instance.GetChartProject();
            chartALL.Series["chartALL"].XValueMember = "sResult";
            chartALL.Series["chartALL"].YValueMembers = "iGrade";
            chartALL.Titles.Clear();
            chartALL.Titles.Add("Tỉ lệ đề tài");

            chartALL.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void ShowChartTeacher_Click(object sender, EventArgs e)
        {
            chartALL.DataSource = TeacherController.Instance.GetChartTeacher();
            chartALL.Series["chartALL"].XValueMember = "sSex";
            chartALL.Series["chartALL"].YValueMembers = "iCount";
            chartALL.Titles.Clear();
            chartALL.Titles.Add("Tỉ lệ giáo viên");
            chartALL.Series[0].ChartType = SeriesChartType.Pie;
        }



        private void ShowChartStudent_Click(object sender, EventArgs e)
        {
            chartALL.DataSource = StudentController.Instance.GetChartStudent();
            chartALL.Series["chartALL"].XValueMember = "sSex";
            chartALL.Series["chartALL"].YValueMembers = "iCount";
            chartALL.Titles.Clear();
            chartALL.Titles.Add("Tỉ lệ học sinh");
            chartALL.Series[0].ChartType = SeriesChartType.Pie;
        }

        
    }
}
