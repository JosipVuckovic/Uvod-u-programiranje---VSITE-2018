Friend Module Zad5
    Friend Sub Zad5sub()
        Dim terasaA As Integer
        Dim povrsinaTerase As Integer
        Dim plociceC As Integer
        Dim plociceD As Integer
        Dim povrsinaPlocice As Integer

        Console.WriteLine("Unesite dimenzije a*a u metrima")
        Console.WriteLine("-------------------------------")
        Console.Write("a=")
        terasaA = Console.ReadLine()
        Console.WriteLine("Dimenzija pločica c*d u centimetrima")
        Console.WriteLine("------------------------------------")
        Console.Write("c=")
        plociceC = Console.ReadLine()
        Console.Write("d=")
        plociceD = Console.ReadLine()
        Console.WriteLine("------------------------------------")
        povrsinaTerase = terasaA * terasaA * 10_000
        povrsinaPlocice = plociceC * plociceD
        Dim brojPlocica As Integer
        brojPlocica = povrsinaTerase \ povrsinaPlocice
        Dim ukupnoPlocica As Integer
        Dim cijelihPlocica As Integer
        If povrsinaTerase Mod povrsinaPlocice > 0 Then
            ukupnoPlocica = brojPlocica + (povrsinaPlocice Mod brojPlocica)
            cijelihPlocica = brojPlocica - (povrsinaPlocice Mod brojPlocica)
            Console.WriteLine("-------------------------------------------------")
            Console.WriteLine("Za popločiti cijelu terasu će trebati {0} pločica.", ukupnoPlocica)
            Console.WriteLine("Na terasi će biti {0} cijelih pločica.", cijelihPlocica)
        Else
            Console.WriteLine("-------------------------------------------------")
            Console.WriteLine("Za popločiti cijelu terasu će trebati {0} pločica.", brojPlocica)
        End If
        'Console.WriteLine("Dali želite neki drugi zadatak? y/n")
        'Dim izbor As Char
        'izbor = Console.ReadLine()
        'If izbor = "y" Then

        'Else
        '    Console.ReadLine()
        'End If
        Console.ReadLine()




    End Sub

End Module
