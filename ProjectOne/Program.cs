using System;

public class Program {

static int FirstInputInteger;

public static void Main() {
Console.WriteLine("Welcome to the ticket system program!");
FirstPromptPage();
}

public static void FirstPromptPage() {
Console.WriteLine("--------------------Command options------------------------------");
Console.WriteLine("[1] To register please press 1.");
Console.WriteLine("[2] To login with an existing account please press 2.");
FirstInputHandler();
}

public static void FirstInputHandler() {
String FirstInput = Console.ReadLine();
try {
FirstInputInteger = Int32.Parse(FirstInput);
}
catch {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please input an integer!");
    Console.ResetColor();
    FirstPromptPage();
    return;
}
Console.WriteLine("You chose "+FirstInputInteger);
if (FirstInputInteger == 1) {
}
else if (FirstInputInteger == 2) {
}
else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please input one of the options.");
    Console.ResetColor();
FirstPromptPage();
}
}

}