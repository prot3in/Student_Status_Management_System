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
    public partial class Form4_insert_grade : Form
    {
        public Form4_insert_grade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Server=.;Database=Student_Status_Management_System;Trusted_Connection=SSPI";
            using (SqlConnection mycon = new SqlConnection(con)) 
            {
                try
                {
                    mycon.Open();
                    SqlCommand cmd = mycon.CreateCommand();
                    cmd.CommandText = "update sc set grade = " + txt_grade.Text + " where sno = '" + txt_sno.Text + "' and cno = '" + txt_cno.Text + "'";
                    Console.WriteLine(cmd.CommandText);
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("录入成功！");
                    }
                    else
                    {
                        MessageBox.Show("录入失败！");
                    }
                    mycon.Close();
                }
                catch
                {
                    MessageBox.Show("录入失败！");
                }
                
               
            } 
            
        }

        private void Form4_insert_grade_Load(object sender, EventArgs e)
        {
            this.Text = "录入成绩";
        }
    }
}
