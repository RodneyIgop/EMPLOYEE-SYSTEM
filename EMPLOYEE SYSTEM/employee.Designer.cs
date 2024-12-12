namespace EMPLOYEE_SYSTEM
{
    partial class employees
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.empstatuscombobx = new System.Windows.Forms.ComboBox();
            this.empClearbtn = new System.Windows.Forms.Button();
            this.empDeleterbtn = new System.Windows.Forms.Button();
            this.empUpdatebtn = new System.Windows.Forms.Button();
            this.empAddbtn = new System.Windows.Forms.Button();
            this.empdepartmentcombox = new System.Windows.Forms.ComboBox();
            this.empGendercombbox = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.addrssmaskedTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.empContacttxtbox = new System.Windows.Forms.TextBox();
            this.empPositiontxtbox = new System.Windows.Forms.TextBox();
            this.empnametxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(867, 286);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(340, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 376);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLOYEES DATA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.empstatuscombobx);
            this.panel2.Controls.Add(this.empClearbtn);
            this.panel2.Controls.Add(this.empDeleterbtn);
            this.panel2.Controls.Add(this.empUpdatebtn);
            this.panel2.Controls.Add(this.empAddbtn);
            this.panel2.Controls.Add(this.empdepartmentcombox);
            this.panel2.Controls.Add(this.empGendercombbox);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.addrssmaskedTxtbox);
            this.panel2.Controls.Add(this.empContacttxtbox);
            this.panel2.Controls.Add(this.empPositiontxtbox);
            this.panel2.Controls.Add(this.empnametxtbox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(340, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 230);
            this.panel2.TabIndex = 3;
            // 
            // empstatuscombobx
            // 
            this.empstatuscombobx.FormattingEnabled = true;
            this.empstatuscombobx.Items.AddRange(new object[] {
            "MALE ",
            "FEMALE"});
            this.empstatuscombobx.Location = new System.Drawing.Point(402, 162);
            this.empstatuscombobx.Name = "empstatuscombobx";
            this.empstatuscombobx.Size = new System.Drawing.Size(121, 21);
            this.empstatuscombobx.TabIndex = 22;
            // 
            // empClearbtn
            // 
            this.empClearbtn.Font = new System.Drawing.Font("Arial", 12.75F);
            this.empClearbtn.Location = new System.Drawing.Point(741, 170);
            this.empClearbtn.Name = "empClearbtn";
            this.empClearbtn.Size = new System.Drawing.Size(91, 34);
            this.empClearbtn.TabIndex = 21;
            this.empClearbtn.Text = "CLEAR";
            this.empClearbtn.UseVisualStyleBackColor = true;
            // 
            // empDeleterbtn
            // 
            this.empDeleterbtn.Font = new System.Drawing.Font("Arial", 12.75F);
            this.empDeleterbtn.Location = new System.Drawing.Point(741, 118);
            this.empDeleterbtn.Name = "empDeleterbtn";
            this.empDeleterbtn.Size = new System.Drawing.Size(91, 34);
            this.empDeleterbtn.TabIndex = 20;
            this.empDeleterbtn.Text = "DELETE";
            this.empDeleterbtn.UseVisualStyleBackColor = true;
            // 
            // empUpdatebtn
            // 
            this.empUpdatebtn.Font = new System.Drawing.Font("Arial", 12.75F);
            this.empUpdatebtn.Location = new System.Drawing.Point(741, 68);
            this.empUpdatebtn.Name = "empUpdatebtn";
            this.empUpdatebtn.Size = new System.Drawing.Size(91, 34);
            this.empUpdatebtn.TabIndex = 19;
            this.empUpdatebtn.Text = "UPDATE";
            this.empUpdatebtn.UseVisualStyleBackColor = true;
            // 
            // empAddbtn
            // 
            this.empAddbtn.Font = new System.Drawing.Font("Arial", 12.75F);
            this.empAddbtn.Location = new System.Drawing.Point(741, 21);
            this.empAddbtn.Name = "empAddbtn";
            this.empAddbtn.Size = new System.Drawing.Size(91, 34);
            this.empAddbtn.TabIndex = 18;
            this.empAddbtn.Text = "ADD";
            this.empAddbtn.UseVisualStyleBackColor = true;
            this.empAddbtn.Click += new System.EventHandler(this.empAddbtn_Click);
            // 
            // empdepartmentcombox
            // 
            this.empdepartmentcombox.FormattingEnabled = true;
            this.empdepartmentcombox.Items.AddRange(new object[] {
            "MALE ",
            "FEMALE"});
            this.empdepartmentcombox.Location = new System.Drawing.Point(151, 152);
            this.empdepartmentcombox.Name = "empdepartmentcombox";
            this.empdepartmentcombox.Size = new System.Drawing.Size(121, 21);
            this.empdepartmentcombox.TabIndex = 17;
            this.empdepartmentcombox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // empGendercombbox
            // 
            this.empGendercombbox.FormattingEnabled = true;
            this.empGendercombbox.Items.AddRange(new object[] {
            "MALE ",
            "FEMALE"});
            this.empGendercombbox.Location = new System.Drawing.Point(119, 77);
            this.empGendercombbox.Name = "empGendercombbox";
            this.empGendercombbox.Size = new System.Drawing.Size(121, 21);
            this.empGendercombbox.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(402, 117);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 25);
            this.textBox5.TabIndex = 14;
            // 
            // addrssmaskedTxtbox
            // 
            this.addrssmaskedTxtbox.Location = new System.Drawing.Point(402, 83);
            this.addrssmaskedTxtbox.Mask = "00/00/0000";
            this.addrssmaskedTxtbox.Name = "addrssmaskedTxtbox";
            this.addrssmaskedTxtbox.Size = new System.Drawing.Size(90, 20);
            this.addrssmaskedTxtbox.TabIndex = 13;
            this.addrssmaskedTxtbox.ValidatingType = typeof(System.DateTime);
            // 
            // empContacttxtbox
            // 
            this.empContacttxtbox.Location = new System.Drawing.Point(402, 42);
            this.empContacttxtbox.Name = "empContacttxtbox";
            this.empContacttxtbox.Size = new System.Drawing.Size(100, 20);
            this.empContacttxtbox.TabIndex = 12;
            this.empContacttxtbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // empPositiontxtbox
            // 
            this.empPositiontxtbox.Location = new System.Drawing.Point(119, 118);
            this.empPositiontxtbox.Name = "empPositiontxtbox";
            this.empPositiontxtbox.Size = new System.Drawing.Size(100, 20);
            this.empPositiontxtbox.TabIndex = 11;
            // 
            // empnametxtbox
            // 
            this.empnametxtbox.Location = new System.Drawing.Point(119, 39);
            this.empnametxtbox.Multiline = true;
            this.empnametxtbox.Name = "empnametxtbox";
            this.empnametxtbox.Size = new System.Drawing.Size(100, 20);
            this.empnametxtbox.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label10.Location = new System.Drawing.Point(302, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "STATUS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label9.Location = new System.Drawing.Point(302, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label8.Location = new System.Drawing.Point(302, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "BIRTHDATE ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label7.Location = new System.Drawing.Point(302, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "CONTACT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label6.Location = new System.Drawing.Point(28, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "DEPARTMENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label5.Location = new System.Drawing.Point(28, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "POSITION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label4.Location = new System.Drawing.Point(28, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "GENDER";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1234, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMPLOYEE_SYSTEM.Properties.Resources.empbg69_transformed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employees";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empContacttxtbox;
        private System.Windows.Forms.TextBox empPositiontxtbox;
        private System.Windows.Forms.TextBox empnametxtbox;
        private System.Windows.Forms.ComboBox empGendercombbox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MaskedTextBox addrssmaskedTxtbox;
        private System.Windows.Forms.Button empClearbtn;
        private System.Windows.Forms.Button empDeleterbtn;
        private System.Windows.Forms.Button empUpdatebtn;
        private System.Windows.Forms.Button empAddbtn;
        private System.Windows.Forms.ComboBox empdepartmentcombox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox empstatuscombobx;
    }
}