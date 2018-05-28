Module Zad3
    Sub Main()
        Dim pocetakFilmaSati As Byte
        Dim pocetakFilmaMinute As Byte
        Dim krajFilmaSati As Byte
        Dim krajFilmaMinute As Byte
        Console.WriteLine("Unesite vrijeme početka filma u satima i minutama (format 24h):")
        Console.Write("Sat:")
        pocetakFilmaSati = Console.ReadLine()
        Console.Write("Minuta:")
        pocetakFilmaMinute = Console.ReadLine()
        Console.WriteLine("Unesite vrijeme kraja filma u satima i minutama (format 24):")
        Console.Write("Sat:")
        krajFilmaSati = Console.ReadLine()
        Console.Write("Minuta:")
        krajFilmaMinute = Console.ReadLine()
        Dim minutePocetak As Short
        minutePocetak = (pocetakFilmaSati * 60) + pocetakFilmaMinute
        Dim minuteKraj As Short
        minuteKraj = (krajFilmaSati * 60) + krajFilmaMinute
        Dim trajanjeFilma As Short
        trajanjeFilma = minuteKraj - minutePocetak
        Console.WriteLine("Filme je trajao {0} sati i {1} minuta.", trajanjeFilma \ 60, trajanjeFilma Mod 60)
        Console.ReadLine()
    End Sub
End Module
