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
End Module
