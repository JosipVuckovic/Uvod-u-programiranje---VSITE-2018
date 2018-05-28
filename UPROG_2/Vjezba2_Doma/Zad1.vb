Friend Module Zad1

    Friend Sub Zad1sub()
        Dim prviBroj As Integer
        Dim drugiBroj As Integer
        Console.WriteLine("Ovaj program traži unos dva cijela broja te gleda dali je prvi broj djeljiv sa drugim brojem.")
        Console.WriteLine("")
        Console.Write("Unesite prvi broj: ")
        prviBroj = Console.ReadLine()
        Console.Write("Unesite drugi broj: ")
        drugiBroj = Console.ReadLine()
        If prviBroj Mod drugiBroj = 0 Then Console.WriteLine("Broj {0} je djeljiv sa brojem {1}.", prviBroj, drugiBroj)
        If prviBroj Mod drugiBroj <> 0 Then Console.WriteLine("Broj {0} nije djeljiv sa brojem {1}.", prviBroj, drugiBroj)
        Console.ReadLine()

    End Sub

End Module

