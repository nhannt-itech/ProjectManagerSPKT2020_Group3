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


namespace NNA.View
{
    public partial class ProjectAddUpdate : Form
    {
        clsResize _form_resize;
        string checkid;

        public ProjectAddUpdate(string id)
        {
            checkid = id;
            InitializeComponent();
            _form_resize = new clsResize(this);
            this.Load += ProjectAddUpdate_Load;
            this.Resize += ProjectAddUpdate_Resize;
            cbCategory.Text = "Nhấn để chọn";
            cbCategory.DataSource = new List<string> { "Đồ án môn học", "Tiểu luận chuyên ngành", "Đồ án tốt nghiệp" };

        }

        private void ProjectAddUpdate_Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void ProjectAddUpdate_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        public void UpdateOrAdd(string sAction)
        {
            if (sAction == "Add")
            {
                this.btnAdd.Visible = true;
                this.btnUpdate.Visible = false;
                this.btnProgress.Visible = false;
            }
            if (sAction == "Update")
            {
                txbID.ReadOnly = true;
                this.btnAdd.Visible = false;
                this.btnUpdate.Visible = true;
                this.btnProgress.Visible = true;
                ProjectBinding();
            }
        }


        public int checkError()
        {
            int check = 0;
            if (this.txbID.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txbID, "Vui lòng nhập mã đề tài");
                check++;
            }
            else this.errorProvider1.Clear();

            if (this.txbName.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txbName, "Vui lòng chọn tên chủ đề");
                check++;
            }
            else this.errorProvider2.Clear();

            if (this.cbCategory.Text.Trim().Length <= 12)
            {
                this.errorProvider3.SetError(this.cbCategory, "Vui lòng chọn kiểu đề tài");
                check++;
            }
            else this.errorProvider3.Clear();

            if (this.txbSubject.Text.Trim().Length <= 0)
            {
                this.errorProvider4.SetError(this.txbSubject, "Vui lòng nhập môn học");
                check++;
            }
            else this.errorProvider4.Clear();

            if (this.lstStudent.Items.Count == 0)
            {
                this.errorProvider5.SetError(this.lstStudent, "Vui lòng thêm sinh viên làm đề tài");
                check++;
            }
            else this.errorProvider5.Clear();

            if (this.txbMGV.Text.Trim().Length <= 0 && this.txbTeacherName.Text.Trim().Length <= 0)
            {
                this.errorProvider6.SetError(this.txbTeacherName, "Vui lòng thêm giáo viên hướng dẫn");
                check++;
            }
            else this.errorProvider6.Clear();

            if (this.dtToDate.Value <= this.dtFromDate.Value)
            {
                this.errorProvider7.SetError(this.dtToDate, "Thời gian kết thúc phải sau thời gian bắt đầu");
                check++;
            }
            else this.errorProvider7.Clear();

            if (check > 0)
                return 1;
            return 0;

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            checkError();
            if (checkError() != 0)
                return;

            string id = txbID.Text;
            string name = txbName.Text;
            string category = cbCategory.Text;
            string subject = txbSubject.Text;
            int grade;
            if (txbGrade.Text != "")
            {
                grade = Convert.ToInt32(txbGrade.Text);
            }
            else
            {
                grade = -1;
            }
            DateTime fromDate = dtFromDate.Value;
            DateTime toDate = dtToDate.Value;
            Teachers teacher = TeacherController.Instance.GetTeacherByMGV(txbMGV.Text.Trim());
            string teacherID = teacher.sMGV;
            string description = txbDescription.Text;
            string link = txbLink.Text;
            List<Projects> lProject = new List<Projects>();
            lProject = ProjectController.Instance.GetListProjectModel();
            int CheckOldId = 0;

            for (int j = 0; j< lProject.Count; j++)
            {
                if (lProject[j].sID == id)
                {
                    CheckOldId = 1;
                }
            }
            if (CheckOldId == 0)
            {
                if (ProjectController.Instance.InsertProject(id, name, category, subject, grade, fromDate, toDate, teacherID, description, link) && ProjectController.Instance.InsertCommentProject(id))
                {
                    MessageBox.Show("Thêm đề tài thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm đề tài");
                }
                for (int i = 0; i < lstStudent.Items.Count; i++)
                {
                    string mssv = ((Students)lstStudent.Items[i]).sMSSV;
                    ProjectController.Instance.InsertStudentProject(mssv, id);
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã đề tài!", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void TxbSearchTeacher_TextChanged(object sender, EventArgs e)
        {
            //this.lstSearchTeacher.Items.Clear();
            // tìm teacher trong list teacher
            List<Teachers> searchTeacher = TeacherController.Instance.GetListTeachersSeach(txbSearchTeacher.Text.Trim());
            if (searchTeacher.Count > 0)
            {
                this.lstSearchTeacher.Visible = true;
            }
            else
            {
                this.lstSearchTeacher.Visible = false;
            }
            lstSearchTeacher.DataSource = searchTeacher;
            lstSearchTeacher.DisplayMember = "sMGV";
            //lstSearchTeacher.ValueMember = "sName";
        }



        private void TxbSearchStudent_TextChanged(object sender, EventArgs e)
        {
            List<Students> searchStudents = StudentController.Instance.GetListStudentSeach(txbSearchStudent.Text.Trim());
            if (searchStudents.Count > 0)
            {
                this.lstSearchStudent.Visible = true;
            }
            else
            {
                this.lstSearchStudent.Visible = false;
            }
            lstSearchStudent.DataSource = searchStudents;
            lstSearchStudent.DisplayMember = "sMSSV";
            //lstSearchTeacher.ValueMember = "sName";
        }



        private void LstSearchStudent_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstSearchStudent.SelectedIndex >= 0)
            {
                
                if (this.lstStudent.Items.Contains(lstSearchStudent.SelectedItem))
                {
                    MessageBox.Show("Sinh viên đã tồn tại trong nhóm !");
                    return;
                }
                else
                {
                    this.lstStudent.Items.Add(lstSearchStudent.SelectedItem);
                    this.lstStudentName.Items.Add(lstSearchStudent.SelectedItem);
                    lstStudent.DisplayMember = "sMSSV";
                    lstStudentName.DisplayMember = "sName";
                }
                for (int i = 0; i < lstStudent.Items.Count; i++)
                {
                    for (int j = i + 1; j < lstStudent.Items.Count; j++)
                    {
                        if (lstStudent.Items[i].ToString() == lstStudent.Items[j].ToString())
                        {
                            lstStudent.Items.RemoveAt(j);
                            lstStudentName.Items.RemoveAt(j);
                            MessageBox.Show("Sinh viên đã tồn tại trong nhóm !");
                        }
                    }
                }
            }
        }

