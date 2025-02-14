namespace WinFormsApp1
{
    partial class FormSquare
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
            label8 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Press Start 2P", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Chocolate;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(365, 33);
            label8.TabIndex = 14;
            label8.Text = "Задача фермера";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("HigashiOme Gothic regular", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(288, 19);
            label1.TabIndex = 15;
            label1.Text = "Выбранная фигура: Квадрат\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Square1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(380, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 149);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(302, 46);
            label2.TabIndex = 17;
            label2.Text = "Введите периметр фигуры:\r\n(ОДЗ: Число >= 0)";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Location = new Point(12, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(328, 23);
            label3.TabIndex = 19;
            label3.Text = "Результат (площадь фигуры):";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.Location = new Point(12, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 23);
            textBox2.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(380, 177);
            button1.Name = "button1";
            button1.Size = new Size(151, 50);
            button1.TabIndex = 21;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormSquare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(543, 239);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "FormSquare";
            Text = "Квадрат";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        public TextBox textBox2;
    }
}