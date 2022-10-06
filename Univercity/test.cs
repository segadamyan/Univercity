using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class test : Form
    {
        private User user;
        int correctAnswer;
        int questionNumber;
        static readonly int TOTAL_QUESTIONS = 3;
        DateTime startTime;

        public test(User user)
        {
            InitializeComponent();
            this.user = user;
            this.labelUserName.Text = user.username;
            labelTimer.Text = "05:00";
            askQuestion(0);
            timerTest.Tick += new EventHandler(TimerEventProcessor);
            timerTest.Interval = 1000;
            timerTest.Start();
            startTime = DateTime.Now;
        }

        private void TimerEventProcessor(Object myObject,
                                           EventArgs myEventArgs)
        {
            if ((TimeSpan.FromMinutes(5) - (DateTime.Now - startTime)).Seconds == 0)
            {
                timerTest.Stop();
                endTest();
                this.questionNumber = 0;
                askQuestion(questionNumber);
                this.startTime = DateTime.Now;
            }
            labelTimer.Text = (TimeSpan.FromMinutes(5) - (DateTime.Now - startTime)).ToString("mm\\:ss");
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
        private void askQuestion(int questionNumber)
        {
            Question question = questions[questionNumber];
            labelQuestion.Text = question.question;
            buttonAnsw1.Text = question.answer1;
            buttonAnsw2.Text = question.answer2;
            buttonAnsw3.Text = question.answer3;
            buttonAnsw4.Text = question.answer4;
            this.correctAnswer = question.correctAnswer;
            labelProcess.Text = String.Format("{0}/{1}", this.questionNumber + 1, TOTAL_QUESTIONS);
        }


        private Question[] questions =
        {
            new Question("Which of the following is NOT an Arithmetic operator in C#.NET?", "**", "+", "%", "/", 1),
            new Question("Which of the following are NOT Relational operators in C#.NET?", ">=", "!=", "Not", "<>=", 3),
            new Question("Console.WriteLine(13 / 2 + \" \" + 13 % 2);", "6.5 1", "6.5 0", "6 0", "6 1", 4)
        };

        public class Question
        {
            public readonly string question;
            public readonly string answer1;
            public readonly string answer2;
            public readonly string answer3;
            public readonly string answer4;
            public readonly int correctAnswer;
            private int userAnswer = 0;

            public Question(string question, string answer1, string answer2, string answer3, string answer4, int correctAnswer)
            {
                this.question = question;
                this.answer1 = answer1;
                this.answer2 = answer2;
                this.answer3 = answer3;
                this.answer4 = answer4;
                this.correctAnswer = correctAnswer;
            }

            public int UserAnswer
            {
                get { return userAnswer; }
                set { this.userAnswer = value; }
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            this.questions[questionNumber].UserAnswer = buttonTag;
            questionNumber++;
            if (questionNumber == TOTAL_QUESTIONS)
            {
                timerTest.Stop();
                endTest();
            } else
            {
                askQuestion(questionNumber);
            }
        }

        private void endTest()
        {
            int score = 0;
            for (int i = 0; i <  this.questions.Length; i++)
            {
                if (questions[i].UserAnswer == questions[i].correctAnswer)
                {
                    score++;
                }
            }
            this.Close();
            Report report = new Report(questions);
            report.ShowDialog();
            this.user.id = 0;
        }

        private void labelProcess_Click(object sender, EventArgs e)
        {

        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_SizeChanged(object sender, EventArgs e)
        {
            this.labelUserName.Left = (this.ClientSize.Width - this.labelQuestion.Size.Width) / 2;
        }

        private void labelQuestion_SizeChanged(object sender, EventArgs e)
        {
            this.labelQuestion.Left = (this.ClientSize.Width - this.labelQuestion.Size.Width) / 2;
        }

    }
}
