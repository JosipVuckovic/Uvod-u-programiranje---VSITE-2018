Friend Module Zad4
    Friend Sub zad4sub()
        Dim jedanCijeliBroj As Integer
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine(" Ovaj program učitava jedan cijeli  broj, te na osnovu unesene vrijednosti radi sljedeće stvari:")
        Console.WriteLine("-Ako je broj jednak nuli ispisat će se poruka ''ništa ne računam'' ")
        Console.WriteLine("-Ako je broj negativan računa se i ispisuje apsolutna vrijednost broja")
        Console.WriteLine("-Ako je broj veći od 0 a manji ili jednak 20 računa se i ispisuje 2**broj")
        Console.WriteLine("-Ako je broj veći od 20 računa se i ispisuje drugi korjen broja")
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("")
        Console.Write("Unesite broj: ")
        jedanCijeliBroj = Console.ReadLine()
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        If jedanCijeliBroj > 0 AndAlso jedanCijeliBroj <= 20 Then
            Console.WriteLine("2 na {0} potenciju je {1}! ", jedanCijeliBroj, 2 ^ jedanCijeliBroj)
        ElseIf jedanCijeliBroj = 0 Then
            Console.WriteLine("Ništa ne računam")
        ElseIf jedanCijeliBroj < 0 Then
            Console.WriteLine("Apsolutna vrijednost broja {0} je {1}", jedanCijeliBroj, Math.Abs(jedanCijeliBroj))
        ElseIf jedanCijeliBroj > 20 Then
            Console.WriteLine("Drugi korijen broja {0} je {1}", jedanCijeliBroj, Math.Sqrt(jedanCijeliBroj))
        End If
        Console.ReadLine()
    End Sub
End Module
