
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            GetTableData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            comboBox1.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }


        public static void HandleData(IDataReader dataReader) {

            dataGridView1.Rows.Clear();
            while (dataReader.Read()) {
                string id, no, name, sex, age, phone;
                id = dataReader["id"].ToString();
                no = dataReader["no"].ToString();
                name = dataReader["name"].ToString();
                sex = dataReader["sex"].ToString();
                age = dataReader["age"].ToString();
                phone = dataReader["phone"].ToString();

                string[] tableDate = { id, no, name, sex, age, phone };

                dataGridView1.Rows.Add(tableDate);

            }
            dataReader.Close();
        }
        public static void GetTableData() {
            string sql = "select * from [user]";
            IDataReader dataReader = DAO.Query(sql);
            HandleData(dataReader);

        }

        private void button4_Click(object sender, EventArgs e) {
            GetTableData();
        }

        private void button1_Click(object sender, EventArgs e) {
            string sql = "select * from [user] where 1=1";
            if (comboBox1.Text != "") {
                sql = sql + "and sex = '" + comboBox1.Text + "'";
            }
            if (textBox1.Text != "") {
                sql = sql + "and name like '%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "") {
                sql = sql + "and no like '%" + textBox2.Text + "%'";
            }


            IDataReader dataReader = DAO.Query(sql);
            HandleData(dataReader);


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            string sql = "select * from [user] where 1=1";
            if (comboBox1.Text != "") {
                sql = sql + "and sex = '" + comboBox1.Text + "'";
            }
            if (textBox1.Text != "") {
                sql = sql + "and name like '%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "") {
                sql = sql + "and no like '%" + textBox2.Text + "%'";
            }


            IDataReader dataReader = DAO.Query(sql);
            HandleData(dataReader);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("是否确认删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) {
                return;
            }


            string id, name;

            id = dataGridView1.SelectedCells[0].Value.ToString();
            name = dataGridView1.SelectedCells[1].Value.ToString();
            string sql = "delete from [user] where id = '" + id + "'and no = '" + name + "'";

            int affectedRows = DAO.Execute(sql);
            if (affectedRows > 0) {
                MessageBox.Show("删除成功");
            }
            else {
                MessageBox.Show("删除失败" + sql, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            GetTableData();



        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e) {
            string[] str = new string[6];
            str[0] = dataGridView1.SelectedCells[1].Value.ToString();
            str[1] = dataGridView1.SelectedCells[2].Value.ToString();
            str[2] = dataGridView1.SelectedCells[3].Value.ToString();
            str[3] = dataGridView1.SelectedCells[4].Value.ToString();
            str[4] = dataGridView1.SelectedCells[5].Value.ToString();
            str[5] = dataGridView1.SelectedCells[0].Value.ToString();
            Form3 form3 = new Form3(str);
            form3.ShowDialog();
           

        }
    }
}
