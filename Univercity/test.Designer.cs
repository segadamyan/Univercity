namespace Univercity
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
            this.buttonAnsw1 = new System.Windows.Forms.Button();
            this.buttonAnsw2 = new System.Windows.Forms.Button();
            this.buttonAnsw3 = new System.Windows.Forms.Button();
            this.buttonAnsw4 = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnsw1
            // 
            this.buttonAnsw1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw1.Location = new System.Drawing.Point(32, 244);
            this.buttonAnsw1.Name = "buttonAnsw1";
            this.buttonAnsw1.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw1.TabIndex = 0;
            this.buttonAnsw1.Tag = "1";
            this.buttonAnsw1.Text = "button1";
            this.buttonAnsw1.UseVisualStyleBackColor = true;
            this.buttonAnsw1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // buttonAnsw2
            // 
            this.buttonAnsw2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw2.Location = new System.Drawing.Point(555, 244);
            this.buttonAnsw2.Name = "buttonAnsw2";
            this.buttonAnsw2.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw2.TabIndex = 1;
            this.buttonAnsw2.Tag = "2";
            this.buttonAnsw2.Text = "button2";
            this.buttonAnsw2.UseVisualStyleBackColor = true;
            this.buttonAnsw2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // buttonAnsw3
            // 
            this.buttonAnsw3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw3.Location = new System.Drawing.Point(32, 356);
            this.buttonAnsw3.Name = "buttonAnsw3";
            this.buttonAnsw3.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw3.TabIndex = 2;
            this.buttonAnsw3.Tag = "3";
            this.buttonAnsw3.Text = "button3";
            this.buttonAnsw3.UseVisualStyleBackColor = true;
            this.buttonAnsw3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // buttonAnsw4
            // 
            this.buttonAnsw4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnsw4.Location = new System.Drawing.Point(555, 356);
            this.buttonAnsw4.Name = "buttonAnsw4";
            this.buttonAnsw4.Size = new System.Drawing.Size(370, 80);
            this.buttonAnsw4.TabIndex = 3;
            this.buttonAnsw4.Tag = "4";
            this.buttonAnsw4.Text = "button4";
            this.buttonAnsw4.UseVisualStyleBackColor = true;
            this.buttonAnsw4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.Location = new System.Drawing.Point(393, 115);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(66, 30);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "label1";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcess.Location = new System.Drawing.Point(875, 19);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(50, 20);
            this.labelProcess.TabIndex = 5;
            this.labelProcess.Text = "label1";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(32, 24);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(78, 32);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "label1";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 520);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonAnsw4);
            this.Controls.Add(this.buttonAnsw3);
            this.Controls.Add(this.buttonAnsw2);
            this.Controls.Add(this.buttonAnsw1);
            this.Name = "test";
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
    }
}