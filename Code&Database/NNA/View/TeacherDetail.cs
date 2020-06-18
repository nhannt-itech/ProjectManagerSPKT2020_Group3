using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNA.Controller;
using NNA.Model;


namespace NNA
{
    public partial class TeacherDetail : Form
    {

        clsResize _form_resize;
        string checkmgv;
        public TeacherDetail(string msv)
        {

            checkmgv = msv;
            InitializeComponent();
            TeacherBinding();
            _form_resize = new clsResize(this);
            this.Resize += TeacherDetail_Resize;
            this.Load += TeacherDetail_Load;

        }

        private void TeacherDetail_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void TeacherDetail_Resize(object sender, EventArgs e)
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

            pbxImage.Image = TeacherController.Instance.ShowImageInForm(checkmgv); // Vô coi TeacherController

        }

    }
}
