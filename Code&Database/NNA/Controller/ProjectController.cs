using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNA.Model;

namespace NNA.Controller
{
    public class ProjectController
    {
        private static ProjectController instance;

        public static ProjectController Instance
        {
            get { if (instance == null) instance = new ProjectController(); return ProjectController.instance; }
            private set { ProjectController.instance = value; }

        }

        private ProjectController(){ }

        #region NhanNguyen

        public List<Projects> GetListProjectModel()
        {
            List<Projects> list = new List<Projects>();
            string query = string.Format("SELECT * FROM dbo.Project");
            DataTable data = DataController.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Projects proj = new Projects(item);
                list.Add(proj);
            }

            return list;
        }

        public DataTable GetCommentProjectByID(string id)
        {
            string query = "select * from dbo.Comment where sID = '" + id + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetListProject()
        {
            string query = "select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t WHERE p.teacher_ID = t.sMGV";
            return DataController.Instance.ExecuteQuery(query);
        }

        public DataTable SearchProject(string sInput, string sKind)
        {
            string query = @"EXEC USP_SearchProject @sInput , @sKind ";
            return DataController.Instance.ExecuteQuery(query, new object[] { sInput, sKind });
        }

        public void DeleteProject(string sID)
        {
            string queryDelete = @"EXEC USP_DeleteProject @sID ";
            DataController.Instance.ExecuteQuery(queryDelete, new object[] { sID });
        }

        public DataTable ShowProject()
        {
            string queryShow = @"EXEC USP_ShowProject";
            return DataController.Instance.ExecuteQuery(queryShow);
        }

        public DataTable SearchStudentOfProject(string sMSSV)
        {
            string query = @"EXEC USP_SearchProjectSV @sMSSV ";
            return DataController.Instance.ExecuteQuery(query, new object[] { sMSSV});
        }

        public DataTable GetChartProject()
        {
            string query = @"EXEC USP_ChartProject";
            return DataController.Instance.ExecuteQuery(query);
        }
        #endregion

        #region TruongNguyen
        public bool InsertProject(string id, string name, string category, string subject, int grade, DateTime fromDate, DateTime toDate, string teacherID, string description, string link)
        {
            string query = "";
            if (grade == -1 )
            {
                query = string.Format("INSERT dbo.Project(sID, sName, sCategory, sSubject, iGrade, dtFromDate, dtToDate, teacher_ID, sDescription, sLink)VALUES(N'{0}', N'{1}', N'{2}', N'{3}', {4}, '{5}', '{6}', N'{7}', N'{8}', N'{9}')", id, name, category, subject, "null", fromDate, toDate, teacherID, description, link);

            }
            else
            {
                query = string.Format("INSERT dbo.Project(sID, sName, sCategory, sSubject, iGrade, dtFromDate, dtToDate, teacher_ID, sDescription, sLink)VALUES(N'{0}', N'{1}', N'{2}', N'{3}', {4}, '{5}', '{6}', N'{7}', N'{8}', N'{9}')", id, name, category, subject, grade, fromDate, toDate, teacherID, description, link);
              
            }
            int result = DataController.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertCommentProject(string id)
        {
            string query = string.Format("Insert into Comment Values ('{0}', 0, null, null, null)", id);
            int result = DataController.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool InsertStudentProject(string mssv, string projectID)
        {
            string query = string.Format("INSERT dbo.Student_Project ( Student_MSSV, Project_ID )VALUES  ( N'{0}', N'{1}')  ", mssv, projectID);
            int result = DataController.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        #endregion
        #region LuongAnh
        public DataTable GetProjectDetailByID(string id)
        {
            string query = "select * from dbo.Project where sID = '" + id + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);

            return data;
        }
        public bool updateProject(string sname, string scategory, string ssubject, string sgrade, string dtfromdate, string dttodate, string teacher_id, string sid, string description, string link)
        {
            string query = string.Format(" update dbo.Project set sName = N'{0}', sCategory = N'{1}', sSubject = N'{2}', iGrade = N'{3}', dtFromDate = '{4}', dtToDate = '{5}', teacher_ID = '{6}', sDescription = N'{7}', sLink = N'{8}'  where sID = '{9}' ", sname, scategory, ssubject, sgrade, dtfromdate, dttodate, teacher_id, description , link ,sid);
            int result = DataController.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool ClearStudentProject(string projectid)
        {
            string QueryDeleteOld = string.Format("Delete from dbo.Student_Project where Project_ID = N'{0}' ",projectid);
            int result = DataController.Instance.ExecuteNonQuery(QueryDeleteOld);
            return (result>0);
        }

        public List<Students> GetListStudentInProject(string sID)
        {
            List<Students> list = new List<Students>();
            string query = "EXEC USP_GetListStudentInProject @sID";
            DataTable data = DataController.Instance.ExecuteQuery(query, new object[] { sID });
            foreach (DataRow item in data.Rows)
            {
                Students student = new Students(item);
                list.Add(student);
            }
            return list;
        }
        #endregion

    }
}
