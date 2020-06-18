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
    public partial class StudentAddUpdate : Form
    {

        string checkmssv;
        clsResize _form_resize;
        public StudentAddUpdate(string mssv)
        {
            checkmssv = mssv;
            InitializeComponent();
            StudentBinding();
            _form_resize = new clsResize(this);
            this.Resize += StudentAddUpdate_Resize;
            this.Load += StudentAddUpdate_Load;

        }

        private void StudentAddUpdate_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void StudentAddUpdate_Resize(object sender, EventArgs e)
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
                txbMSSV.ReadOnly = true;
               this.btnAdd.Visible = false;
               this.btnUpdate.Visible = true;
           }
        }


        public int checkError()
        {
            int check = 0;
            if (this.txbMSSV.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txbMSSV, "Vui lòng nhập mã số sinh viên");
                check++;
            }
            else this.errorProvider1.Clear();

            if (this.txbName.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txbName, "Vui lòng nhập tên sinh viên");
                check++;
            }
            else this.errorProvider2.Clear();

            DateTime now = DateTime.Now;
            DateTime realOld = this.dtpkBirthday.Value;

            if (realOld > now)
            {
                this.errorProvider3.SetError(this.dtpkBirthday, " chọn ngày không hợp lệ");
                check++;
            }
            else
            {
                TimeSpan DistanceTime = now - realOld;
                DateTime zeroTime = new DateTime(1, 1, 1);
                int years = (zeroTime + DistanceTime).Year - 1;

                if (years < 18)
                {
                    this.errorProvider3.SetError(this.dtpkBirthday, "Sinh viên phải trên 18 tuổi");
                    check++;
                }
                else this.errorProvider3.Clear();
            }

            if (this.cbxSex.Text.Trim().Length > 4)
            {
                this.errorProvider4.SetError(this.cbxSex, "Vui lòng chọn giới tính");
                check++;
            }
            else this.errorProvider4.Clear();

            if (this.txbPhone.Text.Trim().Length <= 0)
            {
                this.errorProvider5.SetError(this.txbPhone, "Vui lòng nhập số điện thoại");
                check++;
            }
            else this.errorProvider5.Clear();

            if (this.txbEmail.Text.Trim().Length <= 0)
            {
                this.errorProvider6.SetError(this.txbEmail, "Vui lòng nhập Email");
                check++;
            }
            if (this.txbFaculty.Text.Trim().Length <= 0)
            {
                this.errorProvider7.SetError(this.txbFaculty, "Vui lòng nhập khoa của bạn");
                check++;
            }
            else this.errorProvider7.Clear();

            if (this.txbYear.Text.Trim().Length <= 0)
            {
                this.errorProvider8.SetError(this.txbYear, "Vui lòng nhập năm khóa học của bạn");
                check++;
            }
            else this.errorProvider8.Clear();

            if (check > 0)
                return 1;
            return 0;

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            checkError();
            if (checkError() != 0)
                return;


            string mssv = txbMSSV.Text;
            string name = txbName.Text;
            DateTime birth = dtpkBirthday.Value;
            string sex = cbxSex.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;
            string faculty = txbFaculty.Text;
            int year = Convert.ToInt32(txbYear.Text);

            try
            {
                if (StudentController.Instance.InsertStudent(mssv, name, birth, sex, phone, email, faculty, year))
                {
                    MessageBox.Show("Thêm sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm sinh viên");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã số sinh viên!", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkError();
            if (checkError() != 0)
                return;

            string mssv = txbMSSV.Text;
            string name = txbName.Text;
            string sex = cbxSex.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;
            string faculty = txbFaculty.Text;
            string year = txbYear.Text;
            DateTime dtbirth = dtpkBirthday.Value;
            string sqlFormatDate = dtbirth.ToString("yyyy-MM-dd");

            if (StudentController.Instance.updateStudent(name, sqlFormatDate, sex, phone, email, faculty, year, mssv))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi ");
            }
        }

        private void TxbYear_KeyPress(object sender, KeyPressEventArgs e)
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
