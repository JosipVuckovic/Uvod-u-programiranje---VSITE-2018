Module Zadaci
    Structure Ljubimci
        Dim Vrsta As String
        Dim GodinaUdomljavanja As Short
        Dim Cipiranje As Boolean
        Sub IspisLjubimaca()
            Console.WriteLine("Ispis podataka:")
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Ljubimac:")
            Console.WriteLine("Vrsta: {0}  Godina udomljavanja: {1}  Čipiran: {2}", Vrsta, GodinaUdomljavanja, Cipiranje)
            Console.WriteLine("----------------------------------------------------------------------")

        End Sub
    End Structure
    Friend Sub Zad1Sub()
        Dim ljubimac(99) As Ljubimci
        Console.Clear()
        'Dim i As Integer
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo podatke za ljubimce te ih ispisujemo, unos se omogucava dok .")
        Console.WriteLine("ne unesemo nulu (0) u polje vrsta.")
        Console.WriteLine("----------------------------------------------------------------------")

        For i = 0 To ljubimac.GetUpperBound(0) Step 1
            Console.WriteLine("Unesite podatke za ljubimca: ")
            Console.Write("Vrsta: ")
            ljubimac(i).Vrsta = Console.ReadLine()
            If ljubimac(i).Vrsta = "0" Then
                ReDim Preserve ljubimac(i - 1)
                Exit For
            End If
            Console.Write("Godina udomljavanja: ")
            ljubimac(i).GodinaUdomljavanja = Console.ReadLine()
            Console.Write("Cipiran True/False: ")
            ljubimac(i).Cipiranje = Console.ReadLine()

        Next

        'Console.WriteLine(ljubimac(0).Vrsta)
        'Console.WriteLine(ljubimac(0).GodinaUdomljavanja)
        'Console.WriteLine(ljubimac(0).Cipiranje)
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Ispis unešenih podataka: ")
        Console.WriteLine("----------------------------------------------------------------------")
        For i = 0 To ljubimac.GetUpperBound(0) Step 1
            Console.WriteLine("{0}. ljubimac: ", i + 1)
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Vrsta: ")
            Console.WriteLine(ljubimac(i).Vrsta)
            Console.Write("Godina udomljavanja: ")
            Console.WriteLine(ljubimac(i).GodinaUdomljavanja)
            Console.Write("Cipiran: ")
            Console.WriteLine(ljubimac(i).Cipiranje)
            Console.WriteLine("----------------------------------------------------------------------")
        Next

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Structure OsobaIzZadatkaDva
        Dim Ime, Prezime As String
        Dim GodinaRođenja As Integer
        Function RacunanjeGodina()

            Return Year(Now) - GodinaRođenja
        End Function
    End Structure
    Friend Sub Zad2Sub()
        Console.Clear()
        Dim osoba1 As OsobaIzZadatkaDva
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo ime, prezime i godinu rođenja te kazemo koliko je osoba stara.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Ime osobe: ")
        osoba1.Ime = Console.ReadLine()
        Console.Write("Prezime osobe: ")
        osoba1.Prezime = Console.ReadLine()
        Console.Write("Godina rođenja: ")
        osoba1.GodinaRođenja = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("{0} {1} ima {2} godina.", osoba1.Ime, osoba1.Prezime, osoba1.RacunanjeGodina)

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Structure IzracunVolumena
        Dim duljina, širina, visina As Single
        Function Volumen() As Double
            Return duljina * širina * visina
        End Function
    End Structure
    Friend Sub Zad3Sub()
        Dim dimenzije As IzracunVolumena
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo duljinu, širinu i visinu, te izračunamo volumen.")
        Console.WriteLine("Koristimo podatkovne članove strukture i funkcionalni član strukture.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite duljinu: ")
        dimenzije.duljina = Console.ReadLine()
        Console.Write("Unesite širinu: ")
        dimenzije.širina = Console.ReadLine()
        Console.Write("Unesite visinu: ")
        dimenzije.visina = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Volumen tijela je: {0}", dimenzije.Volumen)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Structure KoordinateTocaka
        Dim x, y As Single
        Function UdaljenostOdIshodista() As Double
            Return Math.Sqrt(x ^ 2 + y ^ 2)
        End Function
    End Structure
    Friend Sub Zad4Sub()
        Dim tocke As KoordinateTocaka
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo dvije dimenzije točke te izračunavamo udaljenost od ishodišta.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite x: ")
        tocke.x = Console.ReadLine()
        Console.Write("Unesite y: ")
        tocke.y = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Udaljenost od ishodišta {0}. ", tocke.UdaljenostOdIshodista)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Structure KompleksniBroj
        Dim realni, imaginarni As Double
    End Structure
    Friend Sub Zad5Sub()
        Dim i As Integer
        Dim broj1(99) As KompleksniBroj
        Dim broj2(99) As KompleksniBroj
        Dim izbor As String
        Do

            Console.WriteLine("Unesite {0} par brojeva: ", i + 1)
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Realni dio broja: ")
            broj1(i).realni = Console.ReadLine()
            Console.Write("Imaginarni dio broja: ")
            broj1(i).imaginarni = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Realni dio broja: ")
            broj2(i).realni = Console.ReadLine()
            Console.Write("Imaginarni dio broja: ")
            broj2(i).imaginarni = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Ukoliko zelite još brojeva stisnite enter, unesite ne za prekid unosa ")
            izbor = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------------------")
            If izbor = "ne" Then
                ReDim Preserve broj1(i)
                ReDim Preserve broj2(i)
                Exit Do
            End If
            i += 1
        Loop


        For i = 0 To broj1.GetUpperBound(0) Step 1
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Zbroj {0}. para kompleksnih brojeva:", i + 1)
            Console.WriteLine("({0} + {1}i ) + ({2} + {3}i) = {4} + {5}i", broj1(i).realni, broj1(i).imaginarni, broj2(i).realni, broj2(i).imaginarni, ZbrajanjeKompleksnih(broj1(i), broj2(i)).realni, ZbrajanjeKompleksnih(broj1(i), broj2(i)).imaginarni)
            Console.WriteLine("Umnozak {0}. para kompleksnih brojeva:", i + 1)
            Console.WriteLine("({0} + {1}i ) * ({2} + {3}i) = {4} + {5}i", broj1(i).realni, broj1(i).imaginarni, broj2(i).realni, broj2(i).imaginarni, MnozenjeKompleksnih(broj1(i), broj2(i)).realni, MnozenjeKompleksnih(broj1(i), broj2(i)).imaginarni)

        Next

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Function ZbrajanjeKompleksnih(ByVal broj1 As KompleksniBroj, ByVal broj2 As KompleksniBroj) As KompleksniBroj
        Dim r As Double = broj1.realni + broj2.realni
        Dim i As Double = broj1.imaginarni + broj2.imaginarni
        Dim medurezultat As KompleksniBroj
        medurezultat.realni = r
        medurezultat.imaginarni = i
        Return medurezultat

    End Function
    Friend Function MnozenjeKompleksnih(ByVal broj1 As KompleksniBroj, ByVal broj2 As KompleksniBroj) As KompleksniBroj
        Dim r As Double = broj1.realni * broj2.realni
        Dim i As Double = broj1.imaginarni * broj2.imaginarni
        Dim medurezultat As KompleksniBroj
        medurezultat.realni = r
        medurezultat.imaginarni = i
        Return medurezultat
    End Function

End Module
