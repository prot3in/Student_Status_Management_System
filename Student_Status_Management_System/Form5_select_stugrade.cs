using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Status_Management_System
{
    public partial class Form5_select_stugrade : Form
    {
        public Form5_select_stugrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                scinfo.Items.Clear();
                List<sc> scs = Get_Grades(txt_sno.Text);
                lbl_avg_b.Text = "必修课平均分：" + Get_Average_Bixiu(txt_sno.Text);
                lbl_avg_all.Text = "所有课平均分：" + Get_Average_All(txt_sno.Text);
                foreach (sc sc in scs)
                {
                    scinfo.Items.Add(sc.cname + ":" + sc.grade.ToString());
                }
           }
            catch
            {
                MessageBox.Show("成绩未录入！");
            }


        }



        private List<sc> Get_Grades(string sno)
        {
            List<sc> scs = new List<sc>();
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            using (SqlConnection mycon = new SqlConnection(con))
            {
                mycon.Open();
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = "select cname,grade from sc,course where sno ='" + txt_sno.Text + "' and sc.cno = course.cno";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    sc sc1 = new sc();
                    sc1.cname = dr[0].ToString();
                    sc1.grade = int.Parse(dr[1].ToString());
                    scs.Add(sc1);
                }
            }
            return scs;
        }
        private string Get_Average_Bixiu(string sno)
        {
            string average_bixiu = "";
            int count, sum;
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            using (SqlConnection mycon = new SqlConnection(con))
            {
                mycon.Open();
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = "select sum(grade),count(grade) from sc where sno ='" + txt_sno.Text + "' and ctype = 1";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Console.WriteLine(dr[0].ToString());
                sum = int.Parse(dr[0].ToString());
                count = int.Parse(dr[1].ToString());
              
                

            }
            
            average_bixiu = ((double)sum / count).ToString("#0.000");
            return average_bixiu;
        }
        private string Get_Average_All(string sno)
        {
            string average_all = "";
            int count, sum;
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            using (SqlConnection mycon = new SqlConnection(con))
            {
                mycon.Open();
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = "select sum(grade),count(grade) from sc where sno ='" + txt_sno.Text + "' ";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                sum = int.Parse(dr[0].ToString());
                count = int.Parse(dr[1].ToString());

            }

            average_all = ((double)sum / count).ToString("#0.000");
            return average_all;
        }

        private void Form5_select_stugrade_Load(object sender, EventArgs e)
        {
            this.Text = "查询成绩";
        }
    }
}
