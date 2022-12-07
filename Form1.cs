namespace Gammirovanie
{
    public partial class Form1 : Form
    {
        static readonly string cyrillic = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
        static readonly string latin = "abcdefghijklmnopqrstuvwxyz0123456789";

        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = OpenTextBox.Text.ToLower();
                string key = KeyTextBox.Text.ToLower();
                bool generateKey = GenerateKeyСheckBox.Checked;
                bool lang = LangCheckbox.Checked;

                if (generateKey) KeyTextBox.Clear();

                CheckKey(key, generateKey, lang);
                CheckText(text, lang);

                BinKeyTextBox.Text = ChangeRepresentation(key, lang);
                BinOpenTextBox.Text = ChangeRepresentation(text, lang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                CipherTextBox.Clear();
                BinKeyTextBox.Clear();
                KeyTextBox.Clear();
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool lang = LangCheckbox.Checked;
                string binOpenText = BinOpenTextBox.Text;
                CipherTextBox.Text = ChangeRepresentation(binOpenText, lang, true);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                CipherTextBox.Clear();
                BinCipherTextBox.Clear();
            }
        }

        private static string DecimalToBinary(int value)
        {
            string result = "";

            while (value > 0)
            {
                int reminder = value % 2;
                value /= 2;
                result = result.Insert(0, Convert.ToString(reminder));
            }
            
            while (result.Length < 8)
            {
                result = result.Insert(0, "0");
            }

            return result;
        }

        private static int BinaryToDecimal(string doubleView)
        {
            int resultIndex = 0;

            for (int i = 0; i < doubleView.Length; i++)
            {
                int num = doubleView[i] == '0' ? 0 : 1;
                int pow = doubleView.Length - i - 1;
                resultIndex += Convert.ToInt32(num * Math.Pow(2, pow));
            }

            return resultIndex;
        }

        private static string ChangeRepresentation(string text, bool lang, bool toDecimal = false)
        {
            string alphabet = lang ? cyrillic : latin;
            string result = "";

            text = text.Trim();

            if (toDecimal)
            {
                string[] temp = text.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    result += alphabet[BinaryToDecimal(temp[i])];
                }
            } else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != ' ')
                    {
                        result += DecimalToBinary(alphabet.IndexOf(text[i])) + ' ';
                    }
                }
            }

            return result;
        }

        private static void CheckKey(string key, bool generate, bool lang = false)
        {
            string alphabet;
            
            if (lang) alphabet = cyrillic;
            else alphabet = latin;

            if (!generate && key.Length == 0) throw new Exception("Введите ключ или сгенерируйте его.");

            for (int i = 0; i < key.Length; i++)
            {
                if (!alphabet.Contains(key[i])) throw new Exception("Ключ содержит не соответствующие алфавиту символы.");
            }
        }

        private static void CheckText(string text, bool lang)
        {
            string alphabet;

            if (text.Length == 0) throw new Exception("Введите текст.");
            
            if (lang) alphabet = cyrillic;
            else alphabet = latin;

            for (int i = 0; i < text.Length; i++)
            {
                if (!alphabet.Contains(text[i]) && text[i] != ' ') throw new Exception("Текст содержит не соотвествующие алфавиту символы.");
            }
        }
    }
}