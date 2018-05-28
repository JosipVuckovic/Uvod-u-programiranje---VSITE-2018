Module Zadaci
    Friend Const _BrojStudenata = 15

    Friend Sub Zad1Sub()
        Dim uneseniBroj As Integer
        Dim prethodnoUneseniBroj As Integer
        Dim hex As String
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program pretvara dekadske brojeveu u njihove heksa brojeve te radi ")
        Console.WriteLine("taj zadatak dok se ne upišu dva ista broja za redom")
        Console.WriteLine("----------------------------------------------------------------------")
        prethodnoUneseniBroj = -985648
        Do
            Console.Write("Unesite broj dekadski broj: ")
            uneseniBroj = Console.ReadLine()
            If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            'Select Case uneseniBroj
            '    Case "0"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 0")

            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "1"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 1")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "2"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 2")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "3"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 3")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "4"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 4")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "5"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 5")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "6"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 6")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "7"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 7")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "8"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 8")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "9"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: 9")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "10"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: A")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "11"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: B")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "12"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: C")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "13"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: D")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "14"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: E")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case "15"
            '        If prethodnoUneseniBroj = uneseniBroj Then Exit Do
            '        Console.WriteLine("HEX: F")
            '        prethodnoUneseniBroj = uneseniBroj
            '    Case Else
            ''        Console.WriteLine("Krivi unos, ponovite:")

            'End Select
            hex = Convert.ToString(uneseniBroj, toBase:=16)
            Console.WriteLine("HEX: {0}", hex)
            prethodnoUneseniBroj = uneseniBroj

        Loop
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub
    Friend Sub Zad2Sub()
        Console.Clear()
        Dim uneseniBrojStudenata As Integer
        Dim brojGrupa As Integer
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos broja studenata te prikazuje koliko treba grupa ")
        Console.WriteLine("za studente s obzirom na broj studenata definiran konstantom")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Unesite broj upisanih studenata: ")
        uneseniBrojStudenata = Console.ReadLine()
        brojGrupa = uneseniBrojStudenata \ _BrojStudenata
        If uneseniBrojStudenata Mod _BrojStudenata <> 0 Then brojGrupa += 1
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Za {0} studenata, broj grupa je: {1}.", uneseniBrojStudenata, brojGrupa)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad3Sub()
        Console.Clear()
        Dim uneseniBroj, broj, brojac As Integer

        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos prirodno/cijelog broja te ga prikazuje kao zbroj ")
        Console.WriteLine("potencija broja 10")
        Console.WriteLine("----------------------------------------------------------------------")

        Do
            Console.WriteLine("----------------------------------------------------------------------")
            Console.Write("Unesite prirodni broj: ")

            uneseniBroj = Console.ReadLine()
            If uneseniBroj <= 0 Then Exit Do
            Console.Write("{0}= ", uneseniBroj)
            broj = uneseniBroj

            Do Until broj = 0

                Console.Write("{0}*10^{1}", broj Mod 10, brojac)
                Console.Write("+")
                brojac += 1
                broj = broj \ 10
            Loop
            Console.WriteLine()
        Loop Until unesenibroj = 0
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub
    Friend Sub Zad5Sub()
        Console.Clear()
        Dim umnozak, brojac As Integer
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program ispisuje tablicu mnozenja od 0 do 5 uzlazno i silazno ")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Tablica mnozenja od 0 do 5")
        Console.WriteLine("----------------------------------------------------------------------")
        For mnozenik As Integer = 0 To 5
            For mnozitelj As Integer = 0 To 5
                umnozak = mnozenik * mnozitelj
                Console.Write("{0}*{1}={2}  ", mnozenik, mnozitelj, umnozak)
                brojac += 1
                If brojac Mod 6 = 0 Then Console.WriteLine()
            Next
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Tablica mnozenja od 5 do 0")
        Console.WriteLine("----------------------------------------------------------------------")
        For mnozenik As Integer = 5 To 0 Step -1
            For mnozitelj As Integer = 5 To 0 Step -1
                umnozak = mnozenik * mnozitelj
                Console.Write("{0}*{1}={2}  ", mnozenik, mnozitelj, umnozak)
                brojac += 1
                If brojac Mod 6 = 0 Then Console.WriteLine()
            Next
        Next
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()
    End Sub
    Friend Sub Zad4Sub()
        Console.Clear()
        Dim unesenibroj, znamenka, najVecaZnamenka, broj As Integer
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program trazi najvecu znamenku broja")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite Broj: ")
        unesenibroj = Console.ReadLine()
        broj = unesenibroj
        Do
            znamenka = broj Mod 10
            broj = broj \ 10
            If najVecaZnamenka < znamenka Then najVecaZnamenka = znamenka

        Loop While broj > 0 AndAlso najVecaZnamenka < 9
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Najveca znamenka broja {0} je {1}", unesenibroj, najVecaZnamenka)
        Console.WriteLine("----------------------------------------------------------------------")
        Call DaliZeliteJossub()

    End Sub

End Module
