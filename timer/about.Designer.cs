namespace timer
{
    partial class about
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.highestScorelbl = new System.Windows.Forms.Label();
            this.highlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rules\r\n\r\nYou have 10 Seconds to answer each\r\n questions. if you finish the quiz\r\n" +
    " you\'re score show below.\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // highestScorelbl
            // 
            this.highestScorelbl.AutoSize = true;
            this.highestScorelbl.Location = new System.Drawing.Point(81, 141);
            this.highestScorelbl.Name = "highestScorelbl";
            this.highestScorelbl.Size = new System.Drawing.Size(74, 13);
            this.highestScorelbl.TabIndex = 3;
            this.highestScorelbl.Text = "Highest Score";
            // 
            // highlbl
            // 
            this.highlbl.AutoSize = true;
            this.highlbl.Location = new System.Drawing.Point(108, 175);
            this.highlbl.Name = "highlbl";
            this.highlbl.Size = new System.Drawing.Size(13, 13);
            this.highlbl.TabIndex = 5;
            this.highlbl.Text = "0";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 286);
            this.Controls.Add(this.highlbl);
            this.Controls.Add(this.highestScorelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "about";
            this.Text = "about";
            this.Load += new System.EventHandler(this.about_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label highestScorelbl;
        private System.Windows.Forms.Label highlbl;
    }
}