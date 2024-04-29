//
// Poklad.cs
//
// Copyright © 2024 Adam Cvikl
//

internal sealed class Poklad : Trofej {
    private int PocetZlataku { get; }

    internal Poklad() : base("Trofej", 10) => this.PocetZlataku = this.Mnozstvi;

    internal void PridejBohatstvi(Hrac postava) => postava.Bohatstvi += this.PocetZlataku;
}
