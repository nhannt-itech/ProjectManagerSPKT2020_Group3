using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNA.Model
{
    public class clsResize
    {
        List<System.Drawing.Rectangle> _arr_control_storage = new List<System.Drawing.Rectangle>();
        private bool showRowHeader = false;
        public clsResize(Form _form_)
        {
            form = _form_; 
            _formSize = _form_.ClientSize; 
            _fontsize = _form_.Font.Size; 
        }

        private float _fontsize
        {
            get;
            set;
        }

        private System.Drawing.SizeF _formSize
        {
            get;
            set;
        }

        private Form form
        {
            get;
            set;
        }

        public void _get_initial_size() 
        {
            var _controls = _get_all_controls(form); 
            foreach (Control control in _controls) 
            {
                _arr_control_storage.Add(control.Bounds); 
                                                          
                if (control.GetType() == typeof(DataGridView))
                    _dgv_Column_Adjust(((DataGridView)control), showRowHeader);
            }
        }

        public void _resize() 
        {
            double _form_ratio_width = (double)form.ClientSize.Width / (double)_formSize.Width;
            double _form_ratio_height = (double)form.ClientSize.Height / (double)_formSize.Height;
            var _controls = _get_all_controls(form);

            int _pos = -1;
            foreach (Control control in _controls)
            {
                try
                {
                    _pos += 1;
                    System.Drawing.Size _controlSize = new System.Drawing.Size((int)(_arr_control_storage[_pos].Width * _form_ratio_width),
                     (int)(_arr_control_storage[_pos].Height * _form_ratio_height));

                    System.Drawing.Point _controlposition = new System.Drawing.Point((int)
                     (_arr_control_storage[_pos].X * _form_ratio_width), (int)(_arr_control_storage[_pos].Y * _form_ratio_height));


                    control.Bounds = new System.Drawing.Rectangle(_controlposition, _controlSize);

                    if (control.GetType() == typeof(DataGridView))
                        _dgv_Column_Adjust(((DataGridView)control), showRowHeader);

                    control.Font = new System.Drawing.Font(form.Font.FontFamily,
         (float)(((Convert.ToDouble(_fontsize) * _form_ratio_width) / 2) +
          ((Convert.ToDouble(_fontsize) * _form_ratio_height) / 2)));
                }
                catch { }
            }
        }

        private void _dgv_Column_Adjust(DataGridView dgv, bool _showRowHeader)
                                                                               
        {
            int intRowHeader = 0;
            const int Hscrollbarwidth = 5;
            if (_showRowHeader)
                intRowHeader = dgv.RowHeadersWidth;
            else
                dgv.RowHeadersVisible = false;

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Dock == DockStyle.Fill) 
                    dgv.Columns[i].Width = ((dgv.Width - intRowHeader) / dgv.ColumnCount);
                //else
                    //dgv.Columns[i].Width = ((dgv.Width - intRowHeader - Hscrollbarwidth) / dgv.ColumnCount);
            }
        }

        private static IEnumerable<Control> _get_all_controls(Control c)
        {
            return c.Controls.Cast<Control>().SelectMany(item =>
         _get_all_controls(item)).Concat(c.Controls.Cast<Control>()).Where(control =>
     control.Name != string.Empty);
        }
    }
}
