Module Module1

    Sub Main()
        Dim s1 As String
        Dim Reverse As String
        Dim counter As Integer
        Dim nextchar As String

        s1 = ""
        Reverse = ""
        counter = 0

        Console.Write(" Enter your word: ")
        s1 = Console.ReadLine

        For counter = Len(s1) To 1 Step -1
            nextchar = Mid(s1, counter, 1)
            Reverse = Reverse & nextchar

        Next





        Console.WriteLine(Reverse)
        Console.ReadKey()



    End Sub

End Module
