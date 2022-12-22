namespace projekPPK
{
    partial class adminChildSignUp
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
            this.Email = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Retype = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Email.Location = new System.Drawing.Point(238, 320);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(201, 21);
            this.Email.TabIndex = 40;
            this.Email.Text = "Email";
            this.Email.Enter += new System.EventHandler(this.tb_enter);
            this.Email.Leave += new System.EventHandler(this.tb_leave);
            // 
            // Nama
            // 
            this.Nama.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Nama.Location = new System.Drawing.Point(238, 232);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(201, 21);
            this.Nama.TabIndex = 39;
            this.Nama.Tag = "";
            this.Nama.Text = "Nama";
            this.Nama.Enter += new System.EventHandler(this.tb_enter);
            this.Nama.Leave += new System.EventHandler(this.tb_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(446, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Password Salah!";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Retype
            // 
            this.Retype.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retype.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Retype.Location = new System.Drawing.Point(569, 303);
            this.Retype.Name = "Retype";
            this.Retype.Size = new System.Drawing.Size(201, 21);
            this.Retype.TabIndex = 37;
            this.Retype.Text = "Retype";
            this.Retype.UseSystemPasswordChar = true;
            this.Retype.Enter += new System.EventHandler(this.tb_enter);
            this.Retype.Leave += new System.EventHandler(this.tb_leave);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("News706 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(461, 372);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(104, 33);
            this.bt1.TabIndex = 36;
            this.bt1.Text = "SIGN UP";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Password.Location = new System.Drawing.Point(569, 251);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(201, 21);
            this.Password.TabIndex = 35;
            this.Password.Text = "Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.tb_enter);
            this.Password.Leave += new System.EventHandler(this.tb_leave);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Username.Location = new System.Drawing.Point(238, 274);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(201, 21);
            this.Username.TabIndex = 34;
            this.Username.Tag = "";
            this.Username.Text = "Username";
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            this.Username.Enter += new System.EventHandler(this.tb_enter);
            this.Username.Leave += new System.EventHandler(this.tb_leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label17.Location = new System.Drawing.Point(-441, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(459, 57);
            this.label17.TabIndex = 56;
            this.label17.Text = "CLASSIC-WEAR";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label28.Location = new System.Drawing.Point(-441, 439);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(459, 57);
            this.label28.TabIndex = 67;
            this.label28.Text = "CLASSIC-WEAR";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Clarendon BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label37.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label37.Location = new System.Drawing.Point(267, 124);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(493, 57);
            this.label37.TabIndex = 76;
            this.label37.Text = "REGISTER ADMIN";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adminChildSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1022, 486);
            this.ControlBox = false;
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Retype);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adminChildSignUp";
            this.Load += new System.EventHandler(this.signUpAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Retype;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label37;
    }
}