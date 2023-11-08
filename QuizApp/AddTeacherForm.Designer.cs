namespace QuizApp
{
    partial class AddTeacherForm
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
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 109);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 57);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 26;
            label1.Text = "Add Teacher";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4038155_200;
            pictureBox1.Location = new Point(724, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_10_25_134140;
            pictureBox2.Location = new Point(23, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 213);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(215, 31);
            textBox3.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 213);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 31;
            label3.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 31);
            textBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 29;
            label4.Text = "Email:";
            // 
            // button1
            // 
            button1.Location = new Point(513, 310);
            button1.Name = "button1";
            button1.Size = new Size(191, 34);
            button1.TabIndex = 33;
            button1.Text = "Add Teacher";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddTeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "AddTeacherForm";
            Text = "AddTeacherForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
    }
}