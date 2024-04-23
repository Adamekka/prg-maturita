using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_pexeso
{
    public partial class Form1 : Form
    {
        const int WORDS_COUNT = 18;
        const int LANG_COUNT = 2;

        readonly string[,] Words = new string[WORDS_COUNT, LANG_COUNT] {
            {"apple", "jablko"},
            {"banana", "banan"},
            {"car", "auto"},
            {"house", "dum"},
            {"dog", "pes"},
            {"cat", "kocka"},
            {"book", "kniha"},
            {"computer", "pocitac"},
            {"sun", "slunce"},
            {"moon", "mesic"},
            {"tree", "strom"},
            {"flower", "kvetina"},
            {"water", "voda"},
            {"sky", "nebe"},
            {"friend", "pritel"},
            {"family", "rodina"},
            {"love", "laska"},
            {"happiness", "stesti"}
        };
        readonly string[] PresentedWords = new string[WORDS_COUNT * LANG_COUNT];

        Button FirstButton = null;
        int FirstButtonIdx = -1;
        bool FirstClicked = false;

        readonly bool[] MatchedWords = new bool[WORDS_COUNT * LANG_COUNT];

        public Form1()
        {
            var idx = 0;

            for (var word = 0; word < WORDS_COUNT; word++)
                for (var lang = 0; lang < LANG_COUNT; lang++)
                {
                    PresentedWords[idx] = Words[word, lang];
                    idx++;
                }

            FirstClicked = false;

            // Shuffle
            var rnd = new Random();
            PresentedWords = PresentedWords.OrderBy(x => rnd.Next()).ToArray();

            InitializeComponent();
        }

        void ButtonClick(Button btn, int btnIdx)
        {
            if (btn == FirstButton)
                return;

            var secondText = PresentedWords[btnIdx];

            btn.Text = secondText;

            if (!FirstClicked)
            {
                FirstButtonIdx = btnIdx;
                FirstButton = btn;
            }
            else
            {
                // assignments says to use a function that returns bool to check this
                bool MatchWords()
                {
                    var firstText = PresentedWords[FirstButtonIdx];

                    var matched = false;
                    for (var word = 0; word < WORDS_COUNT; word++)
                        matched |= (Words[word, 0] == secondText || Words[word, 1] == secondText)
                            && (Words[word, 0] == firstText || Words[word, 1] == firstText);

                    return matched;
                }

                if (MatchWords())
                {
                    MatchedWords[btnIdx] = true;
                    MatchedWords[FirstButtonIdx] = true;

                    if (MatchedWords.All(x => x == true))
                        MessageBox.Show("Gratuluji, vyhral jsi");
                }
                else
                {
                    // UX improvement, not in assignment
                    Task.Delay(500).Wait();

                    FirstButton.Text = "PEXESO";
                    btn.Text = "PEXESO";

                    FirstButton = null;
                    FirstButtonIdx = -1;
                }
            }

            FirstClicked = !FirstClicked;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[0])
                ButtonClick(button1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[1])
                ButtonClick(button2, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[2])
                ButtonClick(button3, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[3])
                ButtonClick(button4, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[4])
                ButtonClick(button5, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[5])
                ButtonClick(button6, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[6])
                ButtonClick(button7, 6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[7])
                ButtonClick(button8, 7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[8])
                ButtonClick(button9, 8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[9])
                ButtonClick(button10, 9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[10])
                ButtonClick(button11, 10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[11])
                ButtonClick(button12, 11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[12])
                ButtonClick(button13, 12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[13])
                ButtonClick(button14, 13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[14])
                ButtonClick(button15, 14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[15])
                ButtonClick(button16, 15);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[16])
                ButtonClick(button17, 16);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[17])
                ButtonClick(button18, 17);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[18])
                ButtonClick(button19, 18);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[19])
                ButtonClick(button20, 19);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[20])
                ButtonClick(button21, 20);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[21])
                ButtonClick(button22, 21);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[22])
                ButtonClick(button23, 22);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[23])
                ButtonClick(button24, 23);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[24])
                ButtonClick(button25, 24);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[25])
                ButtonClick(button26, 25);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[26])
                ButtonClick(button27, 26);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[27])
                ButtonClick(button28, 27);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[28])
                ButtonClick(button29, 28);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[29])
                ButtonClick(button30, 29);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[30])
                ButtonClick(button31, 30);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[31])
                ButtonClick(button32, 31);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[32])
                ButtonClick(button33, 32);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[33])
                ButtonClick(button34, 33);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[34])
                ButtonClick(button35, 34);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (!MatchedWords[35])
                ButtonClick(button36, 35);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
