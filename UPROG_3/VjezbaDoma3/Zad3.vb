Module Zad3
    Friend Sub Zad3sub()
        Dim godina As Integer
        Console.WriteLine("----------------------------------------------------------")
        Console.WriteLine("Program ispisuje povijesni period ovisno o unešenoj godini")
        Console.WriteLine("Za unos godine prije nove ere koristite - ")
        Console.WriteLine("----------------------------------------------------------")
        Console.Write("Unesite godinu: ")
        godina = Console.ReadLine()
        Select Case godina
            Case Is < -3500
                Console.WriteLine("Prapovijest")

            Case Is < 0
                Console.WriteLine("Povijest")

            Case Is < 476
                Console.WriteLine("Stari Vijek")

            Case Is < 1492
                Console.WriteLine("Srednji Vijek")

            Case Is < 1918
                Console.WriteLine("Novi Vijek")

            Case Is > 1918
                Console.WriteLine("Suvremeno Doba")

            Case Else
                Exit Select
        End Select

        Call daliZelitejossub()
    End Sub
End Module
