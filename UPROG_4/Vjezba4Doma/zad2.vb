Module zad2
    Friend Sub Zad2sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Program ispisuje sve brojeve od 0-1000 koji su djeljivi sa brojem 'a'")
        Console.WriteLine("a nisu djeljivi sa brojev 'b'.")
        Console.WriteLine("----------------------------------------------------------------------")
        Console.Write("Unesite broj s kojim brojevi trebaju biti djeljivi:")
        Dim djeljiviS = Console.ReadLine()
        Console.Write("Unesite broj s kojim ne smiju biti djeljivi:")
        Dim nisuDjeljiviS = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Dim brojac As Integer
        For i = 1 To 1000 Step 1
            If i Mod djeljiviS = 0 AndAlso i Mod nisuDjeljiviS <> 0 Then
                Console.Write("{0,5}", i)
                brojac += 1
                If brojac Mod 6 = 0 Then Console.WriteLine()
            End If
        Next
        If brojac Mod 6 <> 0 Then Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Bilo je {0} brojeva koji su zadovoljili uvijete.", brojac)
        Console.WriteLine("----------------------------------------------------------------------")
        Call daliZeliteJossub()

    End Sub

End Module
