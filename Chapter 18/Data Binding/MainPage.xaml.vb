' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Sample 1: Bind a TextBox control to the Student class to display
        ' one student record.
        ' Sets DataContext property of text box to new student record with name,
        ' course, start date, and instructor fields.
        OutputTextBox.DataContext = New Student("Kim Akers", "Intermediate Skiing",
           New DateTime(2015, 2, 5), "Hamlin")

        ' Sample 2: Bind a ListBox control to a collection of student records.
        ' To run this sample, uncomment the following code, which adds 4 student
        ' records to the collection in the format required by Students class.
        'AllStudents.Add(New Student("Walter Harp", "Beginning Snowboarding",
        '  New DateTime(2014, 1, 15), "Khan"))
        'AllStudents.Add(New Student("Toni Poe", "Advanced Ski Racing",
        '   New DateTime(2014, 1, 8), "Hanson"))
        'AllStudents.Add(New Student("Paul Cannon", "Beginning Nordic",
        '   New DateTime(2015, 1, 13), "Khan"))
        'AllStudents.Add(New Student("Sunil Uppal", "Beginning Nordic",
        '   New DateTime(2015, 1, 13), "Khan"))
        'OutputList.DataContext = AllStudents   'this line assigns collection to list box

    End Sub
    'A public generic collection used for Sample 2 to store student data.
    Public AllStudents As New ObservableCollection(Of Student)()

    'A public class that provides a data source (with 4 properties) for bound controls.
    Public Class Student
        Public Sub New()
        End Sub

        Public Sub New(ByVal studentName As String, ByVal classTitle As String, _
            ByVal sessionDate As DateTime, ByVal teacher As String)
            Student = studentName
            ClassName = classTitle
            StartDate = sessionDate
            Instructor = teacher
        End Sub

        'These properties contain student name, course, start date, & instructor.
        Public Property Student As String
        Public Property ClassName As String
        Public Property StartDate As DateTime
        Public Property Instructor As String
        ' The following statement overrides the ToString method.
        Public Overloads Overrides Function ToString() As String
            Return Student + " enrolled in " + ClassName + "; Begins: " _
                + StartDate.ToString("d") + "; Instructor: " + Instructor
        End Function
    End Class

End Class
