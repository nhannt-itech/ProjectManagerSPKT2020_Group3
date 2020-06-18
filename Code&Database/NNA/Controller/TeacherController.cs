using NNA.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNA.Controller
{
    public class TeacherController
    {
        private static TeacherController instance;
        private string connectionSTR = DataController.connectionSTR;

        public static TeacherController Instance
        {
            get { if (instance == null) instance = new TeacherController(); return TeacherController.instance; }
            private set { TeacherController.instance = value; }
        }
        private TeacherController() { }
        #region LuongAnh
        public DataTable GetListTeacher()
        {
            string query = "select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher";
            return DataController.Instance.ExecuteQuery(query);
        }
        public DataTable GetTeacherDetailByMGV(string mgv)
        {
            string query = "select * from dbo.Teacher where sMGV = '" + mgv + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);

            return data;
        }
        public bool updateTeacher(string sname, string ssex, string sphone, string semail, string dtbirth, string sfaculty, string ssubject, byte[] arr, string smgv)
        {
            string query = string.Format("update dbo.Teacher set sName = @sName , sSex = @sSex , sPhone = @sPhone , sEmail = @sEmail , dtBirth = @dtBirth , sFaculty = @sFaculty , sSubject = @sSubject , iImage = @iImage    where sMGV = @sMGV ");
            DataController.Instance.ExecuteQuery(query, new object[] { sname, ssex, sphone, semail, dtbirth, sfaculty, ssubject, arr, smgv });
            return true;
        }
        public List<Teachers> GetListTeachersSeach(string MGV)
        {
            List<Teachers> list = new List<Teachers>();
            string query = string.Format( "SELECT * FROM dbo.Teacher WHERE sMGV like N'%{0}%'",MGV);
            DataTable data = DataController.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Teachers teacher = new Teachers(item);
                list.Add(teacher);
            }

            return list;
        }
        public Teachers GetTeacherByName(string name)
        {
            Teachers teacher = null;
            string query = "SELECT * FROM dbo.Teacher WHERE sName = '" + name + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                teacher = new Teachers(item);
                return teacher;
            }
            return teacher;
        }

        public DataTable GetIMGTeacher(string sMGV)
        {
            string query = "selelct iImage from dbo.Teacher where sMGV =  '" + sMGV + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);

            return data;
        }
        public Image ShowImageInForm(string checkmgv)
        {
            Image TeacherImg = null;
            try
            {
                SqlConnection cn = new SqlConnection(connectionSTR);
                cn.Open();

                SqlCommand cmd = new SqlCommand("select * from dbo.Teacher where sMGV = '" + checkmgv + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Teacher");
                int c = ds.Tables["Teacher"].Rows.Count;

                if (c > 0)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["Teacher"].Rows[c - 1]["iImage"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    TeacherImg = Image.FromStream(stmBLOBData);
                }
                cn.Close();
            }
            catch { }
            return TeacherImg;
        }
        #endregion

        #region NguyenNhan31/05
        public DataTable SearchTeacher (string sInput, string sKind)
        {
            string query = @"EXEC USP_SearchTeacher @sInput , @sKind "; 
            return DataController.Instance.ExecuteQuery(query, new object[] {sInput , sKind});
        }

        

        public void DeleteTeacher(string sMGV)
        {
            try
            {
                string queryDelete = @"EXEC USP_DeleteTeacher @sMGV ";
                DataController.Instance.ExecuteQuery(queryDelete, new object[] { sMGV });
            }
            catch
            {
                MessageBox.Show("Giáo Viên Đang Quản Lý Dự Án", "Không Thể Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable ShowTeacher()
        {
            string queryShow = @"EXEC USP_ShowTeacher";
            return DataController.Instance.ExecuteQuery(queryShow);
        }

        public DataTable GetChartTeacher()
        {
            string query = @"EXEC USP_ChartTeacher";
            return DataController.Instance.ExecuteQuery(query);
        }


        #endregion
        #region TruongNguyen
        public bool InsertTeacher(string mgv, string name, string sex, string phone, string email, DateTime birth, string faculty, string subject, byte[] arr)
        {
            string query = "Insert into Teacher Values ( @sMGV , @sName , @sSex , @sPhone , @sEmail , @dtBirth , @sFaculty , @sSubject , @iImage )";
            DataController.Instance.ExecuteQuery(query, new object[] { mgv , name , sex , phone , email , birth , faculty , subject , arr });
            return true;
        }
        public Teachers GetTeacherByMGV(string mgv)
        {
            Teachers teacher = null;
            string query = "SELECT * FROM dbo.Teacher WHERE sMGV = '" + mgv + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                teacher = new Teachers(item);
                return teacher;
            }
            return teacher;
        }

        #endregion



    }
}
