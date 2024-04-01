using System.Text.RegularExpressions;

private var availableMessagePattern = "Add|Change|Deprecate|Remove|Fix|Rename|Create";
private var pattern = @$"^((?:{availableMessagePattern})|Merge)(?!\s*$).+";
private var msg = File.ReadAllLines(Args[0])[0];

if (Regex.IsMatch(msg, pattern))
{
   return 0;
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Invalid commit message");
Console.ResetColor();
Console.WriteLine($"Use [{availableMessagePattern}] pattern with optional [xxx] issue"
 + " number and non empty message");
Console.ForegroundColor = ConsoleColor.Gray;

return 1;
