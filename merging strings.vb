Module Module1

    Sub Main()
        Dim S1, S2, FirstWord, SecWord As String
        Dim SP As String

        S1 = " "
        S2 = " "
        FirstWord = " "
        SecWord = " "
        SP = 0

        Console.WriteLine(" Enter first string: ")
        S1 = Console.ReadLine
        Console.WriteLine(" Enter Second string: ")
        S2 = Console.ReadLine

        SP = InStr(S1, " ")
        FirstWord = Left(S1, SP - 1)

        SP = InStr(S2, " ")
        SecWord = Right(S2, Len(S2) - SP)

        Console.WriteLine("Final String= " & FirstWord & " " & SecWord)
        Console.ReadKey()












    End Sub

End Module
