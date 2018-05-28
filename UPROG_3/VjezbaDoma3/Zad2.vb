Module Zad2
    Friend Sub Zad2sub()
        Dim a, b, c, diskriminanta, x1, x2 As Double
        Console.WriteLine("--------------------------------------------------")
        Console.WriteLine("Kvadratna jednadžba te računanje realnog riješenja")
        Console.WriteLine("--------------------------------------------------")
        Console.WriteLine(" Molim Vas unesite koeficijente:")
        Console.Write("a:")
        a = Console.ReadLine()
        Console.Write("b:")
        b = Console.ReadLine()
        Console.Write("c:")
        c = Console.ReadLine()
        If a = 0 Then
            Console.WriteLine("----------------------------------------------")
            Console.WriteLine("Ovo nije kvadratna jednadžba!")
            Console.WriteLine("----------------------------------------------")

        ElseIf a <> 0 Then
            diskriminanta = b ^ 2 - (4 * a * c)
            If diskriminanta > 0 Then
                x1 = ((-b) + Math.Sqrt(diskriminanta)) / 2 * a
                x2 = ((-b) - Math.Sqrt(diskriminanta)) / 2 * a
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("Riješenja su:")
                Console.WriteLine("x1={0},x2={1}", x1, x2)
                Console.WriteLine("----------------------------------------------")
            ElseIf diskriminanta = 0 Then
                x1 = (-b) / (2 * a)
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("Singularno riješenje je x={0}", x1)
                Console.WriteLine("----------------------------------------------")
            ElseIf diskriminanta < 0 Then
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("Nema realnih riješenja!")
                Console.WriteLine("----------------------------------------------")
            End If
        End If
        Call daliZelitejossub()


    End Sub
End Module
