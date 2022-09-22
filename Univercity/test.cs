using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univercity
{
    public partial class test : Form
    {
        int correctAnswer;
        int questionNumber;
        int score;
        static readonly int TOTAL_QUESTIONS = 2;
        DateTime startTime;

        public test()
        {
            InitializeComponent();
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
                MessageBox.Show("Time over, quiz ended, your score" + this.score);
                this.score = 0;
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
            new Question("Who invented C++?", "Dennis Ritchie", "Ken Thompson", "Brian Kernighan", "Bjarne Stroustrup", 4),
            new Question("What is C++?", "C++ is an object oriented programming language", "C++ is a procedural programming language", "C++ supports both procedural and object oriented programming language", "C++ is a functional programming language", 3)
        };

        public class Question
        {
            public readonly String question;
            public readonly String answer1;
            public readonly String answer2;
            public readonly String answer3;
            public readonly String answer4;
            public readonly int correctAnswer;

            public Question(string question, string answer1, string answer2, string answer3, string answer4, int correctAnswer)
            {
                this.question = question;
                this.answer1 = answer1;
                this.answer2 = answer2;
                this.answer3 = answer3;
                this.answer4 = answer4;
                this.correctAnswer = correctAnswer;
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == this.correctAnswer)
            {
                this.score++;
            }
            questionNumber++;
            if (questionNumber == TOTAL_QUESTIONS)
            {
                timerTest.Stop();
                MessageBox.Show("C++ quiz ended, your score" + this.score);
                this.score = 0;
                this.questionNumber = 0;
                this.startTime = DateTime.Now;
                timerTest.Start();
            }
            askQuestion(questionNumber);
        }
    }
}
