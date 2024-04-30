
namespace _2_kviz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title2 = new System.Windows.Forms.Label();
            this.pocetOtazek = new System.Windows.Forms.TrackBar();
            this.pocetOtazekText = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.otazka = new System.Windows.Forms.Label();
            this.odpoved1 = new System.Windows.Forms.RadioButton();
            this.odpoved2 = new System.Windows.Forms.RadioButton();
            this.odpoved3 = new System.Windows.Forms.RadioButton();
            this.pocBodu = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.celkBody = new System.Windows.Forms.Label();
            this.opakovatTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pocetOtazek)).BeginInit();
            this.SuspendLayout();
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Location = new System.Drawing.Point(49, 28);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(133, 13);
            this.title2.TabIndex = 0;
            this.title2.Text = "Zvol si pocet otazek 5 - 20";
            // 
            // pocetOtazek
            // 
            this.pocetOtazek.Location = new System.Drawing.Point(52, 53);
            this.pocetOtazek.Maximum = 20;
            this.pocetOtazek.Minimum = 5;
            this.pocetOtazek.Name = "pocetOtazek";
            this.pocetOtazek.Size = new System.Drawing.Size(187, 45);
            this.pocetOtazek.TabIndex = 1;
            this.pocetOtazek.Value = 5;
            this.pocetOtazek.Scroll += new System.EventHandler(this.pocetOtazek_Scroll);
            // 
            // pocetOtazekText
            // 
            this.pocetOtazekText.AutoSize = true;
            this.pocetOtazekText.Location = new System.Drawing.Point(64, 85);
            this.pocetOtazekText.Name = "pocetOtazekText";
            this.pocetOtazekText.Size = new System.Drawing.Size(13, 13);
            this.pocetOtazekText.TabIndex = 2;
            this.pocetOtazekText.Text = "5";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Location = new System.Drawing.Point(31, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(404, 13);
            this.title1.TabIndex = 3;
            this.title1.Text = "Kviz, vyber spravnou odpoved, pro testovaci duvody je vzdy prvni odpoved spravna";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(67, 126);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(58, 32);
            this.start.TabIndex = 4;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // otazka
            // 
            this.otazka.AutoSize = true;
            this.otazka.Location = new System.Drawing.Point(308, 65);
            this.otazka.Name = "otazka";
            this.otazka.Size = new System.Drawing.Size(45, 13);
            this.otazka.TabIndex = 5;
            this.otazka.Text = "otazka1";
            // 
            // odpoved1
            // 
            this.odpoved1.AutoSize = true;
            this.odpoved1.Location = new System.Drawing.Point(311, 94);
            this.odpoved1.Name = "odpoved1";
            this.odpoved1.Size = new System.Drawing.Size(73, 17);
            this.odpoved1.TabIndex = 8;
            this.odpoved1.TabStop = true;
            this.odpoved1.Text = "odpoved1";
            this.odpoved1.UseVisualStyleBackColor = true;
            // 
            // odpoved2
            // 
            this.odpoved2.AutoSize = true;
            this.odpoved2.Location = new System.Drawing.Point(311, 117);
            this.odpoved2.Name = "odpoved2";
            this.odpoved2.Size = new System.Drawing.Size(73, 17);
            this.odpoved2.TabIndex = 9;
            this.odpoved2.TabStop = true;
            this.odpoved2.Text = "odpoved2";
            this.odpoved2.UseVisualStyleBackColor = true;
            // 
            // odpoved3
            // 
            this.odpoved3.AutoSize = true;
            this.odpoved3.Location = new System.Drawing.Point(311, 140);
            this.odpoved3.Name = "odpoved3";
            this.odpoved3.Size = new System.Drawing.Size(73, 17);
            this.odpoved3.TabIndex = 10;
            this.odpoved3.TabStop = true;
            this.odpoved3.Text = "odpoved3";
            this.odpoved3.UseVisualStyleBackColor = true;
            // 
            // pocBodu
            // 
            this.pocBodu.AutoSize = true;
            this.pocBodu.Location = new System.Drawing.Point(434, 65);
            this.pocBodu.Name = "pocBodu";
            this.pocBodu.Size = new System.Drawing.Size(50, 13);
            this.pocBodu.TabIndex = 11;
            this.pocBodu.Text = "pocBodu";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(427, 126);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(57, 31);
            this.next.TabIndex = 12;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // celkBody
            // 
            this.celkBody.AutoSize = true;
            this.celkBody.Location = new System.Drawing.Point(433, 41);
            this.celkBody.Name = "celkBody";
            this.celkBody.Size = new System.Drawing.Size(51, 13);
            this.celkBody.TabIndex = 13;
            this.celkBody.Text = "celkBody";
            // 
            // opakovatTest
            // 
            this.opakovatTest.Location = new System.Drawing.Point(207, 293);
            this.opakovatTest.Name = "opakovatTest";
            this.opakovatTest.Size = new System.Drawing.Size(276, 86);
            this.opakovatTest.TabIndex = 14;
            this.opakovatTest.Text = "opakovat test";
            this.opakovatTest.UseVisualStyleBackColor = true;
            this.opakovatTest.Click += new System.EventHandler(this.opakovatTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opakovatTest);
            this.Controls.Add(this.celkBody);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pocBodu);
            this.Controls.Add(this.odpoved3);
            this.Controls.Add(this.odpoved2);
            this.Controls.Add(this.odpoved1);
            this.Controls.Add(this.otazka);
            this.Controls.Add(this.start);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.pocetOtazekText);
            this.Controls.Add(this.pocetOtazek);
            this.Controls.Add(this.title2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pocetOtazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.TrackBar pocetOtazek;
        private System.Windows.Forms.Label pocetOtazekText;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label otazka;
        private System.Windows.Forms.RadioButton odpoved1;
        private System.Windows.Forms.RadioButton odpoved2;
        private System.Windows.Forms.RadioButton odpoved3;
        private System.Windows.Forms.Label pocBodu;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label celkBody;
        private System.Windows.Forms.Button opakovatTest;
    }
}

