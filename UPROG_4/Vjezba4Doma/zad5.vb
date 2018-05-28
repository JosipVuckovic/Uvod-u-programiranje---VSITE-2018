Module zad5
    Friend Sub Zad5sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Zadatak množi sve brojeve od 1 do zadanog broja te ispisuje umnoške.")
        Console.WriteLine("----------------------------------------------------------------------")
        Dim faktorijel = 1, doBroja, brojac As Integer
        Console.WriteLine("Do kojeg broja želite množiti?")
        Console.Write("Do broja:")
        doBroja = Console.ReadLine()
        Console.WriteLine("----------------------------------------------------------------------")
        Console.WriteLine("Umnošci brojeva od 1 do {0}:", doBroja)
        Console.WriteLine("----------------------------------------------------------------------")
        If doBroja <= 12 Then
            For i = 1 To doBroja Step 1
                faktorijel *= i
                brojac += 1
                Console.Write("{0,10}", faktorijel)
                If brojac Mod 6 = 0 Then Console.WriteLine()
            Next
            If brojac Mod 6 <> 0 Then Console.WriteLine()
            Console.WriteLine("----------------------------------------------------------------------")
            Call DaliZeliteJossub()
        ElseIf doBroja > 12 AndAlso doBroja < 28 Then
            Dim faktorijeliznad12 As Decimal
            faktorijeliznad12 = 1
            For i = 1 To doBroja Step 1
                faktorijeliznad12 *= i
                brojac += 1
                Console.WriteLine("{0}", faktorijeliznad12)

            Next
            If brojac Mod 6 <> 0 Then Console.WriteLine()
            Console.WriteLine("----------------------------------------------------------------------")
            Call DaliZeliteJossub()
        Else
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Žao mi je, daje prevelik broj koji bi srušio program, nemogu izvesti!")
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Pritisnite bilo koju tipku za ponovni unos.")
            Console.ReadLine()
            Call Zad5sub()
        End If

    End Sub
End Module
