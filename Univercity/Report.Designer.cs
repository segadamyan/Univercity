namespace University
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelUserAnswer = new System.Windows.Forms.Label();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelUA = new System.Windows.Forms.Label();
            this.labelCA = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelQuestion.Location = new System.Drawing.Point(200, 110);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(170, 32);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "LabelQuestion";
            this.labelQuestion.Click += new System.EventHandler(this.labelQuestion_Click);
            // 
            // labelUserAnswer
            // 
            this.labelUserAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelUserAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserAnswer.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserAnswer.Location = new System.Drawing.Point(197, 159);
            this.labelUserAnswer.Name = "labelUserAnswer";
            this.labelUserAnswer.Size = new System.Drawing.Size(559, 32);
            this.labelUserAnswer.TabIndex = 1;
            this.labelUserAnswer.Text = "labelUserAnswer";
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelCorrectAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCorrectAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCorrectAnswer.Location = new System.Drawing.Point(197, 214);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(559, 32);
            this.labelCorrectAnswer.TabIndex = 2;
            this.labelCorrectAnswer.Text = "LabelCorrectAnswer";
            this.labelCorrectAnswer.Click += new System.EventHandler(this.labelCorrectAnswer_Click);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.BackColor = System.Drawing.Color.Transparent;
            this.labelQ.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQ.ForeColor = System.Drawing.SystemColors.Window;
            this.labelQ.Location = new System.Drawing.Point(73, 110);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(118, 32);
            this.labelQ.TabIndex = 3;
            this.labelQ.Text = "Question:";
            // 
            // labelUA
            // 
            this.labelUA.AutoSize = true;
            this.labelUA.BackColor = System.Drawing.Color.Transparent;
            this.labelUA.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUA.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUA.Location = new System.Drawing.Point(34, 159);
            this.labelUA.Name = "labelUA";
            this.labelUA.Size = new System.Drawing.Size(157, 32);
            this.labelUA.TabIndex = 4;
            this.labelUA.Text = "Your Answer:";
            // 
            // labelCA
            // 
            this.labelCA.AutoSize = true;
            this.labelCA.BackColor = System.Drawing.Color.Transparent;
            this.labelCA.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCA.ForeColor = System.Drawing.SystemColors.Window;
            this.labelCA.Location = new System.Drawing.Point(3, 214);
            this.labelCA.Name = "labelCA";
            this.labelCA.Size = new System.Drawing.Size(188, 32);
            this.labelCA.TabIndex = 5;
            this.labelCA.Text = "Correct Answer:";
            // 
            // buttonNext
            // 
            this.buttonNext.AutoSize = true;
            this.buttonNext.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNext.Location = new System.Drawing.Point(800, 325);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(125, 45);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPrevious.Location = new System.Drawing.Point(49, 325);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(125, 45);
            this.buttonPrevious.TabIndex = 7;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScore.Location = new System.Drawing.Point(49, 33);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(74, 32);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.BackColor = System.Drawing.Color.Transparent;
            this.labelPage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPage.ForeColor = System.Drawing.Color.White;
            this.labelPage.Location = new System.Drawing.Point(900, 25);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(47, 32);
            this.labelPage.TabIndex = 9;
            this.labelPage.Text = "1/2";
            this.labelPage.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(800, 325);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 45);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelCA);
            this.Controls.Add(this.labelUA);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelCorrectAnswer);
            this.Controls.Add(this.labelUserAnswer);
            this.Controls.Add(this.labelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 350);
            this.Name = "Report";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelQuestion;
        private Label labelUserAnswer;
        private Label labelCorrectAnswer;
        private Label labelQ;
        private Label labelUA;
        private Label labelCA;
        private Button buttonNext;
        private Button buttonPrevious;
        private Label labelScore;
        private Label labelPage;
        private Button buttonClose;
    }
}