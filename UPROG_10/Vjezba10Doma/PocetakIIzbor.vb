﻿Module PocetakIIzbor

    Sub Main()
        Console.WriteLine("******************************************************************")
        Console.WriteLine("*    UPROG VJEZBA 10                            Josip Vučković   *")
        Console.WriteLine("*    Ovaj program može pokretati sve zadatke iz vježbe te Vas    *")
        Console.WriteLine("*    molim da napravite izbor koji zadatak Vas zanima.           *")
        Console.WriteLine("******************************************************************")
        Call GlavniIzborniksub()
        Console.ReadKey()
    End Sub
    Public Sub GlavniIzborniksub()
        Dim izbor As Object
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("*    1 - Zadatak 1 - Nizova varijabla i niz kao parametar procedure  *")
        Console.WriteLine("*    2 - Zadatak 2 - Klasa Array i njezine metode                    *")
        Console.WriteLine("*    3 - Zadatak 3 - jednostavno računanje s arrayevima              *")
        Console.WriteLine("*    4 - Zadatak 4 - Koliko puta se pojavljuje prvi element niza     *")
        Console.WriteLine("*    5 - Zadatak 5 - Traženje određenog elementa u nizu, index of    *")
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
