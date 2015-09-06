Imports System.IO

Public Class Form1

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim allText As String = ""
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            Try 'open file and trap any errors using handler
                allText = My.Computer.FileSystem.ReadallText(OpenFileDialog1.FileName)
                NoteLabel.Text = OpenFileDialog1.FileName 'update label
                NoteTextBox.Text = allText 'display file
                NoteTextBox.Enabled = True 'allow text cursor
                CloseToolStripMenuItem.Enabled = True  'enable Close command
                OpenToolStripMenuItem.Enabled = False  'disable Open command
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        NoteTextBox.Text = ""             'clear text box
        NoteLabel.Text = "Load a text file with the Open command."
        CloseToolStripMenuItem.Enabled = False  'disable Close command
        OpenToolStripMenuItem.Enabled = True    'enable Open command
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            'copy text to disk
            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, NoteTextBox.Text, False)
        End If
    End Sub

    Private Sub InsertDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertDateToolStripMenuItem.Click
        NoteTextBox.Text = My.Computer.Clock.LocalTime & vbCrLf & NoteTextBox.Text
        NoteTextBox.Select(0, 0)  'remove selection
    End Sub

    Private Sub SortTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortTextToolStripMenuItem.Click
        Dim sortArray() As String
        Dim textString As String
        Dim counter As Integer

        textString = NoteTextBox.Text
        'replace different new line characters with one version
        textString = textString.Replace(vbCrLf, vbCr)
        textString = textString.Replace(vbLf, vbCr)
        'remove last carriage return if it exists
        If textString.EndsWith(vbCr) Then
            textString = textString.Substring(0, textString.Length - 1)
        End If

        'split each line into an array
        sortArray = textString.Split(vbCr)

        'sort array
        ShellSort(sortArray, sortArray.Length)

        'then display sorted array in text box
        textString = ""
        For counter = 0 To sortArray.Length - 1
            textString = textString & sortArray(counter) & vbCrLf
        Next counter
        NoteTextBox.Text = textString
        NoteTextBox.Select(0, 0)   'remove text selection
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
