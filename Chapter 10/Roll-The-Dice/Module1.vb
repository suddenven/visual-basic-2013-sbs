Module Module1

    Sub Main()
        Console.Title = "Roll the Dice"
        Console.WriteLine("This game determines how many times a lucky dice roll appears.")
        Console.WriteLine("Pick a lucky number for a two dice roll (2-12) & times to throw.")
        Console.WriteLine()

        Dim luckyNumber As Integer ' declare lucky number variable
        Dim rolls As Integer       ' declare variable for number of rolls
        Dim wins As Integer = 0    ' initialize lucky number hits to zero
        Dim counter As Integer     ' declare counter variable for For...Next loop
        Dim die1 As Integer        ' declare variables to store dice rolls
        Dim die2 As Integer
        Dim generator As New Random ' use Random class to create random rolls

        Console.Write("What lucky number are you trying for (2-12): ")
        luckyNumber = Console.ReadLine  ' get lucky number from user
        Console.Write("How many times do you want to roll the dice? ")
        rolls = Console.ReadLine  'get number of dice rolls requested

        For counter = 1 To rolls  ' a loop rolls the dice the requested number of times
            die1 = Int(generator.Next(1, 7))  ' roll first die and save number
            die2 = Int(generator.Next(1, 7))  ' roll second die and save number
            If die1 + die2 = luckyNumber Then wins = wins + 1 ' add rolls / check for win
        Next counter

        Console.WriteLine()  ' display number of rolls, lucky number, and wins
        Console.Write("Out of {0} rolls, the number {1} came up {2} times.",
                      rolls, luckyNumber, wins)
        Console.WriteLine()
        Console.Write("That's a win rate of {0}%", ((wins / rolls) * 100))
        Console.ReadKey()    ' pause until user presses a key

    End Sub

End Module
