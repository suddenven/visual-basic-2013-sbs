Module Module1

    Sub Main()
        'Display an informative title in the Command window
        Console.Title = "Fahrenheit to Celsius Conversion"

        'Declare 3 variables for Fahrenheit temp, Celsius temp, and city name
        'The Single data type allows the temps to contain decimal values
        Dim fahrenheitTemp As Single, celsiusTemp As Single
        Dim cityName As String

        'Ask the user for the name of a city that they have weather data for
        Console.Write("Enter the name of a city: ")
        cityName = Console.ReadLine()

        'Ask the user for the temperature in Fahrenheit...
        Console.Write("Enter the temperature in {0} (Fahrenheit): ", cityName)
        fahrenheitTemp = Console.ReadLine

        'Convert Fahrenheit temp to Celsius & round to nearest tenth of a degree
        'The Math.Round method rounds the temp to the nearest 0.1
        celsiusTemp = Math.Round((fahrenheitTemp + 40) * 5 / 9 - 40, 1)

        'Display the city name and temperatures using replaceable parameters
        Console.WriteLine("The temperature in {0} is {1} Fahrenheit and {2} Celsius.",
            cityName, fahrenheitTemp, celsiusTemp)

        'Pause until the user presses a key, which closes the Command window
        Console.ReadKey()

    End Sub

End Module
