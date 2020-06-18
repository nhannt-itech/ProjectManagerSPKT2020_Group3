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

namespace NNA.View
{
    public partial class ProgressView : Form
    {
        string checkid;
        clsResize _form_resize;

        public ProgressView(string idProject)
        {
            
            InitializeComponent();
            checkid = idProject;
            ProgressBinding();
            _form_resize = new clsResize(this);
            this.Load += ProgressView_Load;
            this.Resize += ProgressView_Resize;
            //EditComment();

        }

        private void ProgressView_Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void ProgressView_Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void ProgressProject_Load(object sender, EventArgs e)
        {

        }
        public void ProgressBinding()
        {
            ProgressProject progress = ProgressController.Instance.GetProgressByID(checkid);
            if (progress.sComment1 != null && progress.sComment1 != "")
            {
                txtComment1.Text = progress.sComment1;
            }
            textBox2.Text = progress.sComment2;
            textBox3.Text = progress.sComment3;
            progressBar.Maximum = 90;
            if( progress.iTime ==0)
            {
                txtComment1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                cbComment2.Enabled = false;
                cbComment3.Enabled = false;
            }
            if(progress.iTime == 1)
            {
                cbComment1.Checked = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                progressBar.Value = 30;
            }
            if (progress.iTime == 2)
            {
                cbComment1.Checked = true;
                cbComment2.Checked = true;
                textBox3.ReadOnly = true;
                progressBar.Value = 60;
            }
            if (progress.iTime == 3)
            {
                cbComment1.Checked = true;
                cbComment2.Checked = true;
                cbComment3.Checked = true;
                progressBar.Value = 90;
            }
          
        }
        public void EditComment()
        {
            
            if (cbComment1.Checked == false)
            {
                txtComment1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                cbComment2.Enabled = false;
                cbComment3.Enabled = false;
            }
            else 
            {

                txtComment1.ReadOnly = false;
                cbComment2.Enabled = true;
            }
            if (cbComment1.Checked == true && cbComment2.Checked == true)
            {
                textBox2.ReadOnly = false;
                cbComment3.Enabled = true;

            }
            if (cbComment1.Checked == true && cbComment2.Checked == true && cbComment3.Checked == true)
            { 
                textBox3.ReadOnly = false;
            }
            
            


        }

        private void txtComment1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbComment1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbComment1.Checked == false)
            {
                txtComment1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                txtComment1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                cbComment2.Checked = false;
                cbComment3.Checked = false;
                cbComment2.Enabled = false;
                cbComment3.Enabled = false;
            }
            EditComment();
        }

        private void cbComment2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbComment2.Checked == false)
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                cbComment3.Checked = false;
                cbComment3.Enabled = false;
            }
            EditComment();
        }

        private void cbComment3_CheckedChanged(object sender, EventArgs e)
        {
            if(cbComment3.Checked == false)
            {
                textBox3.Clear();
                textBox3.ReadOnly = true;

            }
            EditComment();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditComment();
            int time = 0;
            if (cbComment1.Checked == true && cbComment2.Checked == false && cbComment3.Checked == false)
            {
                time = 1;
            }
            if (cbComment2.Checked == true)
            {
                time = 2;
            }
            if (cbComment3.Checked == true)
            {
                time = 3;
            }


            if (ProgressController.Instance.UpdateProgress(checkid,time, txtComment1.Text, textBox2.Text, textBox3.Text))
            {
                MessageBox.Show("Cập nhật tiến trình thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
