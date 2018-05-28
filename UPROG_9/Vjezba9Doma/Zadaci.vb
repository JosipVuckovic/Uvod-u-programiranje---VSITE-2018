Module Zadaci
    Friend Sub Zad1Sub()
        Dim filmovi = New String(4) {}
        Dim rnd As New Random
        Dim izgenerirano As Byte
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Traži se unos 5 filmva (bez petlje), te se nakon toga isti ispisuju")
        Console.WriteLine("Ispisi je random tako da je moguce da ne budu svi ispisani ili budu")
        Console.WriteLine("duplo ispisani")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite ime prvog filma: ")
        filmovi(0) = Console.ReadLine()
        Console.Write("Unesite ime drugog filma: ")
        filmovi(1) = Console.ReadLine()
        Console.Write("Unesite ime treceg filma: ")
        filmovi(2) = Console.ReadLine()
        Console.Write("Unesite ime cetvrtog filma: ")
        filmovi(3) = Console.ReadLine()
        Console.Write("Unesite ime petog filma: ")
        filmovi(4) = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Ispis filmova ne slijedi red unosa")
        Console.WriteLine("----------------------------------------------------------------------")
        izgenerirano = rnd.Next(0, 4)
        Console.WriteLine(filmovi(izgenerirano))
        izgenerirano = rnd.Next(0, 4)
        Console.WriteLine(filmovi(izgenerirano))
        izgenerirano = rnd.Next(0, 4)
        Console.WriteLine(filmovi(izgenerirano))
        izgenerirano = rnd.Next(0, 4)
        Console.WriteLine(filmovi(izgenerirano))
        izgenerirano = rnd.Next(0, 4)
        Console.WriteLine(filmovi(izgenerirano))
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad2Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Traži se unos 5 cijelobrojnih vrijednosti te se one ispisuju.")
        Console.WriteLine("Upisi i ispis se izvode for next petljom")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim niz(4) As Integer
        Dim index As Integer
        For index = 0 To 4 Step 1
            Console.Write("Unesi {0} elemeni: ", index + 1)
            niz(index) = Console.ReadLine()
        Next index
        Console.WriteLine("----------------------------------------------------------------------")
        For index = 0 To 4 Step 1
            Console.WriteLine("element({0}): {1} ", index + 1, niz(index))
        Next index
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Deklaria se niz od 30 stringova te se na parne indekse stavlja <.")
        Console.WriteLine("Nakon toga upisujemo sto zelimo na neparne indexe.")
        Console.WriteLine("Zavrsava kada unesemo ""Enter"".")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Dim niz(29) As String
        For i = 0 To 28 Step 2
            niz(i) = "<"
        Next
        Dim unosKorisnika As String
        Do
            Console.WriteLine()
            Console.Write("Unesite jedan ili više znakova, ""Enter"" za kraj: ")
            unosKorisnika = Console.ReadLine()
            If unosKorisnika = "" Then Exit Do
            For i = 1 To 29 Step 2
                niz(i) = unosKorisnika
            Next i
            Console.WriteLine()
            For i = 0 To 29 Step 1

                Console.Write(niz(i))
            Next
            Console.WriteLine()
        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad4Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unose se temperture za cijeli tjedan, te se izracunava prosjecna temp.")
        Console.WriteLine("Također se ispisuje najveca razlika između dva dana.")
        Console.WriteLine("A za bonus, budemo sortirali array i naisali najvecu i najmanju temp.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim tjedan = New String(6) {"ponedljeljak", "utorak", "srijeda", "cetvrtak", "petak", "subota", "nedjelja"}
        Dim temperatura(7) As Single
        Dim maxDnevnaRazlika, prosjecnaTemp, dnevnaRazlika As Single
        Console.WriteLine()
        For i = 0 To 6 Step 1
            Console.Write("Unesite temperaturu za {0}: ", tjedan(i))
            temperatura(i) = Console.ReadLine()
            prosjecnaTemp += temperatura(i)
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        For i = 0 To 6 Step 1
            Console.WriteLine("Temperatura za {0}: {1} °C", tjedan(i), temperatura(i))
            dnevnaRazlika = Math.Abs(temperatura(i) - temperatura(i + 1))
            If maxDnevnaRazlika < dnevnaRazlika Then maxDnevnaRazlika = dnevnaRazlika
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Prosjecna temperatura tjedan je bila: {0}°C.", prosjecnaTemp / 7)
        Console.WriteLine("Najveca razlika između dva uzastopna dana je bila: {0}°C.", maxDnevnaRazlika)
        Array.Sort(temperatura)
        Console.WriteLine("Najmanja temperatura je bila {0}°C, a najveca {1}°C.", temperatura(0), temperatura(6))
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub

End Module
