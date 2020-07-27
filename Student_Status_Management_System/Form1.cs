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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "学生信息管理系统";


        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    stuinfo.Items.Clear();
        //    string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
        //    SqlConnection mycon = new SqlConnection(con);
        //    mycon.Open();
        //    SqlCommand cmd = mycon.CreateCommand();
        //    cmd.CommandText = "select * from student";
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    student stu = null;
        //    List<student> stulist = new List<student>();
        //        while ( dr.Read() )
        //        {

        //            stu = new student();                    
        //            stu.sno = dr[0].ToString();
        //            stu.sname = dr[1].ToString();
        //            stu.ssex = dr[2].ToString();

        //            DateTime t1 = Convert.ToDateTime(dr[3].ToString());
        //            stu.sbirth = t1.ToString("yyyy-MM-dd");

        //            stu.smajor = dr[4].ToString();
        //            stu.scollege = dr[5].ToString();
        //            stulist.Add(stu);
        //        }
        //    foreach (student stud in stulist)
        //    {
        //        stuinfo.Items.Add(stud.sno+ ',' + stud.sname.Substring(0,5) + ',' + stud.ssex + ',' + stud.sbirth + ',' + stud.smajor + ',' + stud.scollege);
        //    }
        //    mycon.Close();
        //}

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Form  form2 = new Form2_Insert_stuinfo();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3_select_stuinfo();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4_insert_grade();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5_select_stugrade();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6_select_teachers();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7_select_expel();
            form7.Show();
        }
    }
}
