Module Zadaci
    Friend Sub Zad2Sub()
        Dim rijec As String
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Zadatak trazi unos rijeci sve dok se ne unese . te spaja unesene rijeci")
        Console.WriteLine("u recenicu.")
        Console.WriteLine("----------------------------------------------------------------------")
        Do
            Console.Write("Unesite rijec:")
            rijec = Console.ReadLine()
            Console.WriteLine()
            Call Recenica(rijec)
            Console.WriteLine()

        Loop While rijec <> "."

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Recenica(ByVal rijec As String)
        Static recenica As String
        If rijec = "." Or rijec = "," Or rijec = "!" Then
            recenica = recenica & rijec
        Else
            recenica = recenica & " " & rijec
        End If

        Console.WriteLine(recenica)
    End Sub
    Friend Sub Zad3Sub()
        Dim ime, odabir As String
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos imena, te nakon toga dozvoljava promjenu istoga,")
        Console.WriteLine("ukoliko ne prmomjenite ime, program zavrsava.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite svoje ime: ")
        ime = Console.ReadLine()
        Console.WriteLine()
        Console.Write("Ukoliko zelite promjeniti ime, unesite ""da"":")
        odabir = Console.ReadLine()
        If odabir = "da" Then
            Call PromjenaImenaSub(ime)
            Console.WriteLine()
            Console.WriteLine("Sada se zovete: {0}", ime)

        End If

        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub PromjenaImenaSub(ByRef ime As String)
        Console.WriteLine()
        Console.Write("Unesite novo ime: ")
        ime = Console.ReadLine()
        Return

    End Sub
    Friend Sub Zad4Sub()
        Dim uneseniBinarniBroj As String
        Dim pretvoreniDekadsi As String
        Dim provjeraBinarni As Boolean
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos binarnog broja, te vrši provjeru nad njime te ")
        Console.WriteLine("ispisuje njegovu dekadsku vrijednost. Unos se zaustavlja s 0")
        Console.WriteLine("----------------------------------------------------------------------")
        Do
            Console.Write("Unesite broj u binarnom zapisu: ")
            uneseniBinarniBroj = Console.ReadLine()
            provjeraBinarni = ProvjerdaDaliJeBinarni(uneseniBinarniBroj)
            If provjeraBinarni = True Then
                pretvoreniDekadsi = Pretvori10(uneseniBinarniBroj)
                Console.WriteLine("{0}(2) ----> {1}(10)", uneseniBinarniBroj, pretvoreniDekadsi)
            Else
                Console.WriteLine("Nije BINARNI broj! Ponovite unos!")
            End If
        Loop Until uneseniBinarniBroj = 0
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Function ProvjerdaDaliJeBinarni(ByVal uneseniBinarniBroj As String) As Boolean
        Dim znamenka As Decimal
        znamenka = uneseniBinarniBroj
        Do
            znamenka = uneseniBinarniBroj Mod 10
            If znamenka > 1 Then Return False
            uneseniBinarniBroj = uneseniBinarniBroj \ 10
        Loop Until uneseniBinarniBroj = 0
        Return True
    End Function
    Friend Function Pretvori10(ByVal uneseniBinarniBroj As String) As String
        Dim preracun As Integer
        Dim znamenka As Integer = uneseniBinarniBroj
        Dim potencija As Integer
        Do
            znamenka = uneseniBinarniBroj Mod 10
            uneseniBinarniBroj = uneseniBinarniBroj \ 10
            preracun = preracun + (znamenka * 2 ^ potencija)
            potencija += 1

        Loop Until uneseniBinarniBroj = 0
        Return preracun
        'Return Convert.ToString(Int64.Parse(uneseniBinarniBroj), 10)
    End Function

End Module
