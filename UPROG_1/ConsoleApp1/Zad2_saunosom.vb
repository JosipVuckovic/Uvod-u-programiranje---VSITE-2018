Module Zad2_saunosom
    Public Sub Main()
        Dim prviBroj As Short
        Dim drugiBroj As Short
        Console.WriteLine("Osnovne aritmetičke operacije")
        Console.WriteLine("-----------------------------")
        Console.WriteLine("Unesite prvi cijeli broj:")
        prviBroj = Console.ReadLine()
        Console.WriteLine("Unesite drugi cijeli broj:")
        drugiBroj = Console.ReadLine()
        Console.WriteLine("-----------------------------")
        Console.WriteLine("{0}+{1}={2}", prviBroj, drugiBroj, prviBroj + drugiBroj)
        Console.WriteLine("{0}-{1}={2}", prviBroj, drugiBroj, prviBroj - drugiBroj)
        Console.WriteLine("{0}*{1}={2}", prviBroj, drugiBroj, prviBroj * drugiBroj)
        Console.WriteLine("{0}/{1}={2}", prviBroj, drugiBroj, prviBroj / drugiBroj)
        Console.ReadLine()
    End Sub
End Module
