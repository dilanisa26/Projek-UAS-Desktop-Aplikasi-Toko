namespace projekPPK
{
    partial class userChildSignUp
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
            this.NomorHP = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Retype = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomorHP
            // 
            this.NomorHP.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomorHP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.NomorHP.Location = new System.Drawing.Point(157, 286);
            this.NomorHP.Name = "NomorHP";
            this.NomorHP.Size = new System.Drawing.Size(201, 21);
            this.NomorHP.TabIndex = 31;
            this.NomorHP.Text = "NomorHP";
            this.NomorHP.Enter += new System.EventHandler(this.tb_enter);
            this.NomorHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomorHp_keypress);
            this.NomorHP.Leave += new System.EventHandler(this.tb_leave);
            // 
            // Nama
            // 
            this.Nama.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Nama.Location = new System.Drawing.Point(157, 175);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(201, 21);
            this.Nama.TabIndex = 30;
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
            this.label2.Location = new System.Drawing.Point(366, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Password Salah!";
            this.label2.Visible = false;
            // 
            // Retype
            // 
            this.Retype.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retype.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Retype.Location = new System.Drawing.Point(513, 259);
            this.Retype.Name = "Retype";
            this.Retype.Size = new System.Drawing.Size(201, 21);
            this.Retype.TabIndex = 28;
            this.Retype.Text = "Retype";
            this.Retype.UseSystemPasswordChar = true;
            this.Retype.TextChanged += new System.EventHandler(this.Retype_TextChanged);
            this.Retype.Enter += new System.EventHandler(this.tb_enter);
            this.Retype.Leave += new System.EventHandler(this.tb_leave);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("News706 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(392, 362);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(81, 33);
            this.bt1.TabIndex = 27;
            this.bt1.Text = "SIGN UP";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click_1);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Password.Location = new System.Drawing.Point(513, 191);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(201, 21);
            this.Password.TabIndex = 26;
            this.Password.Text = "Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.Enter += new System.EventHandler(this.tb_enter);
            this.Password.Leave += new System.EventHandler(this.tb_leave);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Username.Location = new System.Drawing.Point(157, 232);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(201, 21);
            this.Username.TabIndex = 25;
            this.Username.Tag = "";
            this.Username.Text = "Username";
            this.Username.Enter += new System.EventHandler(this.tb_enter);
            this.Username.Leave += new System.EventHandler(this.tb_leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(1141, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 44);
            this.label9.TabIndex = 42;
            this.label9.Text = "CLASSIC-WEAR";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Clarendon BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label40.Location = new System.Drawing.Point(248, 90);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(348, 45);
            this.label40.TabIndex = 71;
            this.label40.Text = "REGISTER USER";
            // 
            // userChildSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NomorHP);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Retype);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "userChildSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.userChildSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomorHP;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Retype;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label40;
    }
}