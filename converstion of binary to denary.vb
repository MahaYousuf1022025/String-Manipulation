Module Module1


    Sub Main()
        Dim BinaryString As String
        Dim ValidBinaryString As Boolean
        Dim Nextchar As String
        Dim binarychar As Integer
        Dim multiplication, total As Integer
        Dim denary As Integer


        Console.WriteLine(" Please enter your binary")
        BinaryString = Console.ReadLine
        ValidBinaryString = True
        denary=(1,2,4,16,24,48,64,128)


        If Len(BinaryString) > 8 And Len(BinaryString) < 1 Then
            ValidBinaryString = False
        End If

        For counter = 1 To Len(BinaryString)
            Nextchar = Mid(BinaryString, counter, 1)
            If Nextchar = 1 Or Nextchar = 0 Then
                ValidBinaryString = True
            Else
                ValidBinaryString = False

            End If
        Next


        If ValidBinaryString = False Then
            Console.WriteLine("Not a valid binary number")

        End If

        If ValidBinaryString = True Then
            For counter = Len(BinaryString) To 1 Step -1
                binarychar = Mid(BinaryString, counter, 1)
                multiplication = binarychar * denary
                total = total + multiplication




            Next


        End If
        Console.WriteLine(total)
        Console.ReadKey()






    End Sub

End Module
