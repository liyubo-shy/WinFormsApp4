using System.ComponentModel;
using System.Data;

namespace WinFormsApp3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("����д�˺�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //У���˺�����
            string sql = "select * from [user] where no = '" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            IDataReader dataReader = DAO.Query(sql);
            if (dataReader.Read()) {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("�˺Ż��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataReader.Close();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        /*
        private void label1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), e.ClipRectangle);
        }
        */
    }
}