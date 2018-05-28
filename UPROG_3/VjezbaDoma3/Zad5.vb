Module Zad5
    Friend Sub Zad5sub()
        Dim najManji, najVeci, a, b, c, srednji As Double
        Console.WriteLine("------------------------------------------------------------------------")
        Console.WriteLine("Program traži unos 3 broja te ih ispisuje od najmanje do najveceg.")
        Console.WriteLine("------------------------------------------------------------------------")
        Console.Write("Unesite prvi broj:")
        a = Console.ReadLine()
        Console.Write("Unesite drugi broj:")
        b = Console.ReadLine()
        Console.Write("Unesite treći broj:")
        c = Console.ReadLine
        najManji = a
        najVeci = a
        srednji = a
        If a > b Then
            najManji = b
        ElseIf a > c Then
            najManji = c
        End If
        If a > b Then
            najVeci = b
        ElseIf a < c Then
            najVeci = c
        End If
        If najManji < b Then
            srednji = b
        ElseIf najManji < c Then
            srednji = c


        End If
        Console.WriteLine("{0} {1} {2}", najManji, srednji, najVeci)
        Console.WriteLine("{0} {1} {2}", najVeci, srednji, najManji)
        Call daliZelitejossub()

    End Sub
End Module
