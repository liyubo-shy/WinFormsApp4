using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp3 {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        public Form3(string[] str) {
            InitializeComponent();
            textBox1.Text = str[0];
            textBox3.Text = str[1];
            comboBox1.Text = str[2];
            textBox5.Text = str[3];
            textBox6.Text = str[4];
            label11.Text = str[5];
            textBox2.Visible = false;
            this.Text = "修改";
            label5.Visible = false;
            label8.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                MessageBox.Show("账号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text == "" & this.Text == "新增") {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textBox3.Text == "") {
                MessageBox.Show("姓名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (comboBox1.Text == "") {
                MessageBox.Show("性别不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string sql;

            //判断新增或修改
            if (this.Text == "新增") {
                //新增
                if (textBox5.Text == "" || textBox6.Text == "") {
                    if (textBox5.Text == "" & textBox6.Text == "") {
                        //年龄电话都为空
                        sql = "INSERT into [user] values ('" + textBox3.Text + "',null,null,'" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "',null)";

                    }
                    else if (textBox5.Text == "") {
                        //仅年龄为空
                        sql = "INSERT into [user] values ('" + textBox3.Text + "',null,null,'" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "')";

                    }
                    else {
                        //仅电话为空
                        sql = "INSERT into [user] values ('" + textBox3.Text + "','" + textBox5.Text + "',null,'" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "',null)";

                    }
                }
                else {
                    //年龄电话都不为空
                    sql = "INSERT into [user] values ('" + textBox3.Text + "','" + textBox5.Text + "',null,'" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "')";
                }
            }
            else {
                //修改
                if (textBox5.Text == "" || textBox6.Text == "") {
                    if (textBox5.Text == "" & textBox6.Text == "") {
                        //年龄电话都为空
                        sql = "update [user] set no ='" + textBox1.Text + "',name = '" + textBox3.Text + "',sex = '" + comboBox1.Text + "'where id = '" + label11.Text + "'";

                    }
                    else if (textBox5.Text == "") {
                        //仅年龄为空
                        sql = "update [user] set no ='" + textBox1.Text + "',name = '" + textBox3.Text + "',sex = '" + comboBox1.Text + "',phone = '" + textBox6.Text + "'where id = '" + label11.Text + "'";

                    }
                    else {
                        //仅电话为空
                        sql = "update [user] set no ='" + textBox1.Text + "',name = '" + textBox3.Text + "',sex = '" + comboBox1.Text + "',age = '" + textBox5.Text + "'where id = '" + label11.Text + "'";

                    }
                }
                else {
                    //年龄电话都不为空
                    sql = "update [user] set no ='" + textBox1.Text + "',name = '" + textBox3.Text + "',sex = '" + comboBox1.Text + "',age = '" + textBox5.Text + "',phone = '" + textBox6.Text + "'where id = '" + label11.Text + "'";
                }

            }



            try {
                DAO.Execute(sql);

            }
            catch (SqlException ex) {
                MessageBox.Show(this.Text + "失败:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show(this.Text + "成功");

            this.Close();

            Form2.GetTableData();

        }
    }
}
