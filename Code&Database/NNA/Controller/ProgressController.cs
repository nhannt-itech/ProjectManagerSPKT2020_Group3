using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNA.Model;
using NNA.View;

namespace NNA.Controller
{
    public class ProgressController
    {
        private static ProgressController instance;
        public static ProgressController Instance
        {
            get { if (instance == null) instance = new ProgressController(); return ProgressController.instance; }
            private set { ProgressController.instance = value; }
        }
        private ProgressController() { }
        #region TruongNguyen
        public ProgressProject GetProgressByID(string id)
        {
            ProgressProject progress = null;
            string query = "select * from dbo.Comment where sID = '" + id + "'";
            DataTable data = DataController.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                progress = new ProgressProject(item);
                return progress;
            }
            return progress;
        }
        public bool UpdateProgress(string id, int time, string cmt1, string cmt2,string cmt3)
        {
            string query = string.Format("UPDATE Comment SET iTime = {0}, sComment1 =N'{1}',sComment2 =N'{2}',sComment3=N'{3}' WHERE sID = '{4}'", time, cmt1, cmt2, cmt3,id);
            int result = DataController.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
