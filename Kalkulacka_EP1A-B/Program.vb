Imports System

Module Program
    Sub Main(args As String())
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()
        Console.CursorVisible = False

        Dim klavesa As ConsoleKeyInfo

        Do
            Console.Clear()
            Menu()
            klavesa = Console.ReadKey(True)
            If klavesa.KeyChar = "1" Then

            ElseIf klavesa.KeyChar = "2" Then

            ElseIf klavesa.KeyChar = "3" Then

            ElseIf klavesa.KeyChar = "4" Then

            ElseIf klavesa.Key = ConsoleKey.Escape Then
                Exit Do
            End If
        Loop
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
