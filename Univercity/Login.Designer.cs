namespace University
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelLostPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelClearFields = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(236, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPassword.Location = new System.Drawing.Point(6, 7);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(365, 28);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(786, 32);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 42);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelLostPassword
            // 
            this.labelLostPassword.AutoSize = true;
            this.labelLostPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLostPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelLostPassword.Location = new System.Drawing.Point(348, 509);
            this.labelLostPassword.Name = "labelLostPassword";
            this.labelLostPassword.Size = new System.Drawing.Size(145, 25);
            this.labelLostPassword.TabIndex = 5;
            this.labelLostPassword.Text = "Lost password ?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Location = new System.Drawing.Point(236, 315);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel1.Size = new System.Drawing.Size(380, 45);
            this.panel1.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLogin.Location = new System.Drawing.Point(7, 6);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(364, 28);
            this.textBoxLogin.TabIndex = 8;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Location = new System.Drawing.Point(236, 378);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel2.Size = new System.Drawing.Size(380, 45);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 277);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelLogin.Location = new System.Drawing.Point(30, 320);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(193, 30);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Username or email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelPassword.Location = new System.Drawing.Point(123, 389);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 25);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelClearFields
            // 
            this.labelClearFields.AutoSize = true;
            this.labelClearFields.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClearFields.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelClearFields.Location = new System.Drawing.Point(524, 426);
            this.labelClearFields.Name = "labelClearFields";
            this.labelClearFields.Size = new System.Drawing.Size(91, 21);
            this.labelClearFields.TabIndex = 11;
            this.labelClearFields.Text = "Clear fields";
            this.labelClearFields.Click += new System.EventHandler(this.labelClearFields_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(237, 424);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(143, 25);
            this.checkBoxShowPassword.TabIndex = 4;
            this.checkBoxShowPassword.Text = "Show password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(907, 579);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelClearFields);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLostPassword);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBoxPassword;
        private Button buttonBack;
        private Label labelLostPassword;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxLogin;
        private PictureBox pictureBox1;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelClearFields;
        private CheckBox checkBoxShowPassword;
    }
}