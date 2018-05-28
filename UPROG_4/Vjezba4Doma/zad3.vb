Module zad3
    Friend Sub Zad3sub()
        Dim pocetakNiza, krajNiza, korak, brojac As Integer
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program ispisuje niz prirodnih brojeva od zadanog početka do kraja")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Početak niza:")
        pocetakNiza = Console.ReadLine()
        If pocetakNiza < 0 Then
            Console.WriteLine("Ne spada u skup PRIRODNIH brojeva, ponovite unos!")
            Console.Write("Početak niza:")
            pocetakNiza = Console.ReadLine()
        End If
        Console.Write("Kraj niza:")
        krajNiza = Console.ReadLine()
        If krajNiza < 0 Then
            Console.WriteLine("Ne spada u skup PRIRODNIH brojeva, ponovite unos!")
            Console.Write("Početak niza:")
            pocetakNiza = Console.ReadLine()
        End If
        Console.WriteLine("----------------------------------------------------------------------")
        If krajNiza < pocetakNiza Then
            korak = -1
        Else
            korak = 1
        End If
        For i = pocetakNiza To krajNiza Step korak
            Console.Write("{0,5}", i)
            brojac += 1
            If brojac Mod 6 = 0 Then Console.WriteLine()

        Next
        If brojac Mod 6 <> 0 Then Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Call daliZeliteJossub()
    End Sub
End Module
