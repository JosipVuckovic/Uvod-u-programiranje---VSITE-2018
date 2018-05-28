Module zad1
    Friend Sub Zad1sub()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------")
        Console.WriteLine("Ovaj program ispisuje brojeve od 1-30 u sljedećim oblicima")
        Console.WriteLine(" - Sve brojeve u rastućem poretku ")
        Console.WriteLine(" - Sve brojeve u opadajućem poretku  ")
        Console.WriteLine(" - Sve brojeve u rastućem poretku ")
        Console.WriteLine(" - Sve parne brojeve u rastućem poretku ")
        Console.WriteLine(" - Sve neparne brojeve u  opadajućem poretku")
        Console.WriteLine("----------------------------------------------------------")
        For i = 1 To 30 Step 1
            Console.Write("{0} ", i)
        Next
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------")
        For i = 30 To 1 Step -1
            Console.Write("{0} ", i)
        Next
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------")
        For i = 2 To 30 Step 2
            Console.Write("{0} ", i)
        Next
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------")
        For i = 29 To 1 Step -2
            Console.Write("{0} ", i)
        Next
        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------")
        Call daliZeliteJossub()






    End Sub

End Module
