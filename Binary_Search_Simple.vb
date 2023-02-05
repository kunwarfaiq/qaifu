Module Module1

    Dim alpha() As String = {"a", "b", "c", "d", "e", "f", "g", "h"}

    Sub Main()
        Dim c2s As Char = Console.ReadLine
        Console.WriteLine(c2s & " found at location " & binarys(c2s))
        Console.ReadKey()
    End Sub
    Function binarys(ByVal value As String) As String
        Dim upperb, lowerb, middle As Integer
        Dim isfound As Boolean
        lowerb = 0
        upperb = 8
        isfound = False
        While upperb >= lowerb And isfound = False
            middle = (lowerb + upperb) \ 2
            If alpha(middle) = value Then
                isfound = True
                Return middle
            ElseIf alpha(middle) > value Then
                upperb = middle - 1
            Else
                lowerb = middle + 1
            End If
        End While
        Return "Not Found"
    End Function

End Module
