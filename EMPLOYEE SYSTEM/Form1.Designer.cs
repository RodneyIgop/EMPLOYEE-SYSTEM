namespace EMPLOYEE_SYSTEM
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.forgetpassbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.dnthvaccLabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwrdLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwrdTxtbox = new System.Windows.Forms.TextBox();
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.forgetpassbtn);
            this.panel1.Controls.Add(this.signupbtn);
            this.panel1.Controls.Add(this.dnthvaccLabel);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.passwrdLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwrdTxtbox);
            this.panel1.Controls.Add(this.usernameTxtbox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(465, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 482);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // forgetpassbtn
            // 
            this.forgetpassbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.forgetpassbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetpassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetpassbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassbtn.Location = new System.Drawing.Point(74, 410);
            this.forgetpassbtn.Name = "forgetpassbtn";
            this.forgetpassbtn.Size = new System.Drawing.Size(192, 28);
            this.forgetpassbtn.TabIndex = 10;
            this.forgetpassbtn.Text = "FORGET PASSWORD";
            this.forgetpassbtn.UseVisualStyleBackColor = false;
            this.forgetpassbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(118, 368);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(90, 28);
            this.signupbtn.TabIndex = 9;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // dnthvaccLabel
            // 
            this.dnthvaccLabel.AutoSize = true;
            this.dnthvaccLabel.BackColor = System.Drawing.Color.Transparent;
            this.dnthvaccLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnthvaccLabel.ForeColor = System.Drawing.Color.Black;
            this.dnthvaccLabel.Location = new System.Drawing.Point(81, 343);
            this.dnthvaccLabel.Name = "dnthvaccLabel";
            this.dnthvaccLabel.Size = new System.Drawing.Size(177, 17);
            this.dnthvaccLabel.TabIndex = 6;
            this.dnthvaccLabel.Text = "DON\'T HAVE ACCOUNT?";
            this.dnthvaccLabel.Click += new System.EventHandler(this.dnthvaccLabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("ITC Avant Garde Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(111, 299);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(110, 32);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "LOG IN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwrdLabel
            // 
            this.passwrdLabel.AutoSize = true;
            this.passwrdLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwrdLabel.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdLabel.ForeColor = System.Drawing.Color.Black;
            this.passwrdLabel.Location = new System.Drawing.Point(52, 230);
            this.passwrdLabel.Name = "passwrdLabel";
            this.passwrdLabel.Size = new System.Drawing.Size(106, 19);
            this.passwrdLabel.TabIndex = 4;
            this.passwrdLabel.Text = "PASSWORD";
            this.passwrdLabel.Click += new System.EventHandler(this.passwrdLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(52, 163);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 19);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "USERNAME";
            this.usernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwrdTxtbox
            // 
            this.passwrdTxtbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTxtbox.Location = new System.Drawing.Point(52, 254);
            this.passwrdTxtbox.Multiline = true;
            this.passwrdTxtbox.Name = "passwrdTxtbox";
            this.passwrdTxtbox.Size = new System.Drawing.Size(244, 29);
            this.passwrdTxtbox.TabIndex = 2;
            this.passwrdTxtbox.TextChanged += new System.EventHandler(this.passwrdTxtbox_TextChanged);
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbox.Location = new System.Drawing.Point(52, 185);
            this.usernameTxtbox.Multiline = true;
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(244, 29);
            this.usernameTxtbox.TabIndex = 1;
            this.usernameTxtbox.TextChanged += new System.EventHandler(this.usernameTxtbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("ITC Avant Garde Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(284, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.mainpanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwrdTxtbox;
        private System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.Label passwrdLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label dnthvaccLabel;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button forgetpassbtn;
        private System.Windows.Forms.Label label2;
    }
}

