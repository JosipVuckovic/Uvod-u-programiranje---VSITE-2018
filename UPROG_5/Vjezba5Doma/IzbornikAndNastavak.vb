Module IzbornikAndNastavak
    Public Sub GlavniIzborniksub()
        Dim izbor As Object
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("*    1 - Zadatak 1 - Do...Loop... Dekadski u Hexa                    *")
        Console.WriteLine("*    2 - Zadatak 2 - Simbolicka konstanta na razini modula           *")
        Console.WriteLine("*    3 - Zadatak 3 - Do...Loop... Prikaz prirodnog broja kao zbroja  *")
        Console.WriteLine("*    4 - Zadatak 4 - Do...Loop... Najveca znamenka broja             *")
        Console.WriteLine("*    5 - Zadatak 5 - For...Next Tablica mnozenja od 0 do 5           *")
        Console.WriteLine("*    6 - Izlaz                                                       *")
        Console.WriteLine("**********************************************************************")
        Console.Write("         Vaš izbor: ")
        izbor = Console.ReadLine
        Select Case izbor
            Case "1"
                Call Zad1Sub()
                Exit Select
            Case "2"
                Call Zad2Sub()
                Exit Select
            Case "3"
                Call Zad3Sub()
                Exit Select
            Case "4"
                Call Zad4Sub()
                Exit Select
            Case "5"
                Call Zad5Sub()
                Exit Select
            Case "6"
                Console.WriteLine("Hvala na korištenju")
                Console.WriteLine("pritisnite bilo koju tipku za izlaz")
                Exit Select
            Case Else
                Console.WriteLine("Nepoznat odabir, molim Vas ponovite unos")
                Call GlavniIzborniksub()
                Exit Select
        End Select
    End Sub
    Public Sub DaliZeliteJossub()
        Dim odabir As Object
        Console.WriteLine("****************************")
        Console.WriteLine("* Želite li drugi zadatak? *")
        Console.WriteLine("****************************")
        Console.Write("y/n:")
        odabir = Console.ReadLine()
        Select Case odabir
            Case "y"
                Console.Clear()
                Call Sub() GlavniIzborniksub()
                Exit Select
            Case "n"
                Console.WriteLine("Hvala na korištenju")
                Console.WriteLine("pritisnite bilo koju tipku za izlaz")
                Exit Select
            Case Else
                Console.WriteLine("Nepoznat unos!")
                Call DaliZeliteJossub()
        End Select

    End Sub
End Module
