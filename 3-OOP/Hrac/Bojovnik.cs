//
// Bojovnik.cs
//
// Copyright © 2024 Adam Cvikl
//

internal sealed class Bojovnik : Hrac {
    internal Bojovnik() : base("Bojovnik") { }

    internal void Boj(Prisera prisera) {
        var random = new Random();
        var sila = random.Next(0, this.Sila + 1);

        this.DecPocetZivotu(Math.Clamp(prisera.Sila - sila, 0, int.MaxValue));
    }
}
