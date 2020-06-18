using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNA.Model
{
    public class Projects
    {
        public string sID;
        public string sName;
        public string sCategory;
        public string sSubject;
        public double dGrade;
        public Teachers Teacher;
        public DateTime dtFromDate;
        public DateTime dtToDate;
        public string sDescription;
        public string sLink;

        public Projects(string id, string name, string category, string subject, double grade, Teachers teacher, DateTime fromdate,DateTime todate, string description, string link)
        {
            this.sID = id;
            this.sName = name;
            this.sCategory = category;
            this.sSubject = subject;
            this.dGrade = grade;
            this.Teacher = teacher;
            this.dtFromDate = fromdate;
            this.dtToDate = todate;
            this.sDescription = description;
            this.sLink = link;
        }
        public Projects(DataRow row)
        {
            
            this.sID = row["sID"].ToString();
            this.sName = row["sName"].ToString();
            this.sCategory = row["sCategory"].ToString();
            this.sSubject = row["sSubject"].ToString();
            try
            {
                this.dGrade = (double)row["iGrade"]; // Đã Sửa
            }
            catch
            {
                this.dGrade = -1;
            }
            this.Teacher = null; //(Teachers)row["teacher"]; Sửa Sau
            this.dtFromDate = (DateTime)row["dtFromDate"];
            this.dtToDate = (DateTime)row["dtToDate"];
            this.sDescription = row["sDescription"].ToString();
            this.sLink = row["sLink"].ToString();
        }
    }
}
