' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ' Declare a constant for 8.5% base discount for ski school
    Public Const webRateDiscount As Double = 0.085
    ' Declare a constant for 14% returning student discount
    Public Const returnStudentDiscount As Double = 0.14

    Public Class BaseDiscount
        'Declare new BaseDiscount class that contains FindDiscount method.
        'Using Overridable keyword during method declaration allows for method overriding
        Overridable Function FindDiscount(ByVal CashValue As Double) As Double
            Return CashValue * webRateDiscount 'determine basic discount for student
        End Function
    End Class

    Public Class DeepDiscount
        ' Declare new DeepDiscount class which modifies a method in the BaseDiscount class
        Inherits BaseDiscount  'Inherits keyword must be first statement in class
        Private initialDiscount As Double  'declare local variable to hold calculation

        'This modified FindDiscount method will override the same method in the base class
        'when the Overrides keyword is used
        Overrides Function FindDiscount(ByVal CashValue As Double) As Double
            'Use of the MyBase keyword here refers to the base class of current instance.
            'That calculation is the first, but then second discount is added to it
            initialDiscount = MyBase.FindDiscount(CashValue)
            'Goal is to return the total "deep discount" (or multiple discount value)
            Return (returnStudentDiscount * CashValue) + initialDiscount
        End Function
    End Class

    'The ViewSavings procedure calculates the amount of money saved on ski school
    'tuition and displays the value in the Output text box on the page.
    'The procedure takes two arguments, an object of the BaseDiscount type and
    'a tuition value that should be discounted.

    Sub ViewSavings(ByVal Item As BaseDiscount, ByVal SaleAmount As Double)
        'Note the polymorphism support: Although the first argument calls for an object
        'of type BaseDiscount, an object of type DeepDiscount also works.
        Dim taxAmount As Double
        taxAmount = Item.FindDiscount(SaleAmount)
        Output.Text = Output.Text & "On " & SaleAmount.ToString("C") & _
            " tuition, the amount saved was " & taxAmount.ToString("C") & vbCrLf
    End Sub

    Private Sub TestButton_Click(sender As Object, e As RoutedEventArgs) Handles TestButton.Click
        'Declare objects related to new classes
        Dim WebDeal2014 As New BaseDiscount
        Dim ReturnStdBargain2014 As New DeepDiscount

        'Call ViewSavings procedure to determine discount on $150 ski school tuition.
        'The first call uses the regular Web registration discount rate
        ViewSavings(WebDeal2014, 150)
        'The second call adds the web discount to the returning student discount
        ViewSavings(ReturnStdBargain2014, 150)
    End Sub
End Class
