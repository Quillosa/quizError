using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class StartedQuiz : Form
    {
        public StartedQuiz()
        {
            InitializeComponent();
        }
        int tick = 10;
        int number = 1;
        int index = 0;
        int score = 0;

        List<String> questions = new List<string>();
        List<String> cA = new List<string>();
        List<String> cB = new List<string>();
        List<String> cC = new List<string>();
        List<String> cD = new List<string>();
        List<bool> correctAnswer = new List<bool>();

        private void StartedQuiz_Load(object sender, EventArgs e)
        {
            
            timer1.Start();

            questions.Add(number++ + " " + "What is Your Name?");
            questions.Add(number++ + " " + "What is Your Age?");
            questions.Add(number++ + " " + "What is Your Favorite Hero?");
            questions.Add(number++ + " " + "What is Your Favorite Color?");
            questions.Add(number++ + " " + "What is Your Favorite Dagis?");
            questions.Add(number++ + " " + "What is Your Gpu?");
            questions.Add(number++ + " " + "What is Your Cpu?");
            questions.Add(number++ + " " + "What is Your Ram?");
            questions.Add(number++ + " " + "How many is your storage?");
            questions.Add(number++ + " " + "how many is your Fans?");


            cA.Add("Carats");
            cB.Add("Shin");
            cC.Add("Janooo");
            cD.Add("Cara");

            cA.Add("20");
            cB.Add("45");
            cC.Add("32");
            cD.Add("53");

            cA.Add("Gusion");
            cB.Add("Budaga");
            cC.Add("Wamos");
            cD.Add("Maam Guidance");

            cA.Add("Jablue");
            cB.Add("JabGreen");
            cC.Add("Jawhite");
            cD.Add("jablack");

            cA.Add("Rakol");
            cB.Add("Rasol");
            cC.Add("Rakis");
            cD.Add("Ratords");

            cA.Add("rtx 6080");
            cB.Add("integrated only");
            cC.Add("gtx 6909");
            cD.Add("nlex 619");

            cA.Add("R5 5600g");
            cB.Add("intel 13000k");
            cC.Add("mediatech dagis");
            cD.Add("SnapbabyDragon");

            cA.Add("Tforce");
            cB.Add("Delta");
            cC.Add("Putan");
            cD.Add("Omic");

            cA.Add("1Tb");
            cB.Add("256Gb");
            cC.Add("32Gb");
            cD.Add("2Tb");

            cA.Add("6");
            cB.Add("8");
            cC.Add("7");
            cD.Add("5");

            correctAnswer.Add(false);
            correctAnswer.Add(true);
            correctAnswer.Add(true);
            correctAnswer.Add(true);
            correctAnswer.Add(true);
            correctAnswer.Add(false);
            correctAnswer.Add(true);
            correctAnswer.Add(false);
            correctAnswer.Add(true);
            correctAnswer.Add(false);

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick--;
            timerlbl.Text = tick.ToString();;
            displayQuestion();

            if (tick == 1)
            {
                timer1.Stop();
                tick = 10;
                displayQuestion();
                index++;
                timer1.Start();
            }
        }

        private void displayQuestion()
        {
            questionlbl.Text = questions[index];

            choiceA.Text = "A." + cA[index];
            choiceB.Text = "B." + cB[index];
            choiceC.Text = "C." + cC[index];
            choiceD.Text = "D." + cD[index];

            if (index == 10)
            {
                index = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCorrectAnswer())
            {
                if (isCurrentAnswerCorrect())
                {
                    score++;
                }

                if (index < questions.Count - 1)
                {
                    index++;
                    tick = 10;
                    displayQuestion();
                }
                else
                {  
                    MessageBox.Show($"Quiz completed. Your score: {score} out of {questions.Count}");
                    Quizfrm nwfrm = new Quizfrm();
                    nwfrm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select an answer before moving to the next question.");
            }

        }

        private bool isCorrectAnswer()
        {
            return choiceA.Checked || choiceB.Checked || choiceC.Checked || choiceD.Checked;

        }

        private bool isCurrentAnswerCorrect()
        {

            if (choiceA.Checked && correctAnswer[index])
            {
                return true;
            }
            else if (choiceB.Checked && correctAnswer[index])
            {
                return true;
            }
            else if (choiceC.Checked && correctAnswer[index])
            {
                return true;
            }
            else if (choiceD.Checked && correctAnswer[index])
            {
                return true;
            }
            return false;
        }

        public int getScore()
        {
            return score;
        }
    }
}
