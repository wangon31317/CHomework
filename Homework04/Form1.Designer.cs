namespace Homework04
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
            buttonStartGame = new Button();
            buttonGetAnswer = new Button();
            buttonCheckAnswer = new Button();
            buttonRestartGame = new Button();
            label1 = new Label();
            textBoxInput = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonStartGame
            // 
            buttonStartGame.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            buttonStartGame.Location = new Point(62, 60);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(160, 84);
            buttonStartGame.TabIndex = 0;
            buttonStartGame.Text = "開始遊戲";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // buttonGetAnswer
            // 
            buttonGetAnswer.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            buttonGetAnswer.Location = new Point(62, 205);
            buttonGetAnswer.Name = "buttonGetAnswer";
            buttonGetAnswer.Size = new Size(160, 84);
            buttonGetAnswer.TabIndex = 1;
            buttonGetAnswer.Text = "看答案";
            buttonGetAnswer.UseVisualStyleBackColor = true;
            buttonGetAnswer.Click += buttonGetAnswer_Click;
            // 
            // buttonCheckAnswer
            // 
            buttonCheckAnswer.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            buttonCheckAnswer.Location = new Point(62, 590);
            buttonCheckAnswer.Name = "buttonCheckAnswer";
            buttonCheckAnswer.Size = new Size(160, 84);
            buttonCheckAnswer.TabIndex = 2;
            buttonCheckAnswer.Text = "檢查答案";
            buttonCheckAnswer.UseVisualStyleBackColor = true;
            buttonCheckAnswer.Click += buttonCheckAnswer_Click;
            // 
            // buttonRestartGame
            // 
            buttonRestartGame.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            buttonRestartGame.Location = new Point(243, 590);
            buttonRestartGame.Name = "buttonRestartGame";
            buttonRestartGame.Size = new Size(160, 84);
            buttonRestartGame.TabIndex = 3;
            buttonRestartGame.Text = "放棄重來";
            buttonRestartGame.UseVisualStyleBackColor = true;
            buttonRestartGame.Click += buttonRestartGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F);
            label1.Location = new Point(62, 450);
            label1.Name = "label1";
            label1.Size = new Size(71, 36);
            label1.TabIndex = 4;
            label1.Text = "輸入";
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Microsoft JhengHei UI", 12F);
            textBoxInput.Location = new Point(62, 518);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(341, 38);
            textBoxInput.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft JhengHei UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(432, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(380, 514);
            listBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F);
            label2.Location = new Point(432, 60);
            label2.Name = "label2";
            label2.Size = new Size(127, 36);
            label2.TabIndex = 7;
            label2.Text = "遊戲歷程";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 761);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Controls.Add(buttonRestartGame);
            Controls.Add(buttonCheckAnswer);
            Controls.Add(buttonGetAnswer);
            Controls.Add(buttonStartGame);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartGame;
        private Button buttonGetAnswer;
        private Button buttonCheckAnswer;
        private Button buttonRestartGame;
        private Label label1;
        private TextBox textBoxInput;
        private ListBox listBox1;
        private Label label2;
    }
}
