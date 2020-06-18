using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNA.Model
{
    public class ProgressProject
    {
        public string sID;
        public int iTime;
        public string sComment1;
        public string sComment2;
        public string sComment3;

        public ProgressProject(string id, int time, string cmt1, string cmt2, string cmt3)
        {
            this.sID = id;
            this.iTime = time;
            this.sComment1 = cmt1;
            this.sComment2 = cmt2;
            this.sComment3 = cmt3;
        }
        public ProgressProject(DataRow row)
        {
            this.sID = row["sID"].ToString();
            this.iTime = (int)row["iTime"];
            this.sComment1 = row["sComment1"].ToString();
            this.sComment2 = row["sComment2"].ToString();
            this.sComment3 = row["sComment3"].ToString();
        }

    }
}
