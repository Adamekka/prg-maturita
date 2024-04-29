//
// HObjekt.cs
//
// Copyright © 2024 Adam Cvikl
//

internal abstract class HObjekt {
    private protected int Pos { get; } = Pozice();

    private static int Pozice() {
        var random = new Random();
        return random.Next(0, 101);
    }
}
