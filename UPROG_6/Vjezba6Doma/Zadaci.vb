Module Zadaci
    Private stranicaA, stranicaB As Integer
    'Private povrsina, dijagonala As Double
    Public Function IzracunPovrsine(ByVal a As Integer, b As Integer)
        Return a * b
    End Function
    Public Function Potenciranje(ByVal baza As Integer, eksponent As Integer)
        Dim broj As Integer = 1
        For i = 1 To eksponent Step 1
            broj = broj * baza
        Next
        Return broj
    End Function
    Public Function IzracunDijagonale(ByVal a As Double, b As Double)
        Return Math.Sqrt(a ^ 2 + b ^ 2)
    End Function
    Public Function ProvjerDaliJeProstiBroj(ByVal broj As Integer) As Boolean
        If broj = 2 Then Return True
        If broj Mod 2 = 0 Then Exit Function
        Dim provjera, granica As Integer
        provjera = broj
        granica = 3
        Do While provjera > granica
            If provjera Mod granica = 0 Then Exit Function
            granica = granica + 2
        Loop
        Return True
        'Vrlo sam sretan zbog ovoga!!!!!!!!!! YaY

    End Function
    Public Function TrazenjeZnamenke(ByVal broj, ByVal trazenaznamenka)
        Dim znamenka As Integer
        Dim brojac As Integer
        znamenka = broj
        Do
            znamenka = broj Mod 10
            If broj Mod 10 = trazenaznamenka Then brojac += 1
            broj = broj \ 10
        Loop Until broj = 0
        Return brojac
    End Function
    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program racuna povrsinu i dijagonalu pravokutnika sve dok se za jednu ")
        Console.WriteLine("dimenziju ne unese 0, ne radi direktno nego koristi sub proceduru")
        Console.WriteLine("----------------------------------------------------------------------")
        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Unesite stranicu a:")
            stranicaA = Console.ReadLine()
            If stranicaA = 0 Then Exit Do
            Console.Write("Unesite stranicu b:")
            stranicaB = Console.ReadLine()
            If stranicaB = 0 Then Exit Do
            Call IzracunajPovrsinuDijagonale(stranicaA, stranicaB)
        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Private Sub IzracunajPovrsinuDijagonale(ByVal stranicaA As Integer, ByVal stranicaB As Integer)
        Console.WriteLine("Povrsina pravokutnika je: {0}", stranicaA * stranicaB)
        Console.WriteLine("Dijagonala pravokutinka je: {0}", Math.Sqrt(stranicaA ^ 2 + stranicaB ^ 2))
        'Console.WriteLine("----------------------------------------------------------------------")
    End Sub
    Friend Sub Zad2Sub()
        Console.Clear()
        Dim stranicaAZad2, stranicaBZad2 As Integer
        Dim povrsina, dijagonala As Single

        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program racuna povrsinu i dijagonalu pravokutnika sve dok se za jednu ")
        Console.WriteLine("dimenziju ne unese 0, ne radi direktno nego koristi sub proceduru")
        Console.WriteLine("----------------------------------------------------------------------")
        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Unesite stranicu a:")
            stranicaAZad2 = Console.ReadLine()
            If stranicaAZad2 = 0 Then Exit Do
            Console.Write("Unesite stranicu b:")
            stranicaBZad2 = Console.ReadLine()
            If stranicaBZad2 = 0 Then Exit Do
            povrsina = IzracunPovrsine(stranicaAZad2, stranicaBZad2)
            Console.WriteLine("Povrsina pravokutinka je:{0}", povrsina)
            dijagonala = IzracunDijagonale(stranicaAZad2, stranicaBZad2)
            Console.WriteLine("Dijagonala pravokutika je:{0}", dijagonala)


        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos baze i eksponeta te vraca rezultat. ")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim baza, eksponent, vrijednost As Integer
        Console.Write("Unesite bazu broja:")
        baza = Console.ReadLine()
        Console.Write("Unesite eksponent broja:")
        eksponent = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        vrijednost = Potenciranje(baza, eksponent)
        Console.WriteLine("Vrijdnost broja je:{0}", vrijednost)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub
    Friend Sub Zad4Sub()
        Dim brojZaProvjeru, brojac As Integer
        Dim prostiBrojProvjera As Boolean = False

        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos prirodnih brojeva sve dok se ne ucita prosti broj ")
        Console.WriteLine("----------------------------------------------------------------------")
        Do
            Console.Write("Unesite prirodni broj:")
            brojZaProvjeru = Console.ReadLine()
            If brojZaProvjeru = 0 Or brojZaProvjeru < 0 Then
                brojac = brojac - 1
                Console.WriteLine("{0} ne spada u prirodne brojeve!!!", brojZaProvjeru)
            End If
            brojac += 1
            prostiBrojProvjera = ProvjerDaliJeProstiBroj(brojZaProvjeru)
        Loop Until prostiBrojProvjera = True

        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Prosti broj {0} je unesen, bilo je {1} slozenih brojeva", brojZaProvjeru, brojac - 1)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad5Sub()
        Console.Clear()
        Dim broj, znamenka, brojacZnamenke As Integer
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos broja te ispisuje koliko puta se ponavlja trazena  ")
        Console.WriteLine("znamenka sve dok korisnik ne unese 0")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite broj:")
        broj = Console.ReadLine()
        Console.Write("Unesite znamenku koja se traži:")
        znamenka = Console.ReadLine()

        brojacZnamenke = TrazenjeZnamenke(broj, znamenka)
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("U broju {0} znamenka {1} se ponavlja {2} puta.", broj, znamenka, brojacZnamenke)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
End Module
