namespace TimedMathQuiz
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            label2 = new Label();
            plusRightLabel = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label3 = new Label();
            minusRightLabel = new Label();
            label6 = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            label8 = new Label();
            timesRightLabel = new Label();
            label10 = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            label12 = new Label();
            dividedRightLabel = new Label();
            label14 = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Cursor = Cursors.No;
            timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(661, 25);
            timeLabel.Margin = new Padding(7, 0, 7, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(483, 79);
            timeLabel.TabIndex = 0;
            timeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 25);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(486, 82);
            label1.TabIndex = 0;
            label1.Text = "Time Left";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location = new Point(121, 205);
            plusLeftLabel.Margin = new Padding(7, 0, 7, 0);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(146, 137);
            plusLeftLabel.TabIndex = 1;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(602, 205);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 137);
            label2.TabIndex = 2;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location = new Point(442, 205);
            plusRightLabel.Margin = new Padding(7, 0, 7, 0);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(146, 137);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(282, 205);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 137);
            label4.TabIndex = 4;
            label4.Text = "+";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location = new Point(763, 224);
            sum.Margin = new Padding(7, 8, 7, 8);
            sum.Name = "sum";
            sum.Size = new Size(243, 87);
            sum.TabIndex = 1;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location = new Point(763, 361);
            difference.Margin = new Padding(7, 8, 7, 8);
            difference.Name = "difference";
            difference.Size = new Size(243, 87);
            difference.TabIndex = 2;
            difference.Enter += answer_Enter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(282, 342);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 137);
            label3.TabIndex = 9;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location = new Point(442, 342);
            minusRightLabel.Margin = new Padding(7, 0, 7, 0);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(146, 137);
            minusRightLabel.TabIndex = 8;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(602, 342);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 137);
            label6.TabIndex = 7;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location = new Point(121, 342);
            minusLeftLabel.Margin = new Padding(7, 0, 7, 0);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(146, 137);
            minusLeftLabel.TabIndex = 6;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location = new Point(763, 497);
            product.Margin = new Padding(7, 8, 7, 8);
            product.Name = "product";
            product.Size = new Size(243, 87);
            product.TabIndex = 3;
            product.Enter += answer_Enter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(282, 478);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 137);
            label8.TabIndex = 14;
            label8.Text = "×";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location = new Point(442, 478);
            timesRightLabel.Margin = new Padding(7, 0, 7, 0);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(146, 137);
            timesRightLabel.TabIndex = 13;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(602, 478);
            label10.Margin = new Padding(7, 0, 7, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 137);
            label10.TabIndex = 12;
            label10.Text = "=";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location = new Point(121, 478);
            timesLeftLabel.Margin = new Padding(7, 0, 7, 0);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(146, 137);
            timesLeftLabel.TabIndex = 11;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location = new Point(763, 634);
            quotient.Margin = new Padding(7, 8, 7, 8);
            quotient.Name = "quotient";
            quotient.Size = new Size(243, 87);
            quotient.TabIndex = 4;
            quotient.Enter += answer_Enter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(282, 615);
            label12.Margin = new Padding(7, 0, 7, 0);
            label12.Name = "label12";
            label12.Size = new Size(146, 137);
            label12.TabIndex = 19;
            label12.Text = "÷";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location = new Point(442, 615);
            dividedRightLabel.Margin = new Padding(7, 0, 7, 0);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(146, 137);
            dividedRightLabel.TabIndex = 18;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(602, 615);
            label14.Margin = new Padding(7, 0, 7, 0);
            label14.Name = "label14";
            label14.Size = new Size(146, 137);
            label14.TabIndex = 17;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location = new Point(121, 615);
            dividedLeftLabel.Margin = new Padding(7, 0, 7, 0);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(146, 137);
            dividedLeftLabel.TabIndex = 16;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(421, 778);
            startButton.Name = "startButton";
            startButton.Size = new Size(314, 80);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseMnemonic = false;
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(12, 924);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(409, 54);
            dateLabel.TabIndex = 20;
            dateLabel.Text = "Today is 23 Sept 2023";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 987);
            Controls.Add(dateLabel);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label12);
            Controls.Add(dividedRightLabel);
            Controls.Add(label14);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label8);
            Controls.Add(timesRightLabel);
            Controls.Add(label10);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label3);
            Controls.Add(minusRightLabel);
            Controls.Add(label6);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Josh Liddiard's Math Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label label4;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label3;
        private Label minusRightLabel;
        private Label label6;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label label8;
        private Label timesRightLabel;
        private Label label10;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label label12;
        private Label dividedRightLabel;
        private Label label14;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label dateLabel;
    }
}