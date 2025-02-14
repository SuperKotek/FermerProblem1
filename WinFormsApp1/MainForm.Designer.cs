namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(600, 23);
            label1.TabIndex = 0;
            label1.Text = "Выберите фигуру для расчета площади по периметру:\r\n";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(41, 100);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(140, 142);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(240, 100);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(140, 142);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(441, 100);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(140, 142);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(41, 280);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(140, 142);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(240, 280);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(140, 142);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(441, 280);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(140, 142);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Russo One", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(57, 72);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 7;
            label2.Text = "Квадрат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Russo One", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(231, 72);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 8;
            label3.Text = "Треугольник";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Russo One", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(476, 72);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 9;
            label4.Text = "Круг";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Russo One", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(74, 252);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 10;
            label5.Text = "Ромб";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Russo One", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(215, 252);
            label6.Name = "label6";
            label6.Size = new Size(195, 25);
            label6.TabIndex = 11;
            label6.Text = "Шестиугольник";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Russo One", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(441, 252);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 12;
            label7.Text = "N-угольник";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Press Start 2P", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Chocolate;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(365, 33);
            label8.TabIndex = 13;
            label8.Text = "Задача фермера";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(627, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Задача фермера";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
