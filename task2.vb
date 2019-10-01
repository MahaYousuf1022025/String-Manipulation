Module Module1

    Sub Main()
        Dim Str1, NextChar As String
        Dim counter, Alphabets, NonAlphabets As Integer

        Str1 = ""
        Alphabets = 0
        NonAlphabets = 0
        NextChar = ""

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine


        For counter = 1 To Len(Str1)
            NextChar = Mid(Str1, counter, 1)
            If LCase(NextChar) >= "a" And LCase(NextChar) <= "z" Then
                Alphabets = Alphabets + 1
            Else
                NonAlphabets = NonAlphabets + 1

            End If

        Next

        Console.WriteLine("Alphabets= " & Alphabets)
        Console.WriteLine("NonAlphabets= " & NonAlphabets)
        Console.ReadKey()









    End Sub

End Module
