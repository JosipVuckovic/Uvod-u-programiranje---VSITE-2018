Module zad4
    Friend Sub Zad4sub()
        Console.Clear()
        Dim imeStudenta As String
        Dim najManjaOcjena, najVecaOcjena, ocjenaIzPredmeta, srednjaOcjena As Integer
        Console.WriteLine("-----------------------------------------------------------------------")
        Console.WriteLine("Program traži unos imena studenta i ocjena iz 6 predmeta,te na temelju")
        Console.WriteLine("toga daje ispisuje najmanju, najveću i prosječnu ocjenu.")
        Console.WriteLine("-----------------------------------------------------------------------")
        Console.Write("Unesite ime studenta: ")
        imeStudenta = Console.ReadLine
        Console.WriteLine("-----------------------------------------------------------------------")
        najManjaOcjena = 5
        najVecaOcjena = 1
        For i = 1 To 6 Step 1
            Console.Write("Unesite ocijnu iz {0}. predmeta:", i)
            ocjenaIzPredmeta = Console.ReadLine()
            srednjaOcjena += ocjenaIzPredmeta
            If ocjenaIzPredmeta < najManjaOcjena Then najManjaOcjena = ocjenaIzPredmeta
            If ocjenaIzPredmeta > najVecaOcjena Then najVecaOcjena = ocjenaIzPredmeta
        Next
        Console.WriteLine("-----------------------------------------------------------------------")
        Console.WriteLine("Student:{0,5} srednja ocjena:{1}, najmanja ocjena:{2}, najveća ocjena:{3}", imeStudenta, srednjaOcjena / 6, najManjaOcjena, najVecaOcjena)
        Console.WriteLine("-----------------------------------------------------------------------")
        Call daliZeliteJossub()

    End Sub
End Module
