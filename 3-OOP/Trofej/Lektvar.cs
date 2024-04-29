//
// Lektvar.cs
//
// Copyright © 2024 Adam Cvikl
//

internal sealed class Lektvar : Trofej {
    private int Velikost { get; }

    internal Lektvar() : base("Lektvar", 10) => this.Velikost = this.Mnozstvi;

    internal void PridejInteligenci(Alchymista alchymista) => alchymista.Inteligence += this.Velikost;
}
