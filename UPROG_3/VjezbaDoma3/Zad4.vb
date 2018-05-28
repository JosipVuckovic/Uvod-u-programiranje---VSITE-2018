Module Zad4
    Friend Sub zad4sub()
        Dim uneseniBroj As Integer
        Console.WriteLine("------------------------------------------------------------------------")
        Console.WriteLine("Program unešeni broj dijeli sa 7 i na temelju ostatka bira dan u tjednu.")
        Console.WriteLine("------------------------------------------------------------------------")
        Console.Write("Unesi broj:")
        uneseniBroj = Console.ReadLine()
        Select Case uneseniBroj < 0
            Case True
                Console.WriteLine("Broj nije cijeli broj")
        End Select
        Select Case uneseniBroj Mod 7
                    Case 0
                        Console.WriteLine("Ponedjeljak")
                    Case 1
                        Console.WriteLine("Utorak")
                    Case 2
                        Console.WriteLine("Srijeda")
                    Case 3
                        Console.WriteLine("Četvrtak")
                    Case 4
                        Console.WriteLine("Petak")
                    Case 5
                        Console.WriteLine("Subota")
                    Case 6
                        Console.WriteLine("Nedjelja")
                End Select


        Call daliZelitejossub()
    End Sub
End Module
