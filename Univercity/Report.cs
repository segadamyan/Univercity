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
    public partial class Report : Form
    {
        private test.Question[] questions;
        private int questionNumber = 0;
        public Report(test.Question[] questions)
        {
            InitializeComponent();
            this.questions = questions;
            this.buttonPrevious.Hide();
            showResult(questions[0]);
            changePage();
            showScore();
        }

        private void showResult(test.Question question)
        {
            this.labelQuestion.Text = question.question;
            switch (question.UserAnswer)
            {
                case 1:
                    this.labelUserAnswer.Text = question.answer1;
                    break;
                case 2: this.labelUserAnswer.Text = question.answer2;
                    break;
                case 3:
                    this.labelUserAnswer.Text = question.answer3;
                    break;
                case 4:
                    this.labelUserAnswer.Text = question.answer4;
                    break;
                default:
                    this.labelUserAnswer.Text = "No answer";
                    break;
            }
            switch (question.correctAnswer)
            {
                case 1:
                    this.labelCorrectAnswer.Text = question.answer1;
                    break;
                case 2:
                    this.labelCorrectAnswer.Text = question.answer2;
                    break;
                case 3:
                    this.labelCorrectAnswer.Text = question.answer3;
                    break;
                case 4:
                    this.labelCorrectAnswer.Text = question.answer4;
                    break;
                default:
                    this.labelUserAnswer.Text = "Error";
                    break;
            }
            if (question.UserAnswer == question.correctAnswer)
            {
                this.labelUserAnswer.ForeColor = Color.Green;
            } else
            {
                this.labelUserAnswer.ForeColor = Color.Red;
            }

        }

        private void labelQuestion_Click(object sender, EventArgs e)
            {

            }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (questionNumber + 1 < questions.Count())
            {
                questionNumber++;
                showResult(questions[questionNumber]);
            }
            if (questionNumber == questions.Count() - 1)
            {
                this.buttonNext.Hide();
            }
            this.buttonPrevious.Show();
            changePage();
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (questionNumber > 0)
            {
                questionNumber--;
                showResult(questions[questionNumber]);
            }

            if (questionNumber == 0)
            {
                this.buttonPrevious.Hide();
            }
            this.buttonNext.Show();
            changePage();
        }

        private void changePage()
        {
            this.labelPage.Text = String.Format("{0}/{1}", this.questionNumber + 1, this.questions.Count());
        }

        private void showScore()
        {
            int score = 0;
            MessageBox.Show(this.questions.Count().ToString());
            for (int i = 0; i < this.questions.Count(); i++)
            {
                if (this.questions[i].correctAnswer == this.questions[i].UserAnswer)
                {
                    score++;
                }
            }
            MessageBox.Show(((score / questions.Count())).ToString());
            this.labelScore.Text = ((score / questions.Count()) * 100).ToString() + " %";
        }

        private void labelCorrectAnswer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
