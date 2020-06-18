using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNA.Model
{
    public class Students
    {
        public string sMSSV { get; set; }
        public string sName { get; set; }
        public DateTime dtBirth;
        public string sSex;
        public string sPhone;
        public string sEmail;
        public string sFaculty;
        public int iYear;
        
        public Students(string mSSV, string name,DateTime birth, string sex, string phone,string email,string faculty,int year)
        {
            this.sMSSV = mSSV;
            this.sName = name;
            this.dtBirth = birth;
            this.sSex = sex;
            this.sPhone = phone;
            this.sEmail = email;
            this.sFaculty = faculty;
            this.iYear = year;
        }
        public Students(DataRow row)
        {
            this.sMSSV = row["sMSSV"].ToString();
            this.sName = row["sName"].ToString();
            this.dtBirth = (DateTime)row["dtBirth"];
            this.sSex = row["sSex"].ToString();
            this.sPhone = row["sPhone"].ToString();
            this.sEmail = row["sEmail"].ToString();
            this.sFaculty = row["sFaculty"].ToString();
            this.iYear =(int) row["iYear"];
        }

        public override string ToString()
        {
            return sMSSV;
        }

    }
}
