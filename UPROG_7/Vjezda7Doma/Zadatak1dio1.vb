Module Zadatak1dio1
    Public Const PI = 3.14

    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Izracun povrsine i opsega kruga, koristeci dva sub-a te by val predaje")
        Console.WriteLine("kopije vrijednosti podataka, PI je public konstanta")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim radiusKruga As Single
        Console.Write("Unesite radijus kruga:")
        radiusKruga = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Call IzracunajPovrsinuKruga(radiusKruga)
        Call IzracunajOpsegKruga(radiusKruga)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub IzracunajPovrsinuKruga(ByVal radiusKruga As Single)
        Console.WriteLine("Povrsina kruga iznosi: {0}", radiusKruga ^ 2 * PI)
    End Sub

End Module