        private void LstStudent_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstStudent.SelectedIndex >= 0)
            {
                int now = this.lstStudent.SelectedIndex;
                this.lstStudent.Items.RemoveAt(now);
                this.lstStudentName.Items.RemoveAt(now);
            }
        }
        private void lstStudentName_DoubleClick(object sender, EventArgs e)
        {
            if(this.lstStudentName.SelectedIndex >= 0)
            {
                int now = this.lstStudentName.SelectedIndex;
                this.lstStudent.Items.RemoveAt(now);
                this.lstStudentName.Items.RemoveAt(now);
            }
        }


        private void TxbSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkError();
            if (checkError() != 0)
                return;

            string id = txbID.Text;
            string name = txbName.Text;
            string category = cbCategory.Text;
            string subject = txbSubject.Text;
            string grade = txbGrade.Text;
            DateTime dtfromdate = dtFromDate.Value;
            string sqlFormatFromDate = dtfromdate.ToString("yyyy-MM-dd");
            DateTime dttodate = dtToDate.Value;
            string sqlFormatToDate = dttodate.ToString("yyyy-MM-dd");
            // Teachers teacher = TeacherController.Instance.GetTeacherByName(txbTeacher.Text.Trim());
            string teacherID = txbMGV.Text;
            string description = txbDescription.Text;
            string link = txbLink.Text;
            if (ProjectController.Instance.updateProject(name, category, subject, grade, sqlFormatFromDate, sqlFormatToDate, teacherID, id, description, link))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }


            ProjectController.Instance.ClearStudentProject(id); // Xóa đi dữ liệu cũ
            for (int i = 0; i < lstStudent.Items.Count; i++)
            {
                string mssv = ((Students)lstStudent.Items[i]).sMSSV;
                ProjectController.Instance.InsertStudentProject(mssv, id);
            }
        }

        private void BtnProgress_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            ProgressView form = new ProgressView(id);
            form.ShowDialog();
        }


        #region TruongNguyen7_6

        private void txbMGV_DoubleClick(object sender, EventArgs e)
        {
            txbTeacherName.Clear();
            txbMGV.Clear();
        }
        private void LstSearchTeacher_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstSearchTeacher.SelectedIndex >= 0)
            {
                this.txbMGV.Text = ((Teachers)lstSearchTeacher.SelectedItem).sMGV;
                this.txbTeacherName.Text = ((Teachers)lstSearchTeacher.SelectedItem).sName;
            }
        }
        void ProjectBinding()
        {

            DataTable project = ProjectController.Instance.GetProjectDetailByID(checkid);
            txbID.DataBindings.Add(new Binding("Text", project, "sID"));
            txbName.DataBindings.Add(new Binding("Text", project, "sName"));
            cbCategory.DataBindings.Add(new Binding("Text", project, "sCategory"));
            txbSubject.DataBindings.Add(new Binding("Text", project, "sSubject"));
            txbGrade.DataBindings.Add(new Binding("Text", project, "iGrade"));
            dtFromDate.DataBindings.Add(new Binding("Text", project, "dtFromDate"));
            dtToDate.DataBindings.Add(new Binding("Text", project, "dtToDate"));
            txbMGV.DataBindings.Add(new Binding("Text", project, "teacher_ID"));
            txbDescription.DataBindings.Add(new Binding("Text", project, "sDescription"));
            txbLink.DataBindings.Add(new Binding("Text", project, "sLink"));


            string id = project.Rows[0].Field<string>("teacher_ID");

            Teachers teacher = TeacherController.Instance.GetTeacherByMGV(id);
            txbTeacherName.Text = teacher.sName;

            // Phần Binding mới của Update(Lương Thế Anh)
            string idProject = project.Rows[0].Field<string>("sID"); 
            List<Students> ListStudentInProject = ProjectController.Instance.GetListStudentInProject(idProject);

            for(int i = 0; i<ListStudentInProject.Count; i++)
            {
                this.lstStudent.Items.Add(ListStudentInProject[i]);
                lstStudent.DisplayMember = "sMSSV";
                this.lstStudentName.Items.Add(ListStudentInProject[i]);
                lstStudentName.DisplayMember = "sName";
            }
        }


        #endregion

        private void TxbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
