Friend Module Zad2
    Friend Sub Zad2sub()
        Dim izborSpoja As Integer
        Dim r1 As Integer
        Dim r2 As Integer
        Console.WriteLine("Ovaj program računa ukupni otpor dvaju otpornika ovisno o njihovom spoju.")
        Console.WriteLine(" ")
        Console.WriteLine("Unesite iznose otpora")
        Console.Write("R1: ")
        r1 = Console.ReadLine()
        Console.Write("R2: ")
        r2 = Console.ReadLine()
        Console.WriteLine("---------------------")
        Console.WriteLine("1 - serijski spoj")
        Console.WriteLine("2 - paralelni spoj")
        Console.Write("Izaberite spoj:")
        izborSpoja = Console.ReadLine()
        If izborSpoja = 1 Then
            Console.WriteLine("Izabran je serijski spoj otpornika")
            Console.WriteLine("Ukupan serijski otpor je: {0} oma", r1 + r2)
        Else
            Console.WriteLine("Izabran je paralelni spoj otpornika")
            Console.WriteLine("Ukupan paralelni otpor je: {0} oma", ((r1 * r2) / (r1 + r2)))
        End If
        Console.ReadLine()


    End Sub
End Module
