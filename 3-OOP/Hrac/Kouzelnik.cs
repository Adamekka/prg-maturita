//
// Kouzelnik.cs
//
// Copyright © 2024 Adam Cvikl
//

internal sealed class Kouzelnik : Hrac {
    private int Magie { get; }

    internal Kouzelnik() : base("Kouzelnik") => this.Magie = 5;

    internal void Kouzli(Hrac postava) => postava.Sila += this.Magie;
}
