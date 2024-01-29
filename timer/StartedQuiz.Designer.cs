namespace timer
{
    partial class StartedQuiz
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
            this.choiceA = new System.Windows.Forms.RadioButton();
            this.questionlbl = new System.Windows.Forms.Label();
            this.choiceB = new System.Windows.Forms.RadioButton();
            this.choiceC = new System.Windows.Forms.RadioButton();
            this.choiceD = new System.Windows.Forms.RadioButton();
            this.timerlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // choiceA
            // 
            this.choiceA.AutoSize = true;
            this.choiceA.Location = new System.Drawing.Point(48, 96);
            this.choiceA.Name = "choiceA";
            this.choiceA.Size = new System.Drawing.Size(14, 13);
            this.choiceA.TabIndex = 0;
            this.choiceA.TabStop = true;
            this.choiceA.UseVisualStyleBackColor = true;
            // 
            // questionlbl
            // 
            this.questionlbl.AutoSize = true;
            this.questionlbl.Location = new System.Drawing.Point(24, 54);
            this.questionlbl.Name = "questionlbl";
            this.questionlbl.Size = new System.Drawing.Size(0, 13);
            this.questionlbl.TabIndex = 1;
            // 
            // choiceB
            // 
            this.choiceB.AutoSize = true;
            this.choiceB.Location = new System.Drawing.Point(48, 135);
            this.choiceB.Name = "choiceB";
            this.choiceB.Size = new System.Drawing.Size(14, 13);
            this.choiceB.TabIndex = 2;
            this.choiceB.TabStop = true;
            this.choiceB.UseVisualStyleBackColor = true;
            // 
            // choiceC
            // 
            this.choiceC.AutoSize = true;
            this.choiceC.Location = new System.Drawing.Point(48, 178);
            this.choiceC.Name = "choiceC";
            this.choiceC.Size = new System.Drawing.Size(14, 13);
            this.choiceC.TabIndex = 3;
            this.choiceC.TabStop = true;
            this.choiceC.UseVisualStyleBackColor = true;
            // 
            // choiceD
            // 
            this.choiceD.AutoSize = true;
            this.choiceD.Location = new System.Drawing.Point(48, 218);
            this.choiceD.Name = "choiceD";
            this.choiceD.Size = new System.Drawing.Size(14, 13);
            this.choiceD.TabIndex = 4;
            this.choiceD.TabStop = true;
            this.choiceD.UseVisualStyleBackColor = true;
            // 
            // timerlbl
            // 
            this.timerlbl.AutoSize = true;
            this.timerlbl.Location = new System.Drawing.Point(385, 19);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(0, 13);
            this.timerlbl.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartedQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timerlbl);
            this.Controls.Add(this.choiceD);
            this.Controls.Add(this.choiceC);
            this.Controls.Add(this.choiceB);
            this.Controls.Add(this.questionlbl);
            this.Controls.Add(this.choiceA);
            this.Name = "StartedQuiz";
            this.Text = "StartedQuiz";
            this.Load += new System.EventHandler(this.StartedQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choiceA;
        private System.Windows.Forms.Label questionlbl;
        private System.Windows.Forms.RadioButton choiceB;
        private System.Windows.Forms.RadioButton choiceC;
        private System.Windows.Forms.RadioButton choiceD;
        private System.Windows.Forms.Label timerlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}