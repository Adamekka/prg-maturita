//
// Trofej.cs
//
// Copyright © 2024 Adam Cvikl
//

internal abstract class Trofej : HObjekt {
    private protected string Nazev { get; }
    private protected int Mnozstvi { get; }

    private protected Trofej(string nazev, int mnozstvi) {
        this.Nazev = nazev;
        this.Mnozstvi = mnozstvi;
    }
}
