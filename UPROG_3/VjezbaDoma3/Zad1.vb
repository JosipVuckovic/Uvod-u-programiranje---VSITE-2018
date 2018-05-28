Module Zad1
    Friend Sub Zad1sub()
        Dim cijenaKosulje As Double
        Dim velicinaKosulje As Integer
        Dim bojaKosulje As String
        Dim odabir As Char
        Console.WriteLine("----------------------------------")
        Console.Write("Unesite cijenu kosulje u kunama: ")
        cijenaKosulje = Console.ReadLine()
        Console.Write("Unesite veličinu košulje: ")
        velicinaKosulje = Console.ReadLine()
        Console.Write("Unesite boju košulje (malim početnim): ")
        bojaKosulje = Console.ReadLine()
        Console.WriteLine("-----------------------------------")

        If cijenaKosulje < 100 And velicinaKosulje = 42 And (bojaKosulje = "zelena" Or bojaKosulje = "bijela") Then
            Console.WriteLine("Kupujem")
        Else
            Console.WriteLine("Ne kupujem.")
        End If
        Call daliZelitejossub()



    End Sub
End Module
