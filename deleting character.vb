Module Module1

    Sub Main()
        Dim str1, deletechar, nextchar, newstring As String
        Dim counter As Integer

        str1 = ""
        deletechar = ""
        counter = 0
        newstring = ""

        Console.WriteLine("please enter your string: ")
        str1 = Console.ReadLine
        Console.WriteLine("Enter the character you want to remove")
        deletechar = Console.ReadLine
        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            If nextchar <> deletechar Then
                newstring = newstring & nextchar



            End If

        Next
        Console.WriteLine(newstring)
        Console.ReadKey()





    End Sub

End Module
