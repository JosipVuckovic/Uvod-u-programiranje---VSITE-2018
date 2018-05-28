Module Zad4
    Sub Main()
        Dim stranicaA As Single
        Dim StranicaB As Single
        Dim rezultat As Single
        Console.WriteLine("Ovaj program računa dijagonalu pravokutnika")
        Console.Write("Unesite prvu stranicu: a=")
        stranicaA = Console.ReadLine()
        Console.Write("Unesite drugu stranicu: b=")
        StranicaB = Console.ReadLine()
        rezultat = Math.Sqrt((stranicaA ^ 2) + (StranicaB ^ 2))
        Console.WriteLine("Dijagonala pravokutnika je d={0}", rezultat)
        ' Console.WriteLine("Dijagonala pravokutnika je d={0}", Math.Sqrt((stranicaA ^ 2) + (StranicaB ^ 2)))
        Console.ReadLine()
    End Sub
End Module
