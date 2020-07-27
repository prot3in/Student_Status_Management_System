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
    public partial class Form7_select_expel : Form
    {
        public Form7_select_expel()
        {
            InitializeComponent();
        }

        private void Form7_select_expel_Load(object sender, EventArgs e)
        {
            this.Text = "查询快被开除的学生";
            listBox1.Items.Clear();
            List<student> expelled_students = new List<student>();
            List<student> all_students = Get_All_Student();
            foreach(student stu in all_students)
            {
                if (expel_checked(stu))
                {
                    expelled_students.Add(stu);
                }
            }
            foreach(student stu in expelled_students)
            {
                listBox1.Items.Add(stu.sname);
            }




        }
        private List<student> Get_All_Student()
        {
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = mycon.CreateCommand();
            cmd.CommandText = "select * from student";
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
        private Boolean expel_checked(student stu)
        {   //  1: 一学期不及格的必修课学分超过10个；
            //  2: 不及格必修课学分累计超过30个；
            //  3: 不及格选修课学分累计超过20个。
            if (checked1(stu) || checked2(stu) || checked3(stu))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean checked1(student stu)
        {
            string sql = "select term, sum(credit) from sc, course where sno = '" + stu.sno + "' and grade<60 and sc.cno = course.cno and sc.ctype = 1 group by term";
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = mycon.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int sum;
                if (int.TryParse(dr[1].ToString(),out sum))
                {
                    if (sum > 10)
                    {
                        return true;
                    }
                }
                
            }
            mycon.Close();
            return false;
        }
        private Boolean checked2(student stu)
        {
            string sql = "select sum(credit) from sc, course where sno = '"+ stu.sno +"' and grade<60 and sc.ctype = 1 and sc.cno = course.cno ";
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            using(SqlConnection mycon = new SqlConnection(con))
            {
                mycon.Open();
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.IsDBNull(0))
                {
                    return false;
                }
                else
                {
                    int sum = int.Parse(dr[0].ToString());
                    if (sum <= 30)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            

            

        }
        private Boolean checked3(student stu)
        {
            string sql = "select sum(credit) from sc, course where sno = '" + stu.sno + "' and grade<60 and sc.ctype = 3 and sc.cno = course.cno ";
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = mycon.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            
            if (dr.IsDBNull(0))
            {
                return false;
            }
            else
            {
                int sum = int.Parse(dr[0].ToString());
                if (sum <= 20)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
