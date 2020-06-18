namespace NNA.View
{
    partial class ProgressView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbComment3 = new System.Windows.Forms.CheckBox();
            this.cbComment2 = new System.Windows.Forms.CheckBox();
            this.cbComment1 = new System.Windows.Forms.CheckBox();
            this.txtComment1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.cbComment3);
            this.panel1.Controls.Add(this.cbComment2);
            this.panel1.Controls.Add(this.cbComment1);
            this.panel1.Controls.Add(this.txtComment1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 451);
            this.panel1.TabIndex = 0;
            // 
            // cbComment3
            // 
            this.cbComment3.AutoSize = true;
            this.cbComment3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComment3.Location = new System.Drawing.Point(236, 244);
            this.cbComment3.Margin = new System.Windows.Forms.Padding(2);
            this.cbComment3.Name = "cbComment3";
            this.cbComment3.Size = new System.Drawing.Size(106, 21);
            this.cbComment3.TabIndex = 39;
            this.cbComment3.Text = "Hoàn Thành";
            this.cbComment3.UseVisualStyleBackColor = true;
            this.cbComment3.CheckedChanged += new System.EventHandler(this.cbComment3_CheckedChanged);
            // 
            // cbComment2
            // 
            this.cbComment2.AutoSize = true;
            this.cbComment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComment2.Location = new System.Drawing.Point(236, 129);
            this.cbComment2.Margin = new System.Windows.Forms.Padding(2);
            this.cbComment2.Name = "cbComment2";
            this.cbComment2.Size = new System.Drawing.Size(106, 21);
            this.cbComment2.TabIndex = 38;
            this.cbComment2.Text = "Hoàn Thành";
            this.cbComment2.UseVisualStyleBackColor = true;
            this.cbComment2.CheckedChanged += new System.EventHandler(this.cbComment2_CheckedChanged);
            // 
            // cbComment1
            // 
            this.cbComment1.AutoSize = true;
            this.cbComment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComment1.Location = new System.Drawing.Point(236, 15);
            this.cbComment1.Margin = new System.Windows.Forms.Padding(2);
            this.cbComment1.Name = "cbComment1";
            this.cbComment1.Size = new System.Drawing.Size(106, 21);
            this.cbComment1.TabIndex = 37;
            this.cbComment1.Text = "Hoàn Thành";
            this.cbComment1.UseVisualStyleBackColor = true;
            this.cbComment1.CheckedChanged += new System.EventHandler(this.cbComment1_CheckedChanged);
            // 
            // txtComment1
            // 
            this.txtComment1.Location = new System.Drawing.Point(15, 40);
            this.txtComment1.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment1.Multiline = true;
            this.txtComment1.Name = "txtComment1";
            this.txtComment1.Size = new System.Drawing.Size(320, 77);
            this.txtComment1.TabIndex = 36;
            this.txtComment1.TextChanged += new System.EventHandler(this.txtComment1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tiến Độ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(114, 358);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(229, 20);
            this.progressBar.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 272);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 71);
            this.textBox3.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(121, 397);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 38);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(13, 239);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(122, 23);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Lần 3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(13, 125);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 23);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Lần 2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(15, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(122, 23);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Lần 1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 71);
            this.textBox2.TabIndex = 3;
            // 
            // ProgressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 446);
            this.Controls.Add(this.panel1);
            this.Name = "ProgressView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiến Độ Đề Tài";
            this.Load += new System.EventHandler(this.ProgressProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment1;
        private System.Windows.Forms.CheckBox cbComment3;
        private System.Windows.Forms.CheckBox cbComment2;
        private System.Windows.Forms.CheckBox cbComment1;
    }
}