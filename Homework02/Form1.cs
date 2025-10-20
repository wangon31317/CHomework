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

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxValue.Text += button.Text;
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

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text.Length > 0)
            {
                textBoxValue.Text = textBoxValue.Text.Substring(0, textBoxValue.Text.Length - 1);
            }
        }

        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            bool isDouble = double.TryParse(textBoxValue.Text, out double value);
            if (isDouble == false)
            {
                MessageBox.Show("請輸入正確的數字");
                return;
            }
            else
            {
                value = -value;
                textBoxValue.Text = value.ToString();
            }

        }
    }
}
