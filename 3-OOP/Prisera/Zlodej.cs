//
// Zlodej.cs
//
// Copyright © 2024 Adam Cvikl
//

internal sealed class Zlodej : Prisera {
    internal Zlodej() : base("Zlodej") { }

    internal void Kradez(Hrac postava) {
        var random = new Random();
        var obratnost = random.Next(0, postava.Obratnost);

        postava.DecBohatstvi(Math.Clamp(this.Obratnost - obratnost, 0, int.MaxValue));
    }
}
