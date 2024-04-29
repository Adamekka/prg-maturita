//
// Alchymista.cs
//
// Copyright © 2024 Adam Cvikl
//

internal sealed class Alchymista : Hrac {
    internal int Inteligence { get; set; }

    internal Alchymista() : base("Alchymista") => this.Inteligence = 5;

    internal void Vylecit(Hrac postava) {
        var random = new Random();
        postava.IncPocetZivotu(random.Next(0, this.Inteligence + 1));
    }
}
