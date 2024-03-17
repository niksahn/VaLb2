namespace VaLb2
{
    partial class Form1
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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            rezult = new TextBox();
            panel1 = new Panel();
            x = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            e = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)e).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.Location = new Point(323, 20);
            button3.Name = "button3";
            button3.Size = new Size(110, 75);
            button3.TabIndex = 2;
            button3.Text = "sinX";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 130);
            button1.Name = "button1";
            button1.Size = new Size(110, 75);
            button1.TabIndex = 3;
            button1.Text = "sqrt(x)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Location = new Point(323, 139);
            button2.Name = "button2";
            button2.Size = new Size(110, 75);
            button2.TabIndex = 4;
            button2.Text = "ctgX";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.Location = new Point(448, 139);
            button4.Name = "button4";
            button4.Size = new Size(110, 75);
            button4.TabIndex = 5;
            button4.Text = "tgX";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(142, 73);
            button5.Name = "button5";
            button5.Size = new Size(110, 75);
            button5.TabIndex = 6;
            button5.Text = "ln(x)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AllowDrop = true;
            button6.Location = new Point(448, 20);
            button6.Name = "button6";
            button6.Size = new Size(110, 75);
            button6.TabIndex = 7;
            button6.Text = "cosX";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(26, 24);
            button7.Name = "button7";
            button7.Size = new Size(110, 75);
            button7.TabIndex = 8;
            button7.Text = "e^x";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // rezult
            // 
            rezult.Location = new Point(418, 143);
            rezult.Name = "rezult";
            rezult.ReadOnly = true;
            rezult.Size = new Size(169, 27);
            rezult.TabIndex = 10;
            rezult.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 233);
            panel1.TabIndex = 12;
            // 
            // x
            // 
            x.DecimalPlaces = 3;
            x.Location = new Point(190, 93);
            x.Margin = new Padding(3, 4, 3, 4);
            x.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            x.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            x.Name = "x";
            x.Size = new Size(200, 27);
            x.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 15;
            label1.Text = "Точность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 18;
            label2.Text = "Введите значение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 146);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 19;
            label3.Text = "Результат";
            // 
            // e
            // 
            e.DecimalPlaces = 10;
            e.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            e.Location = new Point(271, 27);
            e.Margin = new Padding(3, 4, 3, 4);
            e.Minimum = new decimal(new int[] { 1, 0, 0, 655360 });
            e.Name = "e";
            e.Size = new Size(137, 27);
            e.TabIndex = 17;
            e.Value = new decimal(new int[] { 1, 0, 0, 589824 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(601, 433);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(e);
            Controls.Add(label1);
            Controls.Add(x);
            Controls.Add(panel1);
            Controls.Add(rezult);
            Name = "Form1";
            Text = "ЛБ2 Сахно";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)x).EndInit();
            ((System.ComponentModel.ISupportInitialize)e).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox rezult;
        private Panel panel1;
        private NumericUpDown x;
        private Label label1;
        private Label label2;
        private Label label3;
        public NumericUpDown e;
    }
}