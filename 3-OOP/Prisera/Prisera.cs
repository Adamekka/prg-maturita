//
// Prisera.cs
//
// Copyright © 2024 Adam Cvikl
//

internal abstract class Prisera : HObjekt {
    private string Jmeno { get; }
    private protected int Obratnost { get; }
    internal int Sila { get; }
    private int PocetZivotu { get; set; }

    private protected Prisera(string jmeno) {
        this.Jmeno = jmeno;
        this.Obratnost = 5;
        this.Sila = 10;
        this.PocetZivotu = 30;
    }

    protected internal void Boj(Hrac postava) {
        var random = new Random();
        var sila = random.Next(0, this.Sila + 1);

        this.PocetZivotu -= Math.Clamp(postava.Sila - sila, 0, int.MaxValue);

        if (this.PocetZivotu <= 0) {
            Console.WriteLine($"Prisera {this.Jmeno} umrela");
        }
    }
}
