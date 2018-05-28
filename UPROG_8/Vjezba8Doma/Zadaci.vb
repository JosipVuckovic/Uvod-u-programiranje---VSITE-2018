Module Zadaci
    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos temperature u celzijima te ih preračunava u kelvine")
        Console.WriteLine("i farenhajte. Unos prestaje kada se unese 0.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim tempC As Double
        Do
            Console.Write("Unesite temperaturu u °C: ")
            tempC = Console.ReadLine()
            Console.WriteLine("{0}°C = {1}K", tempC, IzracunajKelvine(tempC))
            Console.WriteLine("{0}°C = {1}°F", tempC, IzracunajFarehajte(tempC))
            Console.WriteLine()
        Loop Until tempC = 0
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Function IzracunajKelvine(ByVal tempC As Double) As Double
        Return tempC + 273.15
    End Function
    Friend Function IzracunajFarehajte(ByVal tempC As Double) As Double
        Return tempC * 1.8 + 32
    End Function
    Friend Sub Zad2Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos imena i prezimena, te mjesta rođenja osobe, ukoliko")
        Console.WriteLine("mjesto rođenja nije unešeno, podrazumijva se Zagreb")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesite ime i prezime:")
        Dim imePrezime As String = Console.ReadLine()
        Console.WriteLine("Unesite mjesto rođenja:")
        Dim mjestoRodenja As String = Console.ReadLine()
        If mjestoRodenja = "" Then
            Call IspisiPodatke(imePrezime)
        Else
            Call IspisiPodatke(imePrezime, mjestoRodenja)
        End If
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Private Sub IspisiPodatke(ByVal imePrezime As String, Optional ByVal mjestoRodenja As String = "Zagreb")
        Console.WriteLine("Ime i prezime: {0}", imePrezime)
        Console.WriteLine("Mjesto rođenja: {0}", mjestoRodenja)
    End Sub
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos zemlje, glavnog grada,pozivnog broja i valute")
        Console.WriteLine("ispisuje pomocu dvije procedure")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite zemlju: ")
        Dim zemlja As String = Console.ReadLine()
        Console.Write("Unesite glavni grad: ")
        Dim glavniGrad As String = Console.ReadLine()
        Console.Write("Unesite pozivni broj: ")
        Dim pozivniBroj As String = Console.ReadLine()
        Console.Write("Unesite valutu: ")
        Dim valuta As String = Console.ReadLine()
        Call Ispis(zemlja, glavniGrad)
        Call Ispis(zemlja, glavniGrad, pozivniBroj, valuta)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Private Sub Ispis(ByVal zemlja As String, ByVal glavniGrad As String)
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Zemlja: {0}", zemlja)
        Console.WriteLine("Glavni grad: {0}", glavniGrad)
    End Sub
    Private Sub Ispis(ByVal zemlja As String, ByVal glavniGrad As String, ByVal pozivniBroj As String, ByVal valuta As String)
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Zemlja: {0}", zemlja)
        Console.WriteLine("Glavni grad: {0}", glavniGrad)
        Console.WriteLine("Pozivni broj: {0}", pozivniBroj)
        Console.WriteLine("Valuta: {0}", valuta)
    End Sub
    Friend Sub Zad4Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos cijelog od 1 do 99999 te vraća broj s okrenutim")
        Console.WriteLine("znamenkama. Ukoliko se unese broj izvan tog raspona, program se prekida.")
        Console.WriteLine("Ukoliko su pocetne znamenke okrenutog broja nule, one se nece ispisati.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim broj As Long
        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Unesite broj: ")
            broj = Console.ReadLine()
            Console.WriteLine("Okrenute znamenek broja {0} su {1}", broj, OkreniZnamenke(broj))
            Console.WriteLine("----------------------------------------------------------------------")
        Loop While broj > 1 And broj < 99999
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Function OkreniZnamenke(ByVal broj As Long) As Long
        Dim znamenka As Long
        Dim obrnutiBroj As Long
        Do
            znamenka = broj Mod 10
            obrnutiBroj = obrnutiBroj & znamenka
            broj \= 10
        Loop Until broj = 0

        Return obrnutiBroj
    End Function
    Friend Sub Zad5Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unost količine brojeva koje korisnik želi unjeti te broji")
        Console.WriteLine("koliko je već brojeva unešeno te koji je najveći.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite koliko brojeva želite unjeti: ")
        Dim kolikoBrojeva As Integer = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Dim uneseniBroj As Double
        Dim i As Integer
        For i = 1 To kolikoBrojeva Step +1
            Console.Write("Unesite broj: ")
            uneseniBroj = Console.ReadLine()
            Call KolikoPutaNajveciBroj(uneseniBroj, i, kolikoBrojeva)

        Next i

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Private Sub KolikoPutaNajveciBroj(ByRef uneseniBroj As Double, ByRef i As Integer, ByRef kolikoBrojeva As Integer)
        Static brojac As Integer
        Static najveciBroj As Double
        brojac += 1
        If uneseniBroj > najveciBroj Then najveciBroj = uneseniBroj
        Console.WriteLine("Od {0} do sada učitanih brojeva najveći je {1}", brojac, najveciBroj)
        If i = kolikoBrojeva Then
            brojac = 0
            najveciBroj = 0
        End If

    End Sub
End Module
