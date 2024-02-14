Imports System

Module Program
    Sub Main(args As String())
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()
        Console.CursorVisible = False

        Menu()
        Console.ReadKey()
    End Sub

    Sub Menu()
        'Console.SetCursorPosition(10, 8)
        Console.WriteLine("╔══════════════════╗")
        Console.WriteLine("║    KALKULAČKA    ║")
        Console.WriteLine("╠══════════════════╣")
        Console.WriteLine("║ 1 - SOUČET       ║")
        Console.WriteLine("║ 2 - ROZDÍL       ║")
        Console.WriteLine("║ 3 - SOUČIN       ║")
        Console.WriteLine("║ 4 - PODÍL        ║")
        Console.WriteLine("╠══════════════════╣")
        Console.WriteLine("║ Esc - KONEC      ║")
        Console.WriteLine("╚══════════════════╝")
    End Sub
End Module
