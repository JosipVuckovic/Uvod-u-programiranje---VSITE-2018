Module Zadaci
    Friend Sub Zad1Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesemo neki string, te brojimo koliko se puta ponavlja neki znak.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesite neki string: ")
        Dim nekistring As String = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesite znak koji brojimo u tom nizu: ")
        Dim nekiznak As Char = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("U unešenom stringu bilo je {0} znakova {1}.", HajmoBrojati(nekistring, nekiznak), nekiznak)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Function HajmoBrojati(ByVal nekistring As String, ByVal nekiznak As Char) As Integer
        Dim brojac As Integer
        For Each znak As Char In nekistring
            If znak = nekiznak Then brojac += 1
        Next
        Return brojac
    End Function
    Friend Sub Zad2Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesemo rečenicu, te dva prirodan broja p i k. Oba moraju biti manja od.")
        Console.WriteLine("duljine rečenice. Ukoliko nisu, unos se ponavlja, zatim se ispisuje prvih")
        Console.WriteLine("p i zadnjih k znakova. Unos se ponavlja sve dok rečenica ima više od 5 znakova.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim recenica As String
        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Unesite rečenicu: ")
            recenica = Console.ReadLine()
            If recenica.Length <= 5 Then Exit Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Unesite prvu granicu, p: ")
            Dim p As Integer = Console.ReadLine()
            If p > recenica.Length Then
                Console.WriteLine("Prva granica mora biti manja od dužine rečenice!")
                Console.WriteLine("Ponovite unos, p: ")
                p = Console.ReadLine()
            End If
            Console.WriteLine("Unesite drugu granicu, k: ")
            Dim k As Integer = Console.ReadLine()
            If k > recenica.Length Then
                Console.WriteLine("Prva granica mora biti manja od dužine rečenice!")
                Console.WriteLine("Ponovite unos, p: ")
                p = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------------------")
            End If
            Console.WriteLine(recenica.Substring(0, p))
            Console.WriteLine(recenica.Substring(recenica.Length - k))

        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad3Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Pridružuje se varijabli vrijednost ---2-3=-1-- , koristeci jednom trim a")
        Console.WriteLine("drugi put substring, treba dobiti 2-3-=-1 te tu varijablu ispisati.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Odabir metode:")
        Console.WriteLine(" 1 - Trim")
        Console.WriteLine(" 2 - Substring")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Vaš odabir: ")
        Dim odabir As Object
        odabir = Console.ReadLine()

        Dim pocetna As String = "---2-3=-1--"
        Dim ispisna As String
        Select Case odabir
            Case "1"
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("Trim metoda")
                Console.WriteLine("----------------------------------------------------------------------")
                ispisna = pocetna.TrimStart("-")
                ispisna = ispisna.TrimEnd("-")
                Dim mjesto As Integer = ispisna.IndexOf("=")
                ispisna = ispisna.Insert(mjesto, "-")
                Console.WriteLine(ispisna)

                Exit Select
            Case "2"
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("Substring metoda")
                Console.WriteLine("----------------------------------------------------------------------")
                ispisna = pocetna.Substring(pocetna.IndexOf("2") - 1, pocetna.IndexOf("1") - 1)
                Dim mjesto As Integer = ispisna.IndexOf("=")
                ispisna = ispisna.Insert(mjesto, "-")
                Console.WriteLine(ispisna)
                Exit Select
            Case Else
                Console.WriteLine("Nepoznat odabir!")
                Console.ReadLine()
                Call Zad3Sub()
        End Select

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad4Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo riječi ili rečenice i gledamo dali je unešen palindrom,")
        Console.WriteLine("Unosimo sve do ne unesemo prazan string.")
        Console.WriteLine("Ne koristimo reverse niti coppy to char array")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim uneseniString, obrnutiString As String


        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Unesite riječ ili rečenicu:")
            uneseniString = Console.ReadLine()
            If uneseniString = "" Then Exit Do
            uneseniString = uneseniString.ToLower()
            uneseniString = uneseniString.Trim(" ", ".", ",", "!", "?")
            uneseniString = uneseniString.Replace(" ", "")

            obrnutiString = ObrniZnakove(uneseniString)
            obrnutiString = obrnutiString.TrimStart(" ", "")
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("obrnuti znakvoi su: ")
            Console.WriteLine(obrnutiString)
            Console.WriteLine("")
            If uneseniString = obrnutiString Then
                Console.WriteLine("Unesena riječ/rečenica je palindrom!")
            Else
                Console.WriteLine("Unesena riječ/rečenica nije palindrom.")
            End If

            'NAPOMENA neka slova, tipa LJ i NJ doživljava kao 2 slova, pitati zašto


        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Function ObrniZnakove(ByVal unesenistring As String) As String
        Dim znak As Char
        Dim obrnutiznakovi As String
        For i = unesenistring.Length() To 0 Step -1
            znak = unesenistring.Substring(i)
            obrnutiznakovi = obrnutiznakovi & znak
        Next
        Return obrnutiznakovi
    End Function
    Friend Sub Zad5Sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unosimo rečenicu, gledamo kojim znakom završava i prema tome određujemo")
        Console.WriteLine("vrstu rečenice. Brojimo riječi u rečenici, samoglasnike i suglasnike. ")
        Console.WriteLine("Koristimo proceduru za brojanje i ispis traženih podataka. Unos prestaje")
        Console.WriteLine("kada unesemo riječ ili rečenicu bez interpunkcijskog znaka.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim unesenaRecenica As String
        Do
            Console.WriteLine("Unesite rečenicu: ")
            unesenaRecenica = Console.ReadLine()



            If unesenaRecenica.IndexOf("!") > -1 Then

                Console.WriteLine()
                Console.WriteLine("Unesena je usklična rečenica.")

            ElseIf unesenaRecenica.IndexOf("?") > -1 Then

                Console.WriteLine()
                Console.WriteLine("Unešena je upitna rečenica")

            ElseIf unesenaRecenica.IndexOf(".") > -1 Then

                Console.WriteLine()
                Console.WriteLine("Unešena je izjavna rečenica.")

            Else
                Console.WriteLine("----------------------------------------------------------------------")
                Console.WriteLine("Nema interpunkcijskog znaka. Izlazim")
                Exit Do

            End If
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine()
            Call Brojanje(unesenaRecenica)




        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub
    Private Sub Brojanje(ByVal unesenaRecenica As String)
        Dim predanarecenica As String
        Dim brSamoglasnika, brSuglasnika, brRijeci As Integer
        predanarecenica = unesenaRecenica.TrimStart(" ")
        predanarecenica = predanarecenica.TrimEnd(" ")
        predanarecenica = predanarecenica.ToLower()
        'predanarecenica = predanarecenica.Trim("!", ".", "?")

        For Each znak As Char In predanarecenica
            Select Case znak
                Case "a", "e", "i", "o", "u"
                    brSamoglasnika += 1
                    Exit Select
                Case " ", ".", "!", "?"
                    brRijeci += 1
                    Exit Select

                Case Else
                    brSuglasnika += 1
            End Select
        Next
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("U unesenoj rečenici, bilo je {0} riječi, {1} samoglasnika i {2} suglasnika.", brRijeci, brSamoglasnika, brSuglasnika)
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine()
    End Sub
End Module
