Module glavniIzbornik

    Sub Main()
        Dim izborZadatka As Integer
        Console.WriteLine("Ovaj program dozvoljava pokretanje svih 5 zadataka. U donjem izborniku možete vidjeti opis svakog zadatka.")
        Console.WriteLine("Zadatak 1 - If...Then Pregled djeljivosti dvaju cijelih brojeva")
        Console.WriteLine("Zadatak 2 - If...Then... Else Računanje ukopnog otpora dva otpornika ovisno o spoju")
        Console.WriteLine("Zadatak 3 - If...Then... Else.. grananje Djeljivost cijelog broja s brojem 7, te koliko treba dodati kako bi bilo djeljivo sa 7")
        Console.WriteLine("Zadatak 4 - If unutar If-a te razne igre s unešenim brojem")
        Console.WriteLine("Zadatak 5 - If...Then Koliko pločica treba za popločiti terasu")
        Console.Write("Molim Vas unesite broj zadatka koji Vas zanima: ")
        izborZadatka = Console.ReadLine()
        If izborZadatka = 1 Then
            Call Zad1sub()
        ElseIf izborZadatka = 2 Then
            Call Zad2sub()
        ElseIf izborZadatka = 3 Then
            Call Zad3sub()
        ElseIf izborZadatka = 4 Then
            Call zad4sub()
        ElseIf izborZadatka = 5 Then
            Call Zad5sub()
        End If
    End Sub

End Module
