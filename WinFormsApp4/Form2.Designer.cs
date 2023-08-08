namespace WinFormsApp3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            sex = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            修改ToolStripMenuItem = new ToolStripMenuItem();
            删除ToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, no, name, sex, age, phone });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(969, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // no
            // 
            no.HeaderText = "账号";
            no.MinimumWidth = 6;
            no.Name = "no";
            no.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "姓名";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // sex
            // 
            sex.HeaderText = "性别";
            sex.MinimumWidth = 6;
            sex.Name = "sex";
            sex.ReadOnly = true;
            // 
            // age
            // 
            age.HeaderText = "年龄";
            age.MinimumWidth = 6;
            age.Name = "age";
            age.ReadOnly = true;
            // 
            // phone
            // 
            phone.HeaderText = "手机号";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 修改ToolStripMenuItem, 删除ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // 修改ToolStripMenuItem
            // 
            修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            修改ToolStripMenuItem.Size = new Size(210, 24);
            修改ToolStripMenuItem.Text = "修改";
            修改ToolStripMenuItem.Click += 修改ToolStripMenuItem_Click;
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(210, 24);
            删除ToolStripMenuItem.Text = "删除";
            删除ToolStripMenuItem.Click += 删除ToolStripMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "男", "女" });
            comboBox1.Location = new Point(72, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(57, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "性别：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 26);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "姓名：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 30);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "账号：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(406, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(568, 16);
            button2.Name = "button2";
            button2.Size = new Size(87, 41);
            button2.TabIndex = 8;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(754, 18);
            button3.Name = "button3";
            button3.Size = new Size(83, 39);
            button3.TabIndex = 9;
            button3.Text = "新增";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(843, 18);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 10;
            button4.Text = "刷新";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(661, 18);
            button1.Name = "button1";
            button1.Size = new Size(87, 39);
            button1.TabIndex = 11;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 488);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "用户信息管理";
            FormClosed += Form2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn phone;
        private Button button4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private Button button1;
        private static DataGridView dataGridView1;
    }
}