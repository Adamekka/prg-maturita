using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _2_kviz
{
    internal struct Question
    {
        internal string Otazka { get; }
        internal string Odpoved1 { get; }
        internal string Odpoved2 { get; }
        internal string Odpoved3 { get; }
        internal SpravnaOdpoved Spravna { get; }
        internal byte PocBodu { get; }

        internal enum SpravnaOdpoved
        {
            _1,
            _2,
            _3,
        }

        public Question(string otazka, string odpoved1, string odpoved2, string odpoved3, SpravnaOdpoved spravna, byte pocBodu)
        {
            Otazka = otazka;
            Odpoved1 = odpoved1;
            Odpoved2 = odpoved2;
            Odpoved3 = odpoved3;
            Spravna = spravna;
            PocBodu = pocBodu;
        }
    }

    public partial class Form1 : Form
    {
        readonly Question[] Test = new Question[20]
        {
            new Question("1", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("2", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("3", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("4", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("5", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("6", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("7", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("8", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("9", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("10", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("11", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("12", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("13", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("14", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("15", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("16", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("17", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("18", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("19", "1", "2", "3", Question.SpravnaOdpoved._1, 2),
            new Question("20", "1", "2", "3", Question.SpravnaOdpoved._1, 2)
        };

        List<Question> PresentedQuestions = new List<Question>();
        uint PocetBodu = 0;
        int CurrentQuestion = 0;

        public Form1()
        {
            InitializeComponent();

            celkBody.Visible = false;
            otazka.Visible = false;
            pocBodu.Visible = false;
            odpoved1.Visible = false;
            odpoved2.Visible = false;
            odpoved3.Visible = false;
            next.Visible = false;
            opakovatTest.Visible = false;
        }

        private void pocetOtazek_Scroll(object sender, EventArgs e)
        {
            pocetOtazekText.Text = pocetOtazek.Value.ToString();
        }

        private void ShuffleQuestions()
        {
            var random = new Random();
            PresentedQuestions = Test.OrderBy(x => random.Next()).Take(pocetOtazek.Value).ToList();
        }

        private void InitTest()
        {
            PocetBodu = 0;
            celkBody.Text = $"Celkovy pocet bodu: {PocetBodu}";
            CurrentQuestion = 0;

            celkBody.Visible = true;
            otazka.Visible = true;
            pocBodu.Visible = true;
            odpoved1.Visible = true;
            odpoved2.Visible = true;
            odpoved3.Visible = true;
            next.Visible = true;
            opakovatTest.Visible = true;

            NextQuestion();
        }

        private void start_Click(object sender, EventArgs e)
        {
            ShuffleQuestions();

            title1.Visible = false;
            title2.Visible = false;
            pocetOtazek.Visible = false;
            pocetOtazekText.Visible = false;
            start.Visible = false;

            InitTest();
        }

        private void next_Click(object sender, EventArgs e)
        {
            var question = PresentedQuestions[CurrentQuestion - 1];

            if (question.Spravna == Question.SpravnaOdpoved._1 && odpoved1.Checked
                || question.Spravna == Question.SpravnaOdpoved._2 && odpoved2.Checked
                || question.Spravna == Question.SpravnaOdpoved._3 && odpoved3.Checked)
            {
                PocetBodu += question.PocBodu;
                celkBody.Text = $"Celkovy pocet bodu: {PocetBodu}";
                MessageBox.Show($"Spravna odpoved, ziskali jste {question.PocBodu} bodu");
            }
            else if (question.Spravna == Question.SpravnaOdpoved._1)
            {
                MessageBox.Show("Spatne, spravna odpoved byla prvni");
            }
            else if (question.Spravna == Question.SpravnaOdpoved._2)
            {
                MessageBox.Show("Spatne, spravna odpoved byla druha");
            }
            else if (question.Spravna == Question.SpravnaOdpoved._3)
            {
                MessageBox.Show("Spatne, spravna odpoved byla treti");
            }
            else
            {
                new InvalidOperationException("Unreachable");
            }

            NextQuestion();
        }

        private void NextQuestion()
        {
            if (CurrentQuestion >= PresentedQuestions.Count)
            {
                EndTest();
                return;
            }

            var question = PresentedQuestions[CurrentQuestion++];

            //                We want indexes in UI to be normalized for the user, so we can let it be after increment
            otazka.Text = $"[{CurrentQuestion}/{pocetOtazek.Value}] {question.Otazka}";
            pocBodu.Text = $"({question.PocBodu} body)";

            odpoved1.Text = question.Odpoved1;
            odpoved2.Text = question.Odpoved2;
            odpoved3.Text = question.Odpoved3;

            odpoved1.Checked = false;
            odpoved2.Checked = false;
            odpoved3.Checked = false;
        }

        private void EndTest()
        {
            MessageBox.Show($"Konec, ziskal jsi {PocetBodu} bodu");

            PocetBodu = 0;
            celkBody.Text = $"Celkovy pocet bodu: {PocetBodu}";
            CurrentQuestion = 0;

            celkBody.Visible = false;
            otazka.Visible = false;
            pocBodu.Visible = false;
            odpoved1.Visible = false;
            odpoved2.Visible = false;
            odpoved3.Visible = false;
            next.Visible = false;
        }

        private void opakovatTest_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Opakovat test se stejnymi otazkami?", "", MessageBoxButtons.YesNoCancel);

            switch (res)
            {
                case DialogResult.Yes:
                    break;

                case DialogResult.No:
                    ShuffleQuestions();
                    break;

                case DialogResult.Cancel:
                    return;

                default:
                    new InvalidOperationException("Unreachable");
                    break;
            }

            InitTest();
        }
    }
}
