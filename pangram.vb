Module Module1

    Sub Main()
       
        Dim str1, Alphabets, nextchar As String
        Dim pangram As Boolean
        Dim counter As Integer

        Console.WriteLine("Input your string: ")
        str1 = Console.ReadLine
        Alphabets = ("abcdefghijklmnopqrstuvwxyz")
        str1 = LCase(str1)
        pangram = True

        For counter = 1 To Len(Alphabets)
            nextchar = Mid(Alphabets, counter, 1)
            If InStr(str1, nextchar) = 0 Then
                pangram = False
            End If
            

        Next
        If pangram = False Then
            Console.WriteLine("Your string in not pangram")
        Else
            Console.WriteLine("your string is panagram")
        End If
        Console.ReadKey()





















    End Sub

End Module
