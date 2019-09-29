Module Module1

    Sub Main()
        Dim InString, NewString As String
        Dim Index As Integer
        Dim AfterSpace As Boolean
        Dim NextChar As Char
        Const Space = " "

        AfterSpace = False
        NewString = " "

        Console.WriteLine(" Enter new string: ")
        InString = Console.ReadLine

        For Index = 1 To Len(InString)
            NextChar = Mid(InString, Index, 1)

            If AfterSpace = True Then
                If NextChar <> Space Then
                    NewString = NewString & NextChar
                    AfterSpace = False


                End If
            Else
                NewString = NewString & NextChar
                If NextChar = Space Then
                    AfterSpace = True
                End If

            End If

        Next
        Console.ReadKey()





    End Sub


End Module
