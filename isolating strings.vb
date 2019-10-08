Module Module1

    Sub Main()
        Dim s1 As String
        Dim last As String
        Dim SP As Integer
        Dim Middleword As String
        Dim SP2 As Integer
        Dim firstwords As String
        Dim lastwords As String



        SP = 0
        s1 = Console.ReadLine

        SP = InStr(s1, " ")
        Firstwords = Left(s1, SP - 1)

        SP = InStr(s1, " ")
        last = Right(s1, Len(s1) - SP)

        SP2 = InStr(last, " ")
        Middleword = Left(last, SP2 - 1)

        SP2 = InStr(last, " ")
        lastwords = Right(last, Len(last) - SP2)



        

        Console.WriteLine(firstwords)
        Console.WriteLine(Middleword)
        Console.WriteLine(lastwords)






        Console.ReadKey()
    End Sub

End Module
