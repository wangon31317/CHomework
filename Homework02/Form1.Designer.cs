namespace Homework02
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
            groupBox1 = new GroupBox();
            radioButtonFtoC = new RadioButton();
            radioButtonCtoF = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonDot = new Button();
            textBoxValue = new TextBox();
            buttonConvert = new Button();
            buttonClear = new Button();
            labelResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(radioButtonFtoC);
            groupBox1.Controls.Add(radioButtonCtoF);
            groupBox1.Location = new Point(39, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // radioButtonFtoC
            // 
            radioButtonFtoC.AutoSize = true;
            radioButtonFtoC.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButtonFtoC.Location = new Point(21, 87);
            radioButtonFtoC.Name = "radioButtonFtoC";
            radioButtonFtoC.Size = new Size(191, 32);
            radioButtonFtoC.TabIndex = 1;
            radioButtonFtoC.TabStop = true;
            radioButtonFtoC.Text = "華氏轉換為攝氏";
            radioButtonFtoC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCtoF
            // 
            radioButtonCtoF.AutoSize = true;
            radioButtonCtoF.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButtonCtoF.Location = new Point(21, 40);
            radioButtonCtoF.Name = "radioButtonCtoF";
            radioButtonCtoF.Size = new Size(191, 32);
            radioButtonCtoF.TabIndex = 0;
            radioButtonCtoF.TabStop = true;
            radioButtonCtoF.Text = "攝氏轉換為華氏";
            radioButtonCtoF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Microsoft JhengHei UI", 16F);
            button1.Location = new Point(397, 64);
            button1.Name = "button1";
            button1.Size = new Size(64, 72);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Microsoft JhengHei UI", 16F);
            button2.Location = new Point(467, 64);
            button2.Name = "button2";
            button2.Size = new Size(64, 72);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Microsoft JhengHei UI", 16F);
            button3.Location = new Point(537, 64);
            button3.Name = "button3";
            button3.Size = new Size(64, 72);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Microsoft JhengHei UI", 16F);
            button4.Location = new Point(397, 142);
            button4.Name = "button4";
            button4.Size = new Size(64, 72);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Font = new Font("Microsoft JhengHei UI", 16F);
            button5.Location = new Point(467, 142);
            button5.Name = "button5";
            button5.Size = new Size(64, 72);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveBorder;
            button6.Font = new Font("Microsoft JhengHei UI", 16F);
            button6.Location = new Point(537, 142);
            button6.Name = "button6";
            button6.Size = new Size(64, 72);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveBorder;
            button7.Font = new Font("Microsoft JhengHei UI", 16F);
            button7.Location = new Point(397, 220);
            button7.Name = "button7";
            button7.Size = new Size(64, 72);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveBorder;
            button8.Font = new Font("Microsoft JhengHei UI", 16F);
            button8.Location = new Point(467, 220);
            button8.Name = "button8";
            button8.Size = new Size(64, 72);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveBorder;
            button9.Font = new Font("Microsoft JhengHei UI", 16F);
            button9.Location = new Point(537, 220);
            button9.Name = "button9";
            button9.Size = new Size(64, 72);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberButton_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ActiveBorder;
            button0.Font = new Font("Microsoft JhengHei UI", 16F);
            button0.Location = new Point(397, 298);
            button0.Name = "button0";
            button0.Size = new Size(64, 72);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += NumberButton_Click;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = SystemColors.ActiveBorder;
            buttonDot.Font = new Font("Microsoft JhengHei UI", 16F);
            buttonDot.Location = new Point(467, 298);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(64, 72);
            buttonDot.TabIndex = 11;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonDot_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.BackColor = SystemColors.ButtonHighlight;
            textBoxValue.Font = new Font("Microsoft JhengHei UI", 20F);
            textBoxValue.Location = new Point(644, 145);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.ReadOnly = true;
            textBoxValue.Size = new Size(315, 58);
            textBoxValue.TabIndex = 12;
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = SystemColors.ActiveBorder;
            buttonConvert.Font = new Font("Microsoft JhengHei UI", 14F);
            buttonConvert.Location = new Point(644, 220);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(129, 72);
            buttonConvert.TabIndex = 13;
            buttonConvert.Text = "轉換";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ActiveBorder;
            buttonClear.Font = new Font("Microsoft JhengHei UI", 14F);
            buttonClear.Location = new Point(795, 220);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(129, 72);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "清除";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Microsoft JhengHei UI", 16F);
            labelResult.Location = new Point(651, 324);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(114, 41);
            labelResult.TabIndex = 15;
            labelResult.Text = "結果：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 479);
            Controls.Add(labelResult);
            Controls.Add(buttonClear);
            Controls.Add(buttonConvert);
            Controls.Add(textBoxValue);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "溫度轉換器";

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonFtoC;
        private RadioButton radioButtonCtoF;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonDot;
        private TextBox textBoxValue;
        private Button buttonConvert;
        private Button buttonClear;
        private Label labelResult;
    }
}
