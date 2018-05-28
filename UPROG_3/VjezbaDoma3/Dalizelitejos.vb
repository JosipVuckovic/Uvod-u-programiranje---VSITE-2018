Module Dalizelitejos
    Public Sub daliZelitejossub()
        Dim odabir As Char
        Console.WriteLine("***********************************")
        Console.WriteLine("* Želite li drugi zadatak?  y/n   *")
        Console.WriteLine("***********************************")
        odabir = Console.ReadLine
        If odabir = "y" Then
            Call Sub() glavniIzborniksub()
        ElseIf odabir = "n" Then

        Else
            Console.WriteLine("Nepoznat odabir, molim Vas ponovite unos")
            Console.Write("Vaš odabir: ")
            odabir = Console.ReadLine()
        End If
    End Sub

End Module
