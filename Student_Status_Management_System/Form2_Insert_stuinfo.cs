using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Status_Management_System
{
    public partial class Form2_Insert_stuinfo : Form
    {
        public Form2_Insert_stuinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Text = txt_sno.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
                SqlConnection mycon = new SqlConnection(con);
                mycon.Open();

                SqlCommand cmd = mycon.CreateCommand();
                student stu = new student();
                stu.sno = txt_sno.Text;
                stu.sname = txt_sname.Text;
                stu.ssex = txt_ssex.Text;
                stu.sbirth = txt_sbirth.Text;
                stu.smajor = txt_smajor.Text;
                stu.scollege = txt_scollege.Text;

                string sql = "insert into student (sno,sname,ssex,sbirth,smajor,scollege) values('" + stu.sno + "','" + stu.sname + "','" + stu.ssex + "','" + stu.sbirth + "','" + stu.smajor + "','" + stu.scollege + "' )";
                //Console.WriteLine(sql);
                cmd.CommandText = sql;
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("插入成功");
                }
                else
                {
                    MessageBox.Show("插入失败");
                }

                mycon.Close();
            }
            catch
            {
                MessageBox.Show("插入失败");
            }
            
        }

        private void Form2_Insert_stuinfo_Load(object sender, EventArgs e)
        {
            this.Text = "录入学生信息";
        }
    }
}
