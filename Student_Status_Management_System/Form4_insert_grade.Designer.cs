namespace Student_Status_Management_System
{
    partial class Form4_insert_grade
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
            this.txt_cno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cno
            // 
            this.txt_cno.Location = new System.Drawing.Point(182, 54);
            this.txt_cno.Name = "txt_cno";
            this.txt_cno.Size = new System.Drawing.Size(161, 25);
            this.txt_cno.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "请输入课程号：";
            // 
            // txt_sno
            // 
            this.txt_sno.Location = new System.Drawing.Point(182, 99);
            this.txt_sno.Name = "txt_sno";
            this.txt_sno.Size = new System.Drawing.Size(161, 25);
            this.txt_sno.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "请输入学号：";
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(182, 141);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(161, 25);
            this.txt_grade.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "请输入成绩：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4_insert_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_grade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cno);
            this.Controls.Add(this.label1);
            this.Name = "Form4_insert_grade";
            this.Text = "Form4_insert_grade";
            this.Load += new System.EventHandler(this.Form4_insert_grade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}