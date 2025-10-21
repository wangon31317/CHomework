namespace Homework05
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            buttonExecute = new Button();
            textBoxInfo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 49);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 0;
            label1.Text = "請選擇生日：";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 30);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 174);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 2;
            label2.Text = "關於你：";
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(335, 96);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(112, 34);
            buttonExecute.TabIndex = 3;
            buttonExecute.Text = "分析結果";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(75, 232);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(422, 186);
            textBoxInfo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInfo);
            Controls.Add(buttonExecute);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button buttonExecute;
        private TextBox textBoxInfo;
    }
}
