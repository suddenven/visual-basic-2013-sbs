Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FacultyDataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.FacultyDataSet.Faculty)

    End Sub

    
    Private Sub SortLastNamesToolStripButton_Click(sender As Object, e As EventArgs) Handles SortLastNamesToolStripButton.Click
        Try
            Me.FacultyTableAdapter.SortLastNames(Me.FacultyDataSet.Faculty)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
