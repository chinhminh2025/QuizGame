using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        // variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions = 6;
        int totalQuestion_present = 0;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //check answer event
        {
            totalQuestion_present++;
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                lbresult.Text = "Toltal:" + score.ToString() + "/" + totalQuestion_present.ToString();
            }
            else
            {
                lbresult.Text = "Toltal: " + score.ToString() + "/" + totalQuestion_present.ToString();
                MessageBox.Show("Sai!");

            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
                totalQuestion_present = 0;

            }


            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.naruto;

                    this.lbQuestion.Text = "Who is him?";

                    button1.Text = "Naruto";
                    button2.Text = "Yamato";
                    button3.Text = "Tokuda";
                    button4.Text = "Obito";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.obito;

                    this.lbQuestion.Text = "Who is him?";

                    button1.Text = "Naruto";
                    button2.Text = "Yamato";
                    button3.Text = "Tokuda";
                    button4.Text = "Obito";

                    correctAnswer = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.jiraiya;

                    this.lbQuestion.Text = "Who is him?";

                    button1.Text = "Naruto";
                    button2.Text = "Yamato";
                    button3.Text = "Jiraiya";
                    button4.Text = "Obito";

                    correctAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.captain_america;

                    this.lbQuestion.Text = "Who is him?";

                    button1.Text = "Naruto";
                    button2.Text = "Yamato";
                    button3.Text = "Captain America";
                    button4.Text = "Obito";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.kakashi;

                    this.lbQuestion.Text = "Who is him?";

                    button1.Text = "Naruto";
                    button2.Text = "Yamato";
                    button3.Text = "Kakashi";
                    button4.Text = "Obito";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.luffy;

                    this.lbQuestion.Text = "Who is him?";

                    button1.Text = "Naruto";
                    button2.Text = "Yamato";
                    button3.Text = "Luffy";
                    button4.Text = "Obito";

                    correctAnswer = 3;

                    break;
            }

        }

    }
}
