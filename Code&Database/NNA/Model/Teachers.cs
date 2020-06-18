using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNA.Model
{
    public class Teachers
    {
        public string sMGV { get; set; }
        public string sName { get; set; }
        public string sSex;
        public string sPhone;
        public string sEmail;
        public DateTime dtBirth;
        public string sFaculty;
        public string sSubject;
        public Teachers(string mGV, string name, string sex, string phone, string email, DateTime birth, string faculty, string subject)
        {
            this.sMGV = mGV;
            this.sName = name;
            this.sSex = sex;
            this.sPhone = phone;
            this.sEmail = email;
            this.dtBirth = birth;
            this.sFaculty = faculty;
            this.sSubject = subject;
        }
        public Teachers(DataRow row)
        {
            this.sMGV = row["sMGV"].ToString();
            this.sName = row["sName"].ToString();
            this.sSex = row["sSex"].ToString();
            this.sPhone = row["sPhone"].ToString();
            this.sEmail = row["sEmail"].ToString();
            this.dtBirth = (DateTime)row["dtBirth"];
            this.sFaculty = row["sFaculty"].ToString();
            this.sSubject = row["sSubject"].ToString();

        }
    }
}
    
