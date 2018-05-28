﻿Module IzbornikAndNastavak
    Public Sub GlavniIzborniksub()
        Dim izbor As Object
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("*    1 - Zadatak 1 - Sub procedura... Izračun povrsine i dijagonale  *")
        Console.WriteLine("*    2 - Zadatak 2 - Funkcije... Izračun povrsine i dijagonale       *")
        Console.WriteLine("*    3 - Zadatak 3 - Funkcije... Potenciranje                        *")
        Console.WriteLine("*    4 - Zadatak 4 - Funkcije... Prosti brojevi                      *")
        Console.WriteLine("*    5 - Zadatak 5 - Funkcije... Ponavljanje određene znamenke       *")
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