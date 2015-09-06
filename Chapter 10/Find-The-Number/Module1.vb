Module Module1

    Sub Main()
        'Set app title in Command window and explain the game
        Console.Title = "Find the Hidden Number: A Game of Chance and Skill"
        Console.WriteLine("I'm thinking of a number from 1 through 100.")
        Console.WriteLine("Can you guess what it is?")
        Console.WriteLine()

        Dim generator As New Random 'declare generator as source for random numbers
        'Pick a random number from 1-101 (not including 101) and assign to randNum
        Dim randNum As Integer = generator.Next(1, 101)
        Dim guesses As Integer = 0
        Dim guess As Integer

        Do  'This Do Loop repeats over and over again until user gets the answer
            Console.Write("Guess: ")
            guess = Console.ReadLine 'read in a number and assign to guess variable
            Select Case guess 'Select Case structure evaluates guess variable
                Case randNum  'if correct number found, congratulate user
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    Console.WriteLine("That's Right!")
                    Console.ForegroundColor = ConsoleColor.Gray
                Case Is < randNum 'but if guess is too small, ask for bigger number
                    Console.WriteLine("Try a bigger number")
                Case Is > randNum 'or if guess is too big, ask for smaller number
                    Console.WriteLine("Try a smaller number")
            End Select
            Console.WriteLine()
            guesses = guesses + 1 ' increment guesses, which tracks num of guesses
        Loop Until guess = randNum 'continue looping until user chooses correctly

        'After looping complete, display number of guesses it took user to find num
        Console.Write("You found the hidden number in {0} guesses.", guesses)
        Console.ReadKey() 'pause until user presses a key

    End Sub

End Module
