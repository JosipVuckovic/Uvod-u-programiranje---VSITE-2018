Module daliZeliteJos
    Public Sub DaliZeliteJossub()
        Dim odabir As Object
        Console.WriteLine("****************************")
        Console.WriteLine("* Želite li drugi zadatak? *")
        Console.WriteLine("****************************")
        Console.Write("y/n:")
        odabir = Console.ReadLine()
        Select Case odabir
            Case "y"
                Console.Clear()
                Call Sub() GlavniIzborniksub()
                Exit Select
            Case "n"
                Exit Select
            Case Else
                Console.WriteLine("Nepoznat unos!")
                Call DaliZeliteJossub()
        End Select

    End Sub

End Module
