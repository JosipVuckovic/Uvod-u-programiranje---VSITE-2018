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
            Return proizvodjac & "," & model & "," & verzija & "," & snagaKW & "," & SnagaUKS() & ";"
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
        Dim path As String = My.Application.Info.DirectoryPath
        Dim fajl1 = path & "\Auti.txt"
        If System.IO.File.Exists(fajl1) Then
        Else
            System.IO.File.Create(path & "\Auti.txt").Close()

        End If
        Dim upisUFajl As New System.IO.StreamWriter(fajl1, True)
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
        upisUFajl.WriteLine(brmbrm1.PripremaZaEksport())
        upisUFajl.WriteLine(brmbrm2.PripremaZaEksport())
        upisUFajl.Close()

        Call DaliZeliteJossub()


    End Sub
    Friend Class Grad
        Friend Naziv As String
        Friend BrojStanovnika As Integer
        Friend Površina As Integer
        Private Shared Država As String = "Republika Hrvatska"
        Friend Sub IspisPodataka()
            Console.Write("Naziv: ")
            Console.WriteLine(Naziv)
            Console.Write("Broj stanovnika: ")
            Console.WriteLine(BrojStanovnika)
            Console.Write("Površina: ")
            Console.WriteLine(Površina)
            Console.Write("Država:")
            Console.WriteLine(Država)
        End Sub
        Friend Function PripremaZaEksport() As String
            Return Naziv & "," & BrojStanovnika & "," & Površina & "," & Država & ";"
        End Function
    End Class
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Napravimo klasu Grad, te polja kao u uputi zadatka, unesemo tražena ")
        Console.WriteLine("polja te se svakom objektu pridruži ime države.")
        Console.WriteLine("Unosimo sve dok ne unesmo kraj, bez obzira na veličinu slova, enter")
        Console.WriteLine("za nastavak unosa.")
        Console.WriteLine("Uneseni gradovi se ne ispisuje već se spremaju u txt fajl, po csv ")
        Console.WriteLine("standardu, fajl se nalazi u direktriju programa.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim unesenGrad As Grad = New Grad()

        Dim izbor As String = "možda"
        Dim uneseniGradovi As List(Of Grad) = New List(Of Grad)
        Dim path As String = My.Application.Info.DirectoryPath
        Dim fajl2 = path & "\Gradovi.txt"
        If System.IO.File.Exists(fajl2) Then
        Else
            System.IO.File.Create(path & "\Gradovi.txt").Close()

        End If
        Dim upisUFajl As New System.IO.StreamWriter(fajl2, True)

        Do
            Console.Write("Unesite ime grada: ")
            unesenGrad.Naziv = Console.ReadLine()
            Console.Write("Unesite broj stanovnika: ")
            unesenGrad.BrojStanovnika = Console.ReadLine()
            Console.Write("Unesite površinu: ")
            unesenGrad.Površina = Console.ReadLine()
            Console.WriteLine()
            uneseniGradovi.Add(New Grad() With {
             .Naziv = unesenGrad.Naziv,
             .BrojStanovnika = unesenGrad.BrojStanovnika,
             .Površina = unesenGrad.Površina})
            Console.Write("Za nastavak unosa pritisnite Enter, za kraj upišite Kraj: ")
            izbor = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("----------------------------------------------------------------------")




        Loop Until izbor.ToLower = "kraj"
        Console.WriteLine("----------------------------------------------------------------------")


        For Each unos In uneseniGradovi
            upisUFajl.Write(unos.PripremaZaEksport())
        Next
        'For Each unos In uneseniGradovi
        '    Console.WriteLine(unos.PripremaZaEksport())
        'Next
        upisUFajl.Close()
        DaliZeliteJossub()
    End Sub
    Friend Class Pravokutnik
        Dim stranicaA, stranicaB As Double
        Private Function IzracunPovršine()
            Return stranicaA * stranicaB
        End Function
        Private Function IzracunDijagonale() As Double
            Return Math.Sqrt(stranicaA ^ 2 + stranicaB ^ 2)
        End Function
        Public Sub New()
            Me.stranicaA = 10
            Me.stranicaB = 10
        End Sub
        Public Sub New(stranicaA As Double, stranicaB As Double)
            Me.stranicaA = stranicaA
            Me.stranicaB = stranicaB
        End Sub
        Public Sub Ispis()
            Console.Write("Stranica a: ")
            Console.WriteLine(stranicaA)
            Console.Write("Stranica b: ")
            Console.WriteLine(stranicaB)
            Console.Write("Površina: ")
            Console.WriteLine(Math.Round(IzracunPovršine(), 2))
            Console.Write("Dijagonala:")
            Console.WriteLine(Math.Round(IzracunDijagonale(), 2))
        End Sub
    End Class
    Friend Sub Zad4Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Stvaramo objekt pravokutnik i u njemu inicializiramo stranice, napišemo")
        Console.WriteLine("metode za izračun površine i dijagonale istog. Drugi objekt radimo preko ")
        Console.WriteLine("parametarskog konstruktora. Oba pravokutnika su inicijalizirana bez unosa")
        Console.WriteLine("korisnika, početna vrijednost stranica je 10, dok je drugi pravokutnik")
        Console.WriteLine("inicializiran sa 20 ")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim pravokutnik1 As Pravokutnik = New Pravokutnik()
        Dim pravokutnik2 As Pravokutnik = New Pravokutnik(20, 20)
        Console.WriteLine("Prvi pravokutnik: ")
        pravokutnik1.Ispis()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Drugi pravokutnik: ")
        pravokutnik2.Ispis()
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Class Mobitel
        Private brojMobitela As String
        Friend Sub Ispis()
            Console.Write("Broj mobitela: ")
            Console.WriteLine(brojMobitela)
        End Sub
        Public Property UpisBrojaMobitela() As String
            Get
                Return brojMobitela
            End Get
            Set(ByVal broj As String)
                Select Case broj.Length()
                    Case > 0
                        Select Case broj.Substring(0, 3)
                            Case "098", "099", "091", "095"
                                brojMobitela = broj

                            Case Else
                                Exit Property
                                Exit Select

                        End Select
                        Exit Select
                    Case Else
                        Exit Property
                End Select


            End Set
        End Property

    End Class
    Friend Sub Zad5Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Napravimo klasu Mobite sa svojstvom broj mobitela, ukoliko broj ima")
        Console.WriteLine("prefiks 098,099,091 ili 095 broj se upisuje, inace ne.")
        Console.WriteLine("Zapravo, učitamo brojeve iz txt fajla svibrojevi.txt koji se nalazi")
        Console.WriteLine("u istom direktoriju kao i exe datoteka, te pregeldamo koji zadovoljavau")
        Console.WriteLine("gore navedene uvijete i zapišemo ih u drugi fajl, BrojeviMobitelaHR.txt")
        Console.WriteLine("koji se nalazi u istoj datoteci.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim path As String = My.Application.Info.DirectoryPath
        Dim fajl3 = path & "\svibrojevi.txt"
        Dim fajl4 = path & "\BrojeviMobitelaHR.txt"
        If System.IO.File.Exists(fajl4) Then
        Else
            System.IO.File.Create(path & "\BrojeviMobitelaHR.txt").Close()
        End If
        Dim upisUFajl As New System.IO.StreamWriter(fajl4, True)
        Dim citanjeFajla As String
        citanjeFajla = My.Computer.FileSystem.ReadAllText(fajl3)
        Dim mob As Mobitel = New Mobitel()
        Dim svibrojevi As List(Of String) = citanjeFajla.Split(",").ToList()
        For Each brojmobitela As String In svibrojevi
            mob.UpisBrojaMobitela = brojmobitela
            If mob.UpisBrojaMobitela = brojmobitela = True Then
                upisUFajl.Write(mob.UpisBrojaMobitela & ",")
            End If
        Next
        upisUFajl.Close()
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub


End Module
