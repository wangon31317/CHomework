namespace Homework05
{
    public partial class Form1 : Form
    {
        private UserInfo _userinfo;
        public Form1()
        {
            InitializeComponent();
            _userinfo = new UserInfo();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            _userinfo.Zodiac = GetZodiac(birthday);
            _userinfo.LifeNumber = GetLifeNumber(birthday);
            string lifeNumberInfo = GetLifeNumberInfo();
            textBoxInfo.Text = $"�A���P�y�O {_userinfo.Zodiac}" + Environment.NewLine +
                               $"�A���ͩR�F�ƬO {_userinfo.LifeNumber}" + Environment.NewLine + 
                               $"{lifeNumberInfo}";
        }
        public string GetZodiac(DateTime birthday)
        {
            var month = birthday.Month;
            var day = birthday.Day;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                return "�d�Ϯy";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                return "�����y";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                return "���l�y";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                return "���ɮy";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                return "��l�y";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                return "�B�k�y";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                return "�ѯ��y";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                return "���Ȯy";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                return "�g��y";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                return "�]�~�y";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                return "���~�y";
            }
            else { return "�����y"; }

        }

        public string GetLifeNumber(DateTime birthday)
        {
            string birthdaystr = birthday.ToString("yyyyMMdd");

            int total = birthdaystr.Sum(c => int.Parse(c.ToString()));

            while (total >= 10)
            {
                total = total.ToString().Sum(c => int.Parse(c.ToString()));
            }

            return total.ToString();

        }

        public string GetLifeNumberInfo()
        {
            string[] lines = File.ReadAllLines("�ͩR�F��.txt");

            int zodiacIndex = Array.FindIndex(lines, line => line.Contains(_userinfo.Zodiac));

            int nextZodiacIndex = Array.FindIndex(lines, zodiacIndex + 1, line => line.StartsWith("�i"));
            if (nextZodiacIndex == -1)
            {
                nextZodiacIndex = lines.Length;
            }

            string searchKey = $"�ͩR�F��{_userinfo.LifeNumber}�G";
            string result =
                lines
                .Skip(zodiacIndex)
                .Take(nextZodiacIndex)
                .FirstOrDefault(line => line.Contains(searchKey));

            if (result == null)
            {
                return result = "�d�L��ơI";
            }
            else
            {
                result = result.Trim().Replace(searchKey, "").Trim();
                return result;
            }
        }
    }
}
