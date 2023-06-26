using System.Text.RegularExpressions;

Console.Write("Enter your name and surname:");
var userInput = Console.ReadLine() ?? string.Empty;

userInput = userInput.ToLower();

var userWords = Regex.Split(userInput, @"\s+");
if (userWords.Length < 2)
{
    Console.WriteLine("You need both name and surname!");
    return;
}

for (var i = 0; i < userWords.Length; i++)
{
    if (i == 0 || i == userWords.Length - 1)
    {
        var currentWord = userWords[i];
        // upper case first letter, and add the rest of the word
        userWords[i] = char.ToUpper(currentWord[0]) + currentWord.Substring(1);
    }
}
var result = string.Join(" ", userWords);

Console.WriteLine("Greetings, " + result + "!");