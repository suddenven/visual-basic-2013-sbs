' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub XmlTestButton_Click(sender As Object, e As RoutedEventArgs) Handles XmlTestButton.Click
        'SAMPLE 1: Opening an XML document in a text box.
        '  This code loads an XML document into the Students object and displays it
        '  in a text box, complete with tags.

        OutputTextBox.Text = "All content in the XML file including tags:" & vbCrLf & vbCrLf
        Dim Students As XDocument = XDocument.Load("Assets/Students.xml")
        OutputTextBox.Text &= Students.ToString

        'SAMPLE 2: Display a selection of records from an XML document using LINQ.
        '  In the following LINQ query, all of the tagged items that match LASTNAME
        '  are displayed in a text box. Note the exact capitalization of LASTNAME!

        'OutputTextBox.Text = "Last Names of all Students in program" & vbCrLf & vbCrLf
        'Dim Students As XDocument = XDocument.Load("Assets/Students.xml")
        'Dim query = From person In Students.Descendants("LASTNAME")
        '            Select person.Value

        'For Each item In query
        '    'OutputTextBox.Text &= item & vbCrLf
        'Next

        'SAMPLE 3: Display XML elements nested in a more complex XML hierarchy.
        '  This example displays an instructor scheduled to work in Winter 2015 in Students.xml.

        'OutputTextBox.Text = "Instructors scheduled to work in Winter 2015" & vbCrLf & vbCrLf
        'Dim Students As XDocument = XDocument.Load("Assets/Students.xml")
        'OutputTextBox.Text = OutputTextBox.Text & _
        'Students.Element("STUDENTS").Element("WINTER2015").Element("INSTRUCTOR").Value

        'SAMPLE 4: Use LINQ to search creatively in an XML document.
        '  This query searches the SkiTeam2014.xml file for female skiers 
        '  between 16 and 17 (inclusive) that are in the XML document.

        'OutputTextBox.Text = "Female ski school students between 16 and 17" & vbCrLf & vbCrLf
        'Dim xdoc As XDocument = XDocument.Load("Assets/SkiTeam2014.xml")
        'Dim query = From skier In xdoc.Descendants("Skier")
        'Where (skier.Attribute("Gender").Value = "F") _
        'And (skier.Attribute("Age").Value >= 16) And (skier.Attribute("Age").Value <= 17)
        'Select FName = skier.Attribute("FirstName").Value,
        'LName = skier.Attribute("LastName").Value

        'For Each skier In query
        '    OutputTextBox.Text &= skier.FName & " " & skier.LName & vbCrLf
        'Next

        'SAMPLE 5: Modify an element in the in-memory copy of an XML Document.
        '  This code shows how to change the LASTNAME field in the first record in the XML file
        '  from Smith to George. The final line displays the name so that you can verify the change.

        'Dim xdoc As XDocument = XDocument.Load("Assets/Students.xml")
        'xdoc.Element("STUDENTS").Element("WINTER2014").Element("LASTNAME").SetValue("George")
        'OutputTextBox.Text = xdoc.Element("STUDENTS").Element("WINTER2014").Element("LASTNAME").Value

        'SAMPLE 6: Add to an XML Document by creating a new node.
        '  To create a new XML "node" and add it to the end of the LASTNAME section, do this:
        '  Load XML document into Students variable. Create a new XElement object to hold
        '  the new node, and assign the LASTNAME value "Lyon" to the node.
        '  Use Add method to add the new node to the end of the LASTNAME section.
        '  Display modified XML document in the text box (with tags) to verify change.

        'Dim Students As XDocument = XDocument.Load("Assets/Students.xml")
        'Dim xe As XElement = New XElement("LASTNAME", "Lyon")
        'Students.Element("STUDENTS").Element("WINTER2014").Add(xe)
        'OutputTextBox.Text = Students.ToString
    End Sub
End Class
