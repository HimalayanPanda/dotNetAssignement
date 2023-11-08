namespace QuizApp
{
    partial class AddQuizDetailsForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4038155_200;
            pictureBox1.Location = new Point(712, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_10_25_134140;
            pictureBox2.Location = new Point(25, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 123);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 20;
            label1.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 31);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(556, 368);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 24;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 30);
            label2.Name = "label2";
            label2.Size = new Size(239, 41);
            label2.TabIndex = 25;
            label2.Text = "Add Quiz Details";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(298, 185);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(294, 140);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 185);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 27;
            label3.Text = "Description";
            // 
            // AddQuizDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "AddQuizDetailsForm";
            Text = "AddQuizDetailsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}