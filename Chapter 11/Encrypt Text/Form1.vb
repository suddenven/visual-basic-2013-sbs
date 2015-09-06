Public Class Form1

    Private Sub SaveAsItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsItem.Click
        Dim encrypt As String = ""
        Dim letter As Char
        Dim counter, charsInFile As Short

        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                'save text with encryption scheme (ASCII code + 1)
                charsInFile = NoteTextBox.Text.Length
                For counter = 0 To charsInFile - 1
                    letter = NoteTextBox.Text.Substring(counter, 1)
                    'determine ASCII code and add one to it
                    encrypt = encrypt & Chr(Asc(letter) + 1)
                Next counter
                'write encrypted text to file
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, encrypt, False)
                NoteTextBox.Text = encrypt
                NoteTextBox.Select(0, 0)   'remove text selection
                CloseItem.Enabled = True
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub InsertDateItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertDateItem.Click
        NoteTextBox.Text = DateString & vbCrLf & NoteTextBox.Text
        NoteTextBox.Select(0, 0)  'remove selection
    End Sub

    Private Sub ExitItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitItem.Click
        End
    End Sub

    Private Sub OpenItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenItem.Click
        Dim allText As String
        Dim i, charsInFile As Short
        Dim letter As Char
        Dim decrypt As String = ""

        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
                Try 'open file and trap any errors using handler
                    allText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                    'now, decrypt string by subtracting one from ASCII code
                    charsInFile = allText.Length 'get length of string
                    For i = 0 To charsInFile - 1 'loop once for each char
                        letter = allText.Substring(i, 1) 'get character
                        decrypt = decrypt & Chr(Asc(letter) - 1) 'subtract 1
                    Next i 'and build new string
                    NoteTextBox.Text = decrypt 'then display converted string
                    NoteLabel.Text = OpenFileDialog1.FileName
                    NoteTextBox.Select(0, 0)   'remove text selection
                    NoteTextBox.Enabled = True 'allow text cursor
                    CloseItem.Enabled = True  'enable Close command
                    OpenItem.Enabled = False  'disable Open command
                Catch ex As Exception
                    MsgBox("An error occurred." & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub CloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseItem.Click
        NoteTextBox.Text = ""             'clear text box
        NoteLabel.Text = "Load a text file with the Open command."
        CloseItem.Enabled = False  'disable Close command
        OpenItem.Enabled = True    'enable Open command
    End Sub

End Class
