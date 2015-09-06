Imports System.IO

Public Class Form1

    Private Sub SaveAsItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsItem.Click
        Dim letter As Char
        Dim codeString As String
        Dim i, charsInFile, code As Short
        Dim streamToWrite As StreamWriter = Nothing

        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                codeString = InputBox("Enter Encryption Code")
                If codeString = "" Then Exit Sub 'if cancel clicked
                'save text with encryption scheme
                code = CShort(codeString)
                charsInFile = NoteTextBox.Text.Length
                streamToWrite = My.Computer.FileSystem.OpenTextFileWriter( _
                    SaveFileDialog1.FileName, False)
                For i = 0 To charsInFile - 1
                    letter = NoteTextBox.Text.Substring(i, 1)
                    'convert to number w/ Asc, then use Xor to encrypt
                    streamToWrite.Write(Asc(letter) Xor code) 'and save in file
                    'separate numbers with a space
                    streamToWrite.Write(" ")
                Next
                CloseItem.Enabled = True
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            Finally
                If streamToWrite IsNot Nothing Then
                    streamToWrite.Close()
                End If
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
        Dim i As Short
        Dim ch As Char
        Dim codeString As String
        Dim code, number As Short
        Dim numbers() As String
        Dim decrypt As String = ""

        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            Try 'open file and trap any errors using handler
                codeString = InputBox("Enter Encryption Code")
                If codeString = "" Then Exit Sub 'if cancel clicked
                code = CShort(codeString)
                'read encrypted numbers
                allText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                allText = allText.Trim
                'split numbers in to an array based on space
                numbers = allText.Split(" ")
                'loop through array
                For i = 0 To numbers.Length - 1
                    number = CShort(numbers(i)) 'convert string to number
                    ch = Chr(number Xor code) 'convert with Xor
                    decrypt = decrypt & ch 'and build string
                Next
                NoteTextBox.Text = decrypt 'then display converted string
                NoteLabel.Text = OpenFileDialog1.FileName
                NoteTextBox.Select(0, 0)   'remove text selection
                NoteTextBox.Enabled = True 'allow text cursor
                CloseItem.Enabled = True   'enable Close command
                OpenItem.Enabled = False   'disable Open command
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub CloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseItem.Click
        NoteTextBox.Text = ""       'clear text box
        NoteLabel.Text = "Load a text file with the Open command."
        CloseItem.Enabled = False  'disable Close command
        OpenItem.Enabled = True    'enable Open command
    End Sub

End Class
