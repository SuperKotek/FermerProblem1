namespace WinFormsApp1
{
    partial class FormCircle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCircle));
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(380, 178);
            button1.Name = "button1";
            button1.Size = new Size(151, 50);
            button1.TabIndex = 37;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.Location = new Point(12, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 23);
            textBox2.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(328, 23);
            label3.TabIndex = 35;
            label3.Text = "Результат (площадь фигуры):";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Location = new Point(12, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 34;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(380, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 149);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("HigashiOme Gothic regular", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(252, 19);
            label1.TabIndex = 31;
            label1.Text = "Выбранная фигура: Круг";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Press Start 2P", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Chocolate;
            label8.Location = new Point(12, 10);
            label8.Name = "label8";
            label8.Size = new Size(365, 33);
            label8.TabIndex = 30;
            label8.Text = "Задача фермера";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(302, 46);
            label2.TabIndex = 38;
            label2.Text = "Введите периметр фигуры:\r\n(ОДЗ: Число >= 0)";
            // 
            // FormCircle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(543, 239);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "FormCircle";
            Text = "Круг";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label8;
        private Label label2;
    }
}