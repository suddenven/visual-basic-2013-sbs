Module Module1

    Sub ShellSort(ByVal sort() As String, ByVal numOfElements As Integer)
        Dim temp As String
        Dim i, j, span As Integer
        'The ShellSort procedure sorts the elements of sort()
        'array in descending order and returns it to the calling
        'procedure. 

        span = numOfElements \ 2
        Do While span > 0
            For i = span To numOfElements - 1
                For j = (i - span) To 0 Step -span
                    If sort(j) <= sort(j + span) Then Exit For
                    'swap array elements that are out of order
                    temp = sort(j)
                    sort(j) = sort(j + span)
                    sort(j + span) = temp
                Next j
            Next i
            span = span \ 2
        Loop
    End Sub

End Module
