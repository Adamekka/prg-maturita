//
// Hrac.cs
//
// Copyright © 2024 Adam Cvikl
//

internal abstract class Hrac : HObjekt {
    private protected string Jmeno { get; }
    protected internal int PocetZivotu { get; private set; }
    internal int Obratnost { get; }
    protected internal int Sila { get; set; }
    internal int Bohatstvi { get; set; }
    internal List<Trofej> Inventar { get; set; }

    private protected Hrac(string jmeno) {
        this.Jmeno = jmeno;
        this.PocetZivotu = 100;
        this.Obratnost = 5;
        this.Sila = 10;
        this.Bohatstvi = 0;
        this.Inventar = new();
    }

    private protected void SetPocetZivotu(int c) {
        this.PocetZivotu = c;

        if (this.PocetZivotu <= 0) {
            Console.WriteLine($"Hrac {this.Jmeno} umrel");
        }
    }

    protected internal void IncPocetZivotu(int c) => this.PocetZivotu += c;

    protected internal void DecPocetZivotu(int c) {
        this.PocetZivotu -= c;

        if (this.PocetZivotu <= 0) {
            Console.WriteLine($"Hrac {this.Jmeno} umrel");
        }
    }

    private protected void Leceni() => this.PocetZivotu++;

    internal void DecBohatstvi(int c) {
        this.Bohatstvi -= c;

        if (this.Bohatstvi <= 0) {
            this.Bohatstvi = 0;
        }
    }
}
