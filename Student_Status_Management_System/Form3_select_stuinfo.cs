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
    public partial class Form3_select_stuinfo : Form
    {
        public Form3_select_stuinfo()
        {
            InitializeComponent();
        }

        private void Form3_select_stuinfo_Load(object sender, EventArgs e)
        {
            this.Text = "查询学生信息" ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton1.Checked )
            { label1.Text = "请输入学号："; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            { label1.Text = "请输入姓名："; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stuinfo.Items.Clear();
            List<student> stulist = Get_Stuinfo(radioButton1.Checked, radioButton2.Checked, textBox1.Text);
            foreach (student stud in stulist)
            {
                stuinfo.Items.Add(stud.sno + ',' + stud.sname.Substring(0, 5) + ',' + stud.ssex + ',' + stud.sbirth + ',' + stud.smajor + ',' + stud.scollege);
            }
           
        }

        private List<student> Get_Stuinfo(Boolean rad1,Boolean rad2,string txt)
        {
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = mycon.CreateCommand();
            if (rad1)//学号查找
            {
                cmd.CommandText = "select * from student where sno = '" + textBox1.Text + "'";

            }
            else if (rad2)
            {
                cmd.CommandText = "select * from student where sname = '" + textBox1.Text + "'";
            }

            SqlDataReader dr = cmd.ExecuteReader();
            student stu = null;
            List<student> stulist = new List<student>();
            while (dr.Read())
            {

                stu = new student();
                stu.sno = dr[0].ToString();
                stu.sname = dr[1].ToString();
                stu.ssex = dr[2].ToString();

                DateTime t1 = Convert.ToDateTime(dr[3].ToString());
                stu.sbirth = t1.ToString("yyyy-MM-dd");

                stu.smajor = dr[4].ToString();
                stu.scollege = dr[5].ToString();
                stulist.Add(stu);
            }
            mycon.Close();
            return stulist;
        }
    }
}
