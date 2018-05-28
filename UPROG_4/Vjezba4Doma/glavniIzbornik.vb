Module glavniIzbornik
    Public Sub GlavniIzborniksub()
        Dim izbor As Object
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("*    1 - Zadatak 1 - For... Next... Brojevi od 1-30 razne igre       *")
        Console.WriteLine("*    2 - Zadatak 2 - For... Next... Modifikacija ispisa              *")
        Console.WriteLine("*    3 - Zadatak 3 - For... Next... Niz prirodnih brojeva            *")
        Console.WriteLine("*    4 - Zadatak 4 - For... Next... If then Ocjena studenta          *")
        Console.WriteLine("*    5 - Zadatak 5 - For... Next... Umnošci od 1 do unosa            *")
        Console.WriteLine("*    6 - Izlaz                                                       *")
        Console.WriteLine("**********************************************************************")
        Console.Write("         Vaš izbor: ")
        izbor = Console.ReadLine
        Select Case izbor
            Case "1"
                Call Zad1sub()
                Exit Select
            Case "2"
                Call Zad2sub()
                Exit Select
            Case "3"
                Call Zad3sub()
                Exit Select
            Case "4"
                Call Zad4sub()
                Exit Select
            Case "5"
                Call Zad5sub()
                Exit Select
            Case "6"
                Console.WriteLine("Hvala na korištenju")
                Exit Select
            Case Else
                Console.WriteLine("Nepoznat odabir, molim Vas ponovite unos")
                Call GlavniIzborniksub()
                Exit Select
        End Select
    End Sub


End Module
