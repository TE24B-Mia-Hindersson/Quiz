// int Hitpoints = 100 + 50 * 2;
//     Hitpoints = Hitpoints - 10;
//     Hitpoints -= 5;
//     Hitpoints--;

// Console.WriteLine($"HP: {Hitpoints}");
// if (Hitpoints <= 190)
// {
//      Console.WriteLine("Skadad");
//  }
// Console.ReadLine();



int hitpoints = 0;
Console.WriteLine("Welcome to my quiz about Batman!");
Console.WriteLine("Can you get all 5 right?");
Console.WriteLine("Time for the first question!");
Console.WriteLine("To start, what is the name of the alley where Bruce Waynes (Batmans) parents were killed?");
Console.WriteLine("A: Crime alley ");
Console.WriteLine("B: Darkstreet  ");
Console.WriteLine("C: Waynealley  ");
string svar1 = Console.ReadLine().Trim().ToLower();
if (svar1 == "a")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congrats, that was correct!");
    Console.WriteLine("+1 point!");
    hitpoints++;
    Console.WriteLine("Great start!");
    Console.ResetColor();
}
else if (svar1 == "b")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("oh no! hopefully you get it right next time..");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("oops! good luck on the next question");
    Console.ResetColor();
}

Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine("Time for question number two!");
Console.WriteLine("Now, how many robins have there been?");
Console.WriteLine("A: 1");
Console.WriteLine("B: 4");
Console.WriteLine("C: 5 ");
string svar3 = Console.ReadLine().Trim().ToLower();
if (svar3 == "c")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congrats, that was correct!");
    Console.WriteLine("+1 point!");
    hitpoints++;
    Console.WriteLine("Good jobb!");
    Console.ResetColor();
}

else if (svar3 == "b")

{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("Better luck next time..");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("Better luck next time..");
    Console.ResetColor();
}

Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine("Time for question number three!");
Console.WriteLine("Now, what are their names?");
Console.WriteLine("A: Robin 1, Robin 2, Robin 3, Robin 4 and Robin 5");
Console.WriteLine("B: Damian Wayne, Dick Grayson, Jason Todd, Tim Drake and Stephanie Brown");
Console.WriteLine("C: Jervis Tetch, Waylon James, Victor Fries, Edward Nygma and Pamela Isley");
string svar2 = Console.ReadLine().Trim().ToLower();
if (svar2 == "b")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congrats, that was correct!");
    Console.WriteLine("+1 point!");
    hitpoints++;
    Console.WriteLine("Nice!");
    Console.ResetColor();
}

else if (svar2 == "c")

{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("Better luck next time..");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine(":( maybe youll get it right next time!");
    Console.ResetColor();
}

Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine("Time for question number four!");
Console.WriteLine("Now, What robin was kidnapped, thought to be dead and by who?");
Console.WriteLine("A: Tim drake, by the penguin");
Console.WriteLine("B: Jason todd, by the Joker");
Console.WriteLine("C: Dick Grayson, by the riddler ");
string svar4 = Console.ReadLine().Trim().ToLower();
if (svar4 == "b")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congrats, that was correct!");
    Console.WriteLine("+1 point!");
    hitpoints++;
    Console.WriteLine(":D yay!");
    Console.ResetColor();
}
else if (svar4 == "c")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("That sucks! ");
    Console.ResetColor();

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("Do better?");
    Console.ResetColor();
}
Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine("Time for question number five!");
Console.WriteLine("Last but not least, In the game arkham knight you are able to capture villians in your batmobile..");
Console.WriteLine("which is one of the first ones you capture? ");
Console.WriteLine("A: The penguin ");
Console.WriteLine("B: Firefly");
Console.WriteLine("C: Poison Ivy ");
string svar5 = Console.ReadLine().Trim().ToLower();
if (svar5 == "c")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congrats, that was correct!");
    Console.WriteLine("+1 point!");
    hitpoints++;
    Console.WriteLine("Impressive!");
    Console.ResetColor();
}

else if (svar5 == "b")

{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine("Darn it!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oh no, that was incorrect!");
    Console.WriteLine("0 points..");
    Console.WriteLine(":(");
    Console.ResetColor();
}

Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine("Time for the point reveal!!");
Console.WriteLine($"You scored {hitpoints} points out of 5!");
if (hitpoints == 5)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Perfect score! You really know your Batman lore.");
}
else if (hitpoints == 4)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Almost perfect! I am very impressed!");
}
else if (hitpoints == 3)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Great job! You got most of them right.");
}
else if (hitpoints == 2)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Not bad, but theres room for improvement.");
}
else if (hitpoints == 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Just one correct… disapointing");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("wow.. uh");

}

Console.ReadLine();