Module glavniIzbornik
    Public Sub glavniIzborniksub()
        Dim izbor As short
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("*    1 - Zadatak 1 - Logički operateri And i OR                      *")
        Console.WriteLine("*    2 - Zadatak 2 - If... Then... Else... grananje                  *")
        Console.WriteLine("*    3 - Zadatak 3 - Select Case                                     *")
        Console.WriteLine("*    4 - Zadatak 4 - Select Case                                     *")
        Console.WriteLine("*    5 - Zadatak 5 - Zamjena vrijednosti                             *")
        Console.WriteLine("*    6 - Izlaz                                                       *")
        Console.WriteLine("**********************************************************************")
        Console.Write("         Vaš izbor: ")
        izbor = Console.ReadLine
        Select Case izbor
            Case 1
                Call Zad1sub()
                Exit Select
            Case 2
                Call Zad2sub()
                Exit Select
            Case 3
                Call Zad3sub()
                Exit Select
            Case 4
                Call zad4sub()
                Exit Select
            Case 5
                Call Zad5sub()
                Exit Select
            Case 6
                Console.WriteLine("Hvala na korištenju")
                'Console.ReadKey()
                Exit Select
            Case 7
                Call Module1sub()
            Case Else
                Console.WriteLine("Nepoznat odabir, molim Vas ponovite unos")
                Call glavniIzborniksub()
                Exit Select
        End Select
    End Sub
End Module
