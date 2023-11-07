namespace QuizApp
{
    partial class QuizQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizQuestionForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 28);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 16;
            label1.Text = "Quiz Title";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(604, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 17;
            label2.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 18;
            label3.Text = "Question text";
            // 
            // button1
            // 
            button1.Location = new Point(46, 387);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 20;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(616, 387);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 21;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(191, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 29);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "AnswerA";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(191, 216);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(106, 29);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "AnswerB";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(190, 268);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(107, 29);
            checkBox3.TabIndex = 24;
            checkBox3.Text = "AnswerC";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(191, 324);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(109, 29);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "AnswerD";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // QuizQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "QuizQuestionForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}