Module Zadaci
    Friend Sub Zadatak1ASub(ByVal niz() As Short)
        Dim zamjena As Short = niz(0)
        niz(0) = niz(4)
        niz(4) = zamjena
    End Sub
    Friend Sub Zadatak1BSub(ByRef prvi As Short, ByRef zadnji As Short)
        Dim zamjena As Short = zadnji
        zadnji = prvi
        prvi = zamjena
    End Sub
    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosi se 5 brojeva, zamjenjujemo prvi i zadnji preko procedure")
        Console.WriteLine("Morate izabrati kako se zadatk rješava, s subom kojemu šaljemo svaki")
        Console.WriteLine("element niza ili subom kojemu šaljemo već uneseni niz.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Izaberite koji dio zadatka želite.")
        Console.WriteLine(" 1 - Procedura prima samo varijablu upucivanja.")
        Console.WriteLine(" 2 - Procedura prima prvi i zadnji član")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write(" Vaš odabir: ")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim odabiPodzadatka As String = Console.ReadLine()
        Dim niz(4) As Short
        Select Case odabiPodzadatka

            Case "1"
                Console.WriteLine("Preko jednog člana niza.")
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("Unesite tocno 5 elemenata niza.")
                For i = 0 To 4 Step 1
                    Console.Write("Unesite {0} element: ", i + 1)
                    niz(i) = Console.ReadLine

                Next
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine(" Unešeni niz:")
                For i = 0 To 4 Step 1
                    Console.Write("{0,5}", niz(i))
                Next
                Console.WriteLine()
                Console.WriteLine("----------------------------------------------------------------------")
                Call Zadatak1ASub(niz)
                Console.WriteLine("Nakon procedure:")
                For i = 0 To 4 Step 1
                    Console.Write("{0,5}", niz(i))
                Next
                Console.WriteLine()
                Exit Select
            Case "2"
                Console.WriteLine("Preko jednog člana niza.")
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("Unesite tocno 5 elemenata niza.")
                For i = 0 To 4 Step 1
                    Console.Write("Unesite {0} element: ", i + 1)
                    niz(i) = Console.ReadLine

                Next
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine(" Unešeni niz:")
                For i = 0 To 4 Step 1
                    Console.Write("{0,5}", niz(i))
                Next
                Console.WriteLine()
                Call Zadatak1BSub(niz(0), niz(4))
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("Nakon procedure:")
                For i = 0 To 4 Step 1
                    Console.Write("{0,5}", niz(i))
                Next
                Console.WriteLine()
                Exit Select
            Case Else
                Console.WriteLine("Nepoznat unos, ponovite zadatak...")
                Console.ReadLine()
                Call Zad1Sub()
                Exit Select
        End Select



        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad2Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Inicijaliziran je array od 7 integera te ispisujemo i sortiramo")
        Console.WriteLine("----------------------------------------------------------------------")
        'Ovo se traži, ali di je tu zabava???
        'Dim niz() As Integer = {23, 45, 3, 5, 99, 4, 56} 
        Dim nizRandom(6) As Integer
        Dim nestoDivlje As New Random
        Console.Write("Unesite donju granicu za random generator:  ")
        Dim donja As Integer = Console.ReadLine()
        Console.Write("Unesite gornju granicu za random generator:  ")
        Dim gornja As Integer = Console.ReadLine()
        For i As Integer = 0 To 6 Step 1
            nizRandom(i) = nestoDivlje.Next(donja, gornja)
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Naš niz:")
        Call IspisiNiz(nizRandom)
        Console.WriteLine("")
        Console.WriteLine("Naš obrnuti niz:")
        Array.Reverse(nizRandom)
        Call IspisiNiz(nizRandom)
        Console.WriteLine("")
        Console.WriteLine("Pa smo ga sortirali u rastucem poretku")
        Array.Sort(nizRandom)
        Call IspisiNiz(nizRandom)
        Console.WriteLine("")
        Console.WriteLine("Pa smo i njega okrenuli da dobijemo u padajucem")
        Array.Reverse(nizRandom)
        Call IspisiNiz(nizRandom)
        Console.WriteLine("")
        Console.WriteLine("Najmanji caln niza je {0} a najveci clan je {1}", nizRandom(6), nizRandom(0))
        Console.WriteLine("")
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub IspisiNiz(ByVal niz() As Integer)

        For Each broj As Integer In niz

            Console.Write(broj & " ")



        Next
        Console.WriteLine()
    End Sub
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program za pračenje planiranih sati učenja, broj planiranih sati")
        Console.WriteLine("Broj potrebnih planiranih sati je unešen, a korisnik unosi koliko je on")
        Console.WriteLine("sati učio.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim planiraniSatiUcenja() As Integer = {3, 5, 2, 4, 1}
        Console.WriteLine("Unos ostvarenih sati učenja:")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim uneseniSatiUcenja(4) As Integer
        For i As Integer = 0 To planiraniSatiUcenja.GetUpperBound(0)
            Console.Write("{0}. dan: ", i + 1)
            uneseniSatiUcenja(i) = Console.ReadLine()
        Next
        Dim razlikaSati(4) As Integer
        For i = 0 To uneseniSatiUcenja.GetUpperBound(0)
            razlikaSati(i) = uneseniSatiUcenja(i) - planiraniSatiUcenja(i)
        Next
        Console.WriteLine("Planirani sati učenja:")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Call IspisiNiz(planiraniSatiUcenja)
        Console.WriteLine()
        Console.WriteLine("Ostvarni sati učenja:")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Call IspisiNiz(uneseniSatiUcenja)
        Console.WriteLine()
        Console.WriteLine("Razlika")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Call IspisiNiz(razlikaSati)
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad4Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesemo niz od 7 članova te provjeravamo koliko se puta pojavio prvi član.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim niz(6) As Integer
        Console.WriteLine()
        For i = 0 To niz.GetUpperBound(0) Step 1
            Console.Write("{0} element: ", i + 1)
            niz(i) = Console.ReadLine
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Prvi unešeni broj {0}, ponovio se {1} puta.", niz(0), KolikoPutaJeBioPrviElement(niz))
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Function KolikoPutaJeBioPrviElement(ByVal niz() As Integer) As Integer
        Dim brojac As Integer
        For Each broj As Integer In niz
            If broj = niz(0) Then brojac += 1

        Next
        Return brojac
    End Function
    Friend Sub Zad5Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesemo vrijednosti 10 bacanja kockice te odredimo kada je prvi i.")
        Console.WriteLine("zadnji put bila šestica.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unos bacanja kockice:")
        Console.WriteLine()
        Dim bacanjeKockice(9) As Integer
        For i = 0 To bacanjeKockice.GetUpperBound(0) Step 1
            Console.Write("{0} bacanje: ", i + 1)
            bacanjeKockice(i) = Console.ReadLine()
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Dobilo smo: ")
        Call IspisiNiz(bacanjeKockice)
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Array.IndexOf(bacanjeKockice, 6)
        Array.LastIndexOf(bacanjeKockice, 6)
        If Array.IndexOf(bacanjeKockice, 6) AndAlso Array.LastIndexOf(bacanjeKockice, 6) > 0 Then
            Console.WriteLine("Prvu šesticu dobili smo u {0}. bacanju, a zadnju u {1}. bacanju.", Array.IndexOf(bacanjeKockice, 6), Array.LastIndexOf(bacanjeKockice, 6))
        Else
            Console.WriteLine("Nije bilo niti jedne šestice. :(")

        End If
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub
End Module
