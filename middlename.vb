Module Module1

    Sub Main()
        Dim s1 As String
        Dim firstword As String
        Dim SP As Integer
        Dim Middleword As String
        Dim SP2 As Integer



        SP = 0
        s1 = Console.ReadLine

        SP = InStr(s1, " ")
        firstword = Right(s1, Len(s1) - SP)

        SP2 = InStr(firstword, " ")
        Middleword = Left(firstword, SP2 - 1)


        

        Console.WriteLine(Middleword)
        Console.ReadKey()
    End Sub

End Module
