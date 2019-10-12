Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim counter, total, total2 As Integer
        Dim nextchar1, nextchar2 As Integer

        Console.WriteLine(" enter your first string: ")
        str1 = Console.ReadLine
        Console.WriteLine("enter your second string: ")
        str2 = Console.ReadLine

        For counter = 1 To Len(str1)
            nextchar1 = Asc(Mid(str1, counter, 1))
            total = total + nextchar1

        Next
        For counter = 1 To Len(str2)
            nextchar2 = Asc(Mid(str2, counter, 1))
            total2 = total2 + nextchar2

        Next
        If total = total2 Then
            Console.WriteLine("your strings are anagram")
        Else
            Console.WriteLine("your string is not anagram")



        End If

        Console.ReadKey()



    End Sub

End Module
