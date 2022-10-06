namespace University
{
    partial class test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.buttonAnsw1 = new System.Windows.Forms.Button();
            this.buttonAnsw2 = new System.Windows.Forms.Button();
            this.buttonAnsw3 = new System.Windows.Forms.Button();
            this.buttonAnsw4 = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnsw1
            // 
            this.buttonAnsw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAnsw1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnsw1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw1.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAnsw1.Location = new System.Drawing.Point(42, 244);
            this.buttonAnsw1.Name = "buttonAnsw1";
            this.buttonAnsw1.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw1.TabIndex = 0;
            this.buttonAnsw1.Tag = "1";
            this.buttonAnsw1.Text = "Answer one";
            this.buttonAnsw1.UseVisualStyleBackColor = false;
            this.buttonAnsw1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // buttonAnsw2
            // 
            this.buttonAnsw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAnsw2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnsw2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw2.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAnsw2.Location = new System.Drawing.Point(582, 244);
            this.buttonAnsw2.Name = "buttonAnsw2";
            this.buttonAnsw2.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw2.TabIndex = 1;
            this.buttonAnsw2.Tag = "2";
            this.buttonAnsw2.Text = "Answer two";
            this.buttonAnsw2.UseVisualStyleBackColor = true;
            this.buttonAnsw2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // buttonAnsw3
            // 
            this.buttonAnsw3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAnsw3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnsw3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw3.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAnsw3.Location = new System.Drawing.Point(42, 356);
            this.buttonAnsw3.Name = "buttonAnsw3";
            this.buttonAnsw3.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw3.TabIndex = 2;
            this.buttonAnsw3.Tag = "3";
            this.buttonAnsw3.Text = "Answer tree";
            this.buttonAnsw3.UseVisualStyleBackColor = true;
            this.buttonAnsw3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // buttonAnsw4
            // 
            this.buttonAnsw4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAnsw4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnsw4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw4.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAnsw4.Location = new System.Drawing.Point(582, 356);
            this.buttonAnsw4.Name = "buttonAnsw4";
            this.buttonAnsw4.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw4.TabIndex = 3;
            this.buttonAnsw4.Tag = "4";
            this.buttonAnsw4.Text = "Answer four";
            this.buttonAnsw4.UseVisualStyleBackColor = true;
            this.buttonAnsw4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelQuestion.Location = new System.Drawing.Point(446, 153);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Padding = new System.Windows.Forms.Padding(10);
            this.labelQuestion.Size = new System.Drawing.Size(119, 50);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.SizeChanged += new System.EventHandler(this.labelQuestion_SizeChanged);
            this.labelQuestion.Click += new System.EventHandler(this.labelQuestion_Click);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.BackColor = System.Drawing.Color.Transparent;
            this.labelProcess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProcess.Location = new System.Drawing.Point(875, 19);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(93, 32);
            this.labelProcess.TabIndex = 5;
            this.labelProcess.Text = "Process";
            this.labelProcess.Click += new System.EventHandler(this.labelProcess_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTimer.Location = new System.Drawing.Point(32, 24);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(75, 32);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Timer";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(456, 26);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(109, 30);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Username";
            this.labelUserName.SizeChanged += new System.EventHandler(this.labelUserName_SizeChanged);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 521);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonAnsw4);
            this.Controls.Add(this.buttonAnsw3);
            this.Controls.Add(this.buttonAnsw2);
            this.Controls.Add(this.buttonAnsw1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAnsw1;
        private Button buttonAnsw2;
        private Button buttonAnsw3;
        private Button buttonAnsw4;
        private Label labelQuestion;
        private Label labelProcess;
        private System.Windows.Forms.Timer timerTest;
        private Label labelTimer;
        private Label labelUserName;
    }
}