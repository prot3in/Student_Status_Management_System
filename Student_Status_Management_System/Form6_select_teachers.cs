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
    public partial class Form6_select_teachers : Form
    {
        public Form6_select_teachers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tinfo.Items.Clear();
            List<teacher> teachers = Get_Teachers(txt_sno.Text);
           
            foreach (teacher teacher in teachers)
            {
                tinfo.Items.Add(teacher.tname+":"+teacher.cname);
            }
        }

        private List<teacher> Get_Teachers(string sno)
        {
            List<teacher> teachers = new List<teacher>();
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            using (SqlConnection mycon = new SqlConnection(con))
            {
                mycon.Open();
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = "select tname,cname from tc,course,teacher,sc where sno ='" + txt_sno.Text + "' and sc.cno = course.cno and sc.cno = tc.cno and teacher.tno = tc.tno";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    teacher tea = new teacher();
                    tea.tname = dr[0].ToString();
                    tea.cname = dr[1].ToString();
                    teachers.Add(tea);
                }
            }



            return teachers;
        }

        private void Form6_select_teachers_Load(object sender, EventArgs e)
        {
            this.Text = "查询学生被哪些老师教过";
        }
    }
}
