using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNA.Model;

namespace NNA.Controller
{
    public class StudentController
    {
        private static StudentController instance;
        public static StudentController Instance
        {
            get { if (instance == null) instance = new StudentController(); return instance; }
            private set { instance = value; }
        }
        private StudentController() { }
        #region TruongNguyen
        public DataTable GetListStudent()
        {
            //string query = "select * from dbo.Student";
            string query = "select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student";
            return DataController.Instance.ExecuteQuery(query); 
        }
        
        public bool InsertStudent(string mmsv, string name, DateTime birth, string sex, string phone, string email, string faculty, int year)
        {
            string query = string.Format("INSERT Student (sMSSV,sName,dtBirth,sSex,sPhone,sEmail,sFaculty,iYear) VALUES ('{0}',N'{1}','{2}',N'{3}','{4}','{5}','{6}',{7})", mmsv, name, birth, sex, phone, email, faculty, year);
            int result = DataController.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetStudentDetailByMSSV(string mssv)
        {

            string query = "SELECT * FROM dbo.Student WHERE sMSSV = '" + mssv + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);


            return data;
        }
        public List<Students> GetListStudentSeach(string mssv)
        {
            List<Students> list = new List<Students>();
            string query = string.Format("SELECT * FROM dbo.Student WHERE sMSSV like N'%{0}%'",mssv);
            DataTable data = DataController.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Students student = new Students(item);
                list.Add(student);
            }

            return list;
        }
        #endregion

        #region NguyenNhan
        public DataTable SearchStudent(string sInput, string sKind)
        {   
            string query = @"EXEC USP_SearchStudent @sInput , @sKind ";
            return DataController.Instance.ExecuteQuery(query, new object[] { sInput, sKind });
        }


        public void DeleteStudent(string sMSSV)
        {
            string queryDelete = @"EXEC USP_DeleteStudent @sMSSV ";
            DataController.Instance.ExecuteQuery(queryDelete, new object[] { sMSSV });
        }

        public DataTable ShowStudent()
        {
            string queryShow = @"EXEC USP_ShowStudent";
            return DataController.Instance.ExecuteQuery(queryShow);
        }

        public DataTable SearchStudentOfProject(string sID)
        {
            string query = @"EXEC USP_SearchStudentPJ @sID ";
            return DataController.Instance.ExecuteQuery(query, new object[] { sID });
        }

        public DataTable GetChartStudent()
        {
            string query = @"EXEC USP_ChartStudent";
            return DataController.Instance.ExecuteQuery(query);
        }
        #endregion

        #region LuongAnh

        public bool updateStudent(string sname, string dtbirth, string ssex, string sphone, string semail, string sfaculty, string iyear, string smssv)
        {
            string query = string.Format(" update dbo.Student set sName = N'{0}', dtBirth = '{1}', sSex = N'{2}', sPhone = '{3}', sEmail = N'{4}', sFaculty = N'{5}', iYear = '{6}' where sMSSV = '{7}' ", sname, dtbirth, ssex, sphone, semail, sfaculty, iyear, smssv);
            int result = DataController.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //public bool checkMSSV( string mssv)
        //{
        //    string query = " select sMSSV, COUNT(sMSSV) as SL from dbo.Student group by(sMSSV) having count(sMSSV) >= 1 ";
        //    int result = DataController.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //    if (result < 1)
        //        return true;
        //    return false;

        //}

        

        #endregion

    }
}
