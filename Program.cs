bool playing = true;
int wins = 0;
int losses = 0;
List<string> choices = new List<string> { "rock", "paper", "scissors" };

Console.WriteLine("******** ROCK PAPER SCISSORS ********");
Console.WriteLine($"WINS: {wins}        LOSSES: {losses}");
Console.WriteLine("*************************************");
Console.WriteLine("Enter 'rock', 'paper', 'scissors', or 'quit'. Not case sensitive.");

while (playing)
{
  Random rand = new Random();
  int randIndex = rand.Next(0, choices.Count);
  string compChoice = choices[randIndex];
  string? input = "";

  input = Console.ReadLine().ToLower();

  if (input != "rock" || input != "paper" || input != "scissors" || input != "quit")
  {
    // TODO make list of snarky remarks to grab from randomly
    Console.WriteLine("invalid response, please read the extremely simple instructions and try again.");
    continue;
  }
  if (input == "quit")
  {
    playing = false;
  }

  string gameParams = compChoice + input;

  switch (gameParams)
    {
    case "paperpaper":
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"{compChoice}, It's a tie");
      Console.ForegroundColor = ConsoleColor.Gray;
      break;
    case "paperrock":
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"{compChoice}, You lose.");
      Console.ForegroundColor = ConsoleColor.Gray;
      losses++;
      break;
    case "paperscissors":
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"{compChoice}, You Win!!");
      Console.ForegroundColor = ConsoleColor.Gray;
      wins++;
      break;
    case "rockpaper":
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"{compChoice}, You Win!!");
      Console.ForegroundColor = ConsoleColor.Gray;
      wins++;
      break;
    case "rockrock":
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"{compChoice}, It's a tie");
      Console.ForegroundColor = ConsoleColor.Gray;
      break;
    case "rockscissors":
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"{compChoice}, You lose.");
      Console.ForegroundColor = ConsoleColor.Gray;
      losses++;
      break;
    case "scissorspaper":
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"{compChoice}, You lose.");
      Console.ForegroundColor = ConsoleColor.Gray;
      losses++;
      break;
    case "scissorsrock":
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"{compChoice}, You Win!!");
      Console.ForegroundColor = ConsoleColor.Gray;
      wins++;
      break;
    case "scissorsscissors":
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"{compChoice}, It's a tie");
      Console.ForegroundColor = ConsoleColor.Gray;
      break;
    }
}