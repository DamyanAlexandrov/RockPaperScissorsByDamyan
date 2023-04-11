const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors:");

//player
string playerMove = Console.ReadLine();

if (playerMove == "r"  || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

//computer
string computerMove = "";

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);

if (computerRandomNumber == 1)
{
    computerMove = Rock;
}
else if (computerRandomNumber == 2)
{
    computerMove = Paper;
}
else if (computerRandomNumber == 3)
{
    computerMove = Scissors;
}

//results
if ((playerMove == Rock && computerMove == Rock) || (playerMove == Paper && computerMove == Paper) || (playerMove == Scissors && computerMove == Scissors))
{
    Console.WriteLine("This game was a draw.");
    return;
}
else if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
{
    Console.WriteLine("You win.");
    return;
}
else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
{
    Console.WriteLine("You lose.");
    return;
}