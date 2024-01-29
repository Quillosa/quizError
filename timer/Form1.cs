using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Quizfrm : Form
    {
        public Quizfrm()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("you want to close the Quiz?", "Confirmation to Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {


            about abtfrm = new about();
            abtfrm.Show();
            hideQuiz();

        }

        private void hideQuiz()
        {

            Quizfrm q = new Quizfrm();
            this.Hide();

        }

        public void hideAbout()
        {
            about abt = new about();
            abt.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartedQuiz sQuiz = new StartedQuiz();
            sQuiz.Show();
            hideQuiz();
        }
    }
}
