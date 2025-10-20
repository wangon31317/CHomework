namespace Homework02
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxValue.Clear();
            radioButtonCtoF.Checked = false;
            radioButtonFtoC.Checked = false;
            labelResult.Text = "結果：";
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double result;
            bool isDouble = double.TryParse(textBoxValue.Text, out double value);
            if (isDouble == false)
            {
                MessageBox.Show("請輸入正確的數字");
                return;
            }

            if (radioButtonCtoF.Checked == true)
            {
                result = Math.Round(9.0 / 5 * value + 32, 2);

                labelResult.Text = $"結果：{value} °C = {result} °F";

            }

            else if (radioButtonFtoC.Checked == true)
            {
                result = Math.Round((value - 32) * 5 / 9.0, 2);

                labelResult.Text = $"結果：{value} °F = {result} °C";
            }

            else
            {
                MessageBox.Show("請選擇一種轉換方式！");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            bool hasDot = (textBoxValue.Text.Contains("."));
            if (hasDot == false)
            {
                textBoxValue.Text += ".";
            }
            else
            {
                return;
            }
        }

        
    }
}
