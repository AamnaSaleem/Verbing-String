Module Module1

    Sub Main()

        Dim Str1, Str2 As String

        Console.Write("Enter sting to be processed: ")
        Str1 = Console.ReadLine

        If Len(Str1) < 3 Then
            Console.WriteLine(Str1)
            Console.ReadKey()
            End
        End If

        If Right(Str1, 3) = "ing" Then
            Str2 = Str1 & "ly"
        Else
            Str2 = Str1 & "ing"
        End If

        Console.WriteLine("Processed string is: " & Str2)
        Console.ReadKey()

    End Sub

End Module
