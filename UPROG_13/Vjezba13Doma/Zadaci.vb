Module Zadaci
    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesite ime dvije životinje.")
        Console.WriteLine(" Ako  Ako nizovi nisu jednaki ali imaju jednak broj znakova povezuje ih u")
        Console.WriteLine("jedan niz  uz dodavanje veznika  'ili'    između i znaka  '?' na kraju.")
        Console.WriteLine("Npr. za unose  ''ovca'', ''koza'' nakon konkatenacije ispis će biti")
        Console.WriteLine("'ovca  ili  koza?'   ")
        Console.WriteLine("Ako su nizovi jednaki  povezuje ih tako da ispis bude npr. ''vuk je samo vuk''")
        Console.WriteLine("Ako su nizovi razlicite duljine povezuje ih tako da ispis bude npr.  ''pas i mačka'' ")
        Console.WriteLine("Upis se vrši dok se ne unese ""Kraj"" ili ""kraj""")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim zivotinja1, zivotinja2 As String
        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Unesite prvu životinju: ")
            zivotinja1 = Console.ReadLine
            If zivotinja1.ToLower() = "kraj" Then Exit Do
            Console.WriteLine()
            Console.Write("Unesite drugu životinju: ")
            zivotinja2 = Console.ReadLine()
            If zivotinja2.ToLower() = "kraj" Then Exit Do
            Console.WriteLine()
            Call ZivotinjeIzPrvogZadatka(zivotinja1, zivotinja2)
        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub ZivotinjeIzPrvogZadatka(ByVal zivotinja1 As String, ByVal zivotinja2 As String)

        zivotinja1 = zivotinja1.ToLower()
        zivotinja2 = zivotinja2.ToLower()
        Select Case zivotinja1.Equals(zivotinja2)
            Case True
                Console.WriteLine("Stringovi su isti!")
                Console.WriteLine()
                Console.WriteLine(String.Concat(zivotinja1, " je samo ", zivotinja2))
                Exit Select
            Case False
                If zivotinja1.Length() = zivotinja2.Length() Then
                    Console.WriteLine("Stringovi nisu isti ali su iste dužine!")
                    Console.WriteLine()
                    Console.WriteLine(String.Concat(zivotinja1, " i ", zivotinja2))
                Else
                    Console.WriteLine("Stringovi nisu isti i nisu iste dužine!")
                    Console.WriteLine()
                    Console.WriteLine(String.Concat(zivotinja1, " ili ", zivotinja2, "?"))
                End If
                Exit Select
        End Select
    End Sub
    Friend Sub Zad2Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo 2 stringa te metodom compare ih uspoređujemo")
        Console.WriteLine("Odabir metode: ")
        Console.WriteLine(" 1 - Razlikujemo mala i velika slova")
        Console.WriteLine(" 2 - Ne razlikujemo mala i velika slova")
        Console.WriteLine("----------------------------------------------------------------------")

        Console.WriteLine()
        Console.WriteLine("Unesite prvi string: ")
        Dim prviString As String = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Unesite drugi string: ")
        Dim drugiString As String = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Odabir metode: ")
        Dim izbor As String = Console.ReadLine()
        Select Case izbor
            Case "1"

                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("1. - Razlikujemo mala i velika slova:")
                Console.WriteLine()
                Select Case String.Compare(prviString, drugiString)
                    Case 0
                        Console.WriteLine()
                        Console.WriteLine("Stringovi su jednaki")
                        Exit Select
                    Case -1
                        Console.WriteLine()
                        Console.WriteLine("Stringovi nisu jednaki")
                        Exit Select
                End Select
                Exit Select
            Case "2"
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("2. - Ne razlikujemo mala i velika slova:")
                Console.WriteLine()
                Select Case String.Compare(prviString, drugiString, True)
                    Case 0
                        Console.WriteLine()
                        Console.WriteLine("Stringovi su jednaki")
                        Exit Select
                    Case -1
                        Console.WriteLine()
                        Console.WriteLine("Stringovi nisu jednaki")
                        Exit Select
                End Select
                Exit Select
        End Select
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Class Osoba
        Public ime As String
        Public prezime As String


    End Class
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Kreirajte klasu Osoba koja ima dva polja - Ime  i Prezime ")
        Console.WriteLine(" Napišite kod koji:")
        Console.WriteLine("1. Deklarira dvije varijable tipom Osoba")
        Console.WriteLine("2. Prvoj varijabli pridružuje upućivanje na objekt")
        Console.WriteLine("3. Instanciranom objektu dodjeljuje proizvoljno ime i prezime")
        Console.WriteLine("4. Kopira upućivanje prve varijable u drugu")
        Console.WriteLine("5. Prvu varijablu oslobađa od upućivanja")
        Console.WriteLine("6. Provjerava sadrži li prva varijabla vrijednost Nothing")
        Console.WriteLine("7. Provjerava sadrži li druga varijabla upućivanje")
        Console.WriteLine("8. Ispisuje sadržaj druge varijable. ")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim osoba1, osoba2 As Osoba
        osoba1 = New Osoba()
        osoba1.ime = "Pero"
        osoba1.prezime = "Peric"
        osoba2 = osoba1
        osoba1 = Nothing
        Console.WriteLine(" Provjera dali prva varijabla sadrži vrijednos nothing: {0}", osoba1 Is Nothing)
        Console.WriteLine(" Provjerava dali druga varijabla sadrži upućivanje: {0}", osoba2 Is Nothing)
        Console.WriteLine("Ispis druge varijable: {0} {1} ", osoba2.ime, osoba2.prezime)

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad4Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Radimo klasu krug i metodu za izračun opsega i povrsine.")
        Console.WriteLine("Ispisujemo podatkovni član i sve članove objekta.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim krug1 As Krug = New Krug()

        Console.Write("Unesite radijus kruga: ")
        krug1.radijus = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Za radijus {0}, krug ima opseg {1} i površinu {2}.", krug1.radijus, krug1.IzračunajOpseg, krug1.IzračunajPovršinu)


        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Class Krug
        Public Const PI As Double = 3.141592
        Public radijus As Double
        Friend Function IzračunajOpseg()
            Return 2 * radijus * PI
        End Function
        Friend Function IzračunajPovršinu()
            Return radijus ^ 2 * PI
        End Function
    End Class
    Friend Sub Zad5Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Kreiramo klasu Tocka te u programu unesemo vrijednosti za x i y.")
        Console.WriteLine("Kada unesemo sve točke koje želimo, ispisujemo njihovu udaljenost od ishodišta.")
        Console.WriteLine("Postoji izbor za prestanak, siguran će biti unos jedne točke.")
        Console.WriteLine("Za prekid unosa unesite ""ne"" ili ""Ne"", za nastavak samo stisnite ""Enter"".")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim unesenaTocka As Tocka = New Tocka()
        Dim tocke As New List(Of Tocka)

        Dim izbor As String = "mozda"
        Dim brojac As Integer = 0
        Do
            Console.WriteLine("Unesite koordinate {0}. točke", brojac + 1)
            Console.Write("X: ")
            unesenaTocka.Xkoordinata = Console.ReadLine()


            Console.Write("Y: ")
            unesenaTocka.Ykoordinata = Console.ReadLine
            tocke.Add(New Tocka() With {
             .Xkoordinata = unesenaTocka.Xkoordinata,
             .Ykoordinata = unesenaTocka.Ykoordinata})
            brojac += 1

            Console.WriteLine()
            Console.Write("Dali želite još točaka? ")
            izbor = Console.ReadLine()

        Loop Until izbor.ToLower = "ne"


        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Udaljenosti unešenih točki od ishodišta su: ")
        Console.WriteLine("      X         Y         D")
        Console.WriteLine("----------------------------------------------------------------------")
        For Each tocka In tocke
            Console.WriteLine("{0,5}        {1,5}       {2,5}", tocka.Xkoordinata, tocka.Ykoordinata, tocka.IzračunUdaljenostiOd0)
        Next


        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub
    Friend Class Tocka
        Public Property Xkoordinata() As Double
            Get
                Return x
            End Get
            Set(value As Double)
                x = value
            End Set
        End Property
        Private x As Double
        Public Property Ykoordinata() As Double
            Get
                Return y
            End Get
            Set(value As Double)
                y = value
            End Set
        End Property
        Private y As Double


        Public Function IzračunUdaljenostiOd0()
            Return (Math.Sqrt((x ^ 2 + y ^ 2)))
        End Function

    End Class
End Module
