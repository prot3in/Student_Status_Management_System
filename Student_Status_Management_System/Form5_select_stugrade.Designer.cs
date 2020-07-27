namespace Student_Status_Management_System
{
    partial class Form5_select_stugrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sno = new System.Windows.Forms.TextBox();
            this.scinfo = new System.Windows.Forms.ListBox();
            this.lbl_avg_b = new System.Windows.Forms.Label();
            this.lbl_avg_all = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入学号：";
            // 
            // txt_sno
            // 
            this.txt_sno.Location = new System.Drawing.Point(134, 26);
            this.txt_sno.Name = "txt_sno";
            this.txt_sno.Size = new System.Drawing.Size(154, 25);
            this.txt_sno.TabIndex = 1;
            // 
            // scinfo
            // 
            this.scinfo.FormattingEnabled = true;
            this.scinfo.ItemHeight = 15;
            this.scinfo.Location = new System.Drawing.Point(49, 113);
            this.scinfo.Name = "scinfo";
            this.scinfo.Size = new System.Drawing.Size(323, 274);
            this.scinfo.TabIndex = 2;
            // 
            // lbl_avg_b
            // 
            this.lbl_avg_b.AutoSize = true;
            this.lbl_avg_b.Location = new System.Drawing.Point(46, 81);
            this.lbl_avg_b.Name = "lbl_avg_b";
            this.lbl_avg_b.Size = new System.Drawing.Size(112, 15);
            this.lbl_avg_b.TabIndex = 3;
            this.lbl_avg_b.Text = "必修课平均分：";
            // 
            // lbl_avg_all
            // 
            this.lbl_avg_all.AutoSize = true;
            this.lbl_avg_all.Location = new System.Drawing.Point(225, 81);
            this.lbl_avg_all.Name = "lbl_avg_all";
            this.lbl_avg_all.Size = new System.Drawing.Size(112, 15);
            this.lbl_avg_all.TabIndex = 4;
            this.lbl_avg_all.Text = "所有课平均分：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5_select_stugrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_avg_all);
            this.Controls.Add(this.lbl_avg_b);
            this.Controls.Add(this.scinfo);
            this.Controls.Add(this.txt_sno);
            this.Controls.Add(this.label1);
            this.Name = "Form5_select_stugrade";
            this.Text = "Form5_select_stugrade";
            this.Load += new System.EventHandler(this.Form5_select_stugrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sno;
        private System.Windows.Forms.ListBox scinfo;
        private System.Windows.Forms.Label lbl_avg_b;
        private System.Windows.Forms.Label lbl_avg_all;
        private System.Windows.Forms.Button button1;
    }
}