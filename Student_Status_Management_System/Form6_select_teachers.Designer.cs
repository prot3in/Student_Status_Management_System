namespace Student_Status_Management_System
{
    partial class Form6_select_teachers
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tinfo = new System.Windows.Forms.ListBox();
            this.txt_sno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 91);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(202, 15);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "教他的老师和授课信息如下：";
            // 
            // tinfo
            // 
            this.tinfo.FormattingEnabled = true;
            this.tinfo.ItemHeight = 15;
            this.tinfo.Location = new System.Drawing.Point(58, 123);
            this.tinfo.Name = "tinfo";
            this.tinfo.Size = new System.Drawing.Size(323, 274);
            this.tinfo.TabIndex = 8;
            // 
            // txt_sno
            // 
            this.txt_sno.Location = new System.Drawing.Point(143, 36);
            this.txt_sno.Name = "txt_sno";
            this.txt_sno.Size = new System.Drawing.Size(154, 25);
            this.txt_sno.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入学号：";
            // 
            // Form6_select_teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tinfo);
            this.Controls.Add(this.txt_sno);
            this.Controls.Add(this.label1);
            this.Name = "Form6_select_teachers";
            this.Text = "Form6_select_teachers";
            this.Load += new System.EventHandler(this.Form6_select_teachers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox tinfo;
        private System.Windows.Forms.TextBox txt_sno;
        private System.Windows.Forms.Label label1;
    }
}