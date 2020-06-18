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
using System.IO;
using System.Data.SqlClient;

namespace NNA.View
{
    public partial class TeacherAddUpdate : Form
    {
        string checkmgv;
        clsResize _form_resize;
        string imageURL = null;

        public TeacherAddUpdate(string mgv)
        {
            checkmgv = mgv;
            InitializeComponent();
            TeacherBinding();
            _form_resize = new clsResize(this);
            this.Resize += TeacherAddUpdate_Resize;
            this.Load += TeacherAddUpdate_Load;

        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void TeacherAddUpdate_Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        void TeacherBinding()
        {
            DataTable teacher = TeacherController.Instance.GetTeacherDetailByMGV(checkmgv);
            txbMGV.DataBindings.Add(new Binding("Text", teacher, "sMGV"));
            txbName.DataBindings.Add(new Binding("Text", teacher, "sName"));
            txbPhone.DataBindings.Add(new Binding("Text", teacher, "sPhone"));
            cbxSex.DataBindings.Add(new Binding("Text", teacher, "sSex"));
            txbEmail.DataBindings.Add(new Binding("Text", teacher, "sEmail"));
            dtBirth.DataBindings.Add(new Binding("Text", teacher, "dtBirth"));
            txbFaculty.DataBindings.Add(new Binding("Text", teacher, "sFaculty"));
            txbSubject.DataBindings.Add(new Binding("Text", teacher, "sSubject"));

            pbxImage.Image = TeacherController.Instance.ShowImageInForm(checkmgv);

        }
        public void UpdateOrAdd(string sAction)
        {
            if (sAction == "Add")
            {
                this.btnAdd.Visible = true;
                this.btnUpdate.Visible = false;
            }
            if (sAction == "Update")
            {
                txbMGV.ReadOnly = true;
                this.btnAdd.Visible = false;
                this.btnUpdate.Visible = true;
            }
        }



        public int checkError()
        {
            int check = 0;
            if (this.txbMGV.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txbMGV, "Vui lòng nhập mã giáo viên");
                check++;
            }
            else this.errorProvider1.Clear();

            if (this.txbName.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txbName, "Vui lòng nhập họ tên giáo viên");
                check++;
            }
            else this.errorProvider2.Clear();

            if (this.cbxSex.Text.Trim().Length > 4)
            {
                this.errorProvider3.SetError(this.cbxSex, "Vui lòng chọn giới tính");
                check++;
            }
            else errorProvider3.Clear();

            if (this.txbPhone.Text.Trim().Length <= 0)
            {
                this.errorProvider4.SetError(this.txbPhone, "Vui lòng nhập số điện thoại");
                check++;
            }
            else errorProvider4.Clear();

            if (this.txbEmail.Text.Trim().Length <= 0)
            {
                this.errorProvider5.SetError(this.txbEmail, "Vui lòng nhập Email");
                check++;
            }
            else errorProvider5.Clear();

            DateTime now = DateTime.Now;
            DateTime realOld = this.dtBirth.Value;

            if (realOld > now)
            {
                this.errorProvider6.SetError(this.dtBirth, " Chọn ngày không hợp lệ");
                check++;
            }
            else
            {
                TimeSpan DistanceTime = now - realOld;
                DateTime zeroTime = new DateTime(1, 1, 1);
                int years = (zeroTime + DistanceTime).Year - 1;

                if (years < 22)
                {
                    this.errorProvider6.SetError(this.dtBirth, "Giáo viên phải trên 22 tuổi");
                    check++;
                }
                else this.errorProvider6.Clear();
            }

            if (this.txbFaculty.Text.Trim().Length <= 0)
            {
                this.errorProvider7.SetError(this.txbFaculty, "Vui lòng nhập khoa của giáo viên");
                check++;
            }
            else this.errorProvider7.Clear();

            if (this.txbSubject.Text.Trim().Length <= 0)
            {
                this.errorProvider8.SetError(this.txbSubject, "Vui lòng nhập môn");
                check++;
            }
            else errorProvider8.Clear();

            if (check > 0)
                return 1;
            return 0;
        }
        #region TruongNguyen
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            checkError();
            if (checkError() != 0)
                return;

            string mgv = txbMGV.Text;
            string name = txbName.Text;
            string sex = cbxSex.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;
            DateTime birth = dtBirth.Value;
            string faculty = txbFaculty.Text;
            string subject = txbSubject.Text;

            Image img = pbxImage.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            try
            {
                if (TeacherController.Instance.InsertTeacher(mgv, name, sex, phone, email, birth, faculty, subject, arr))
                {
                    MessageBox.Show("Thêm giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm giáo viên");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã giáo viên!", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }
        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageURL = ofd.FileName;
                    pbxImage.Image = Image.FromFile(ofd.FileName);
                    pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxImage.BorderStyle = BorderStyle.Fixed3D;
                }
            }
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkError();
            if (checkError() != 0)
                return;

            string smgv = txbMGV.Text;
            string sname = txbName.Text;
            string ssex = cbxSex.Text;
            string sphone = txbPhone.Text;
            string semail = txbEmail.Text;

            DateTime dtbirthdate = dtBirth.Value;
            string sqlFormatDate = dtbirthdate.ToString("yyyy-MM-dd");
            string sfaculty = txbFaculty.Text;
            string ssubject = txbSubject.Text;

            Image img = pbxImage.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            if (TeacherController.Instance.updateTeacher(sname, ssex, sphone, semail, sqlFormatDate, sfaculty, ssubject, arr, smgv))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật ");
            }
        }
    }
}
