namespace Homework04
{
    public partial class Form1 : Form
    {
        private string Answer { get; set; }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonCheckAnswer.Enabled = false;
            buttonRestartGame.Enabled = false;
            buttonGetAnswer.Enabled = false;
            textBoxInput.Enabled = false;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void buttonGetAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是：{Answer}" + Environment.NewLine + " 自動幫你開始新一輪遊戲，再試試看吧！");
            StartGame();
        }
        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        private void buttonRestartGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("自動幫你開始新一輪遊戲！");
            StartGame();

        }

        private void StartGame()
        {
            Answer = GenerateAnswer();
            buttonCheckAnswer.Enabled = true;
            buttonRestartGame.Enabled = true;
            buttonGetAnswer.Enabled = true;
            buttonStartGame.Enabled = false;
            listBox1.Items.Clear();
            textBoxInput.Text = null;
            textBoxInput.Enabled = true;
        }
        public string GenerateAnswer()
        {
            Random random = new Random();
            List<int> digits = new List<int>();

            while (digits.Count < 4)
            {
                int num = random.Next(0, 10);

                if ((digits.Count == 0 && num == 0) || digits.Contains(num))
                {
                    continue;
                }

                digits.Add(num);
            }

            return string.Join("", digits);
        }

        public void CheckGuess()
        {
            bool isNumber = int.TryParse(textBoxInput.Text, out int userguess);
            if (isNumber == false || textBoxInput.TextLength != 4)
            {
                MessageBox.Show("請輸入正確的四位數字！");
                return;
            }

            string guess = userguess.ToString();
            int a = 0;
            int b = 0;

            for (int i = 0; i < guess.Length; i++)
            {

                {
                    if (guess[i] == Answer[i])
                        a++;

                    else if (Answer.Contains(guess[i]))
                        b++;
                }
            }

            listBox1.Items.Add($"{guess} : {a}A{b}B");

            if (a == 4)
            {
                MessageBox.Show("恭喜你過關了！");
                buttonCheckAnswer.Enabled = false;
                textBoxInput.Enabled = false;
            }

        }


    }
}
