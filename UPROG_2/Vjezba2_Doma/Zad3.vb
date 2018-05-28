Friend Module Zad3
    Friend Sub Zad3sub()
        Dim uneseniBroj As Integer
        Console.WriteLine("Ovaj program provjerava dali je unešeni cijeli broj djeljiv sa 7, te ako nije za koliko ga trebamo uvečati kako bi bio djeljiv sa 7")
        Console.WriteLine("----------------")
        Console.Write("Unesite broj: ")
        uneseniBroj = Console.ReadLine()
        Console.WriteLine("----------------")
        If uneseniBroj Mod 7 = 0 Then
            Console.WriteLine("Broj {0} je djeljiv sa 7!", uneseniBroj)
        Else
            Console.WriteLine("Broj {0} nije djeljiv sa 7, te ga moramo uvečati za {1} kako bi dobili broj {2} koji je djeljiv sa 7.", uneseniBroj, 7 - uneseniBroj Mod 7, uneseniBroj + (7 - (uneseniBroj Mod 7)))
        End If
        Console.ReadLine()
    End Sub

End Module
