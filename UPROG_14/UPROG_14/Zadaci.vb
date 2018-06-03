Module Zadaci
    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Upisujemo 2 stringa, spajamo ih te vršimo provjere s equals i compare.")
        Console.WriteLine("Unosimo parove stringova sve dok se ne unese ""kraj"" ili ""Kraj"".")
        Console.WriteLine("Sigurno je samo jedno izvođenje.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim s1, s2 As String
        Dim izbor As String = "nesto"
        Do
            Console.Write("Unesite prvi string: ")
            s1 = Console.ReadLine()
            Console.WriteLine()
            Console.Write("Unesite drugi string: ")
            s2 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Rezultat metode concat:")
            Console.WriteLine(String.Concat(s1, s2))
            Console.WriteLine()
            Console.WriteLine("Rezultat metode equals: {0}", s1.Equals(s2))
            Console.WriteLine()
            Console.WriteLine("Rezultat metode compare: ")
            Select Case s1.CompareTo(s2)
                Case -1
                    Console.WriteLine("Metoda compare je vratila -1 pa je {0} < {1}", s1, s2)
                    Exit Select
                Case 1
                    Console.WriteLine("Metoda compare je vratila 1 pa je {0} > {1}", s1, s2)
                Case Else
                    Console.WriteLine("Metoda compare je vratila 0 pa je {0} = {1}", s1, s2)
                    Exit Select
            End Select
            Console.WriteLine()
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Unesite kraj za kraj ili enter za nastavak: ")
            izbor = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine()
        Loop Until izbor.ToLower = "kraj"

        Call DaliZeliteJossub()
    End Sub
    Friend Class Automobil
        Friend proizvodjac As String
        Friend model As String
        Friend verzija As String
        Friend snagaKW As Single
        Friend Function SnagaUKS() As Single
            Return 1.36 * snagaKW
        End Function
        Friend Function RazlikaSnageKW(ByVal snagaDrugog As Single) As Single
            Return snagaKW - snagaDrugog
        End Function
        Friend Function RazlikaSnageKS(ByVal snagaDrugog As Single) As Single
            Return SnagaUKS() - snagaDrugog
        End Function
        Friend Sub IspisPodataka()
            Console.Write("Proizvođač: ")
            Console.WriteLine(proizvodjac)
            Console.Write("Model: ")
            Console.WriteLine(model)
            Console.Write("Verzija: ")
            Console.WriteLine(verzija)
            Console.Write("Snaga u KW: ")
            Console.WriteLine(snagaKW)
            Console.Write("Snaga u KS: ")
            Console.WriteLine(SnagaUKS)

        End Sub
        Friend Function PripremaZaEksport() As String
            Return proizvodjac & " " & model & " " & verzija & " " & snagaKW & " " & SnagaUKS() & ";"
        End Function


    End Class
    Friend Sub Zad2Sub()

        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Kreiramo dvije instance objekta klase auto, prema specifikaciji iz ")
        Console.WriteLine("teksta zadatka. Inicijaliziramo vrijednosti u glavnoj proceduri,")
        Console.WriteLine("ispišemo sve podatke, te izračunamo razliku snage između dva auta.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim brmbrm1 As Automobil = New Automobil()
        Dim brmbrm2 As Automobil = New Automobil()
        Dim fajl = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Korisnik\source\GitHub\Uvod-u-programiranje---VSITE-2018\UPROG_14\UPROG_14\IspisAutiju.txt", True)
        brmbrm1.proizvodjac = "Ford"
        brmbrm1.model = "Mondeo"
        brmbrm1.verzija = "Sedan"
        brmbrm1.snagaKW = 75
        brmbrm2.proizvodjac = "Škoda"
        brmbrm2.model = "Octavia"
        brmbrm2.verzija = "Limuzina"
        brmbrm2.snagaKW = 50
        Console.WriteLine()
        Console.WriteLine("Ispis podataka prvog vozila:")
        Console.WriteLine("----------------------------------------------------------------------")
        brmbrm1.IspisPodataka()
        Console.WriteLine()
        Console.WriteLine("Ispis podataka prvog vozila:")
        Console.WriteLine("----------------------------------------------------------------------")
        brmbrm2.IspisPodataka()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Razlika snage prvog i drugog vozila: ")
        Console.WriteLine()
        Console.Write("Razlika snage u KW: ")
        Console.WriteLine(brmbrm1.RazlikaSnageKW(brmbrm2.snagaKW))

        Console.Write("Razlika snage u KS: ")
        Console.WriteLine(brmbrm1.RazlikaSnageKS(brmbrm2.SnagaUKS))
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------------")
        fajl.WriteLine(brmbrm1.PripremaZaEksport())
        fajl.WriteLine(brmbrm2.PripremaZaEksport())
        fajl.Close()

        Call DaliZeliteJossub()


    End Sub



End Module
