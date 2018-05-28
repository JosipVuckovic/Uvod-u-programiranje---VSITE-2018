Module Zad5
    Sub Main()
        Console.Write("Unesite dvoznamenkasti prirodni broj:")
        Dim dvoznamenkastiPriridniBroj As Byte
        dvoznamenkastiPriridniBroj = Console.ReadLine()
        If dvoznamenkastiPriridniBroj > 99 Then
            Console.Write("Unjeli ste krivi broj, molim ponovite unos:")
            dvoznamenkastiPriridniBroj = Console.ReadLine()
        End If
        Console.WriteLine("Prva znamenka je {0} a druga znamenka je {1}", dvoznamenkastiPriridniBroj \ 10, dvoznamenkastiPriridniBroj Mod 10)
        Console.WriteLine("Zbroj znamenki broja {0} je {1}", dvoznamenkastiPriridniBroj, ((dvoznamenkastiPriridniBroj \ 10) + (dvoznamenkastiPriridniBroj Mod 10)))
        Console.ReadLine()
    End Sub
End Module