Tamagochi MyTama = new Tamagochi();

Console.WriteLine("Welcome to your own Tamagochi");
Console.WriteLine("Write your name for your Tamogochi");
MyTama.Name = Console.ReadLine();

Console.WriteLine($"Great name, your tamogachi is now named: {MyTama.Name}");
Console.WriteLine("Press any button to continue to play");
Console.ReadLine();
Console.Clear();

while(MyTama.GetAlive() == true)
{
  MyTama.PrintStat();
  
  Console.WriteLine("What do you want to do?");
  Console.WriteLine($"1. Teach {MyTama.Name} a new world ");
  Console.WriteLine($"2. Talk to {MyTama.Name} ");
  Console.WriteLine($"3. Feed {MyTama.Name} ");
  Console.WriteLine("4. Do nothing ");
  string choice = Console.ReadLine();
  
  if(choice == "1")
  {
    
  }

  else if (choice == "2")
  {
    MyTama.Hi();
  }

  else if (choice == "3")
  {
    MyTama.Feed();
  }

  else
  {
    Console.WriteLine("Doing nothign as you choice");
  }
  MyTama.Tick();
  Console.WriteLine("Press any button to continue");
  Console.ReadLine();
  Console.Clear();

}

Console.WriteLine($"OH NO! {MyTama.Name} is dead!"); //såg att denna del var i facit efter jag har kollat om jag gjorde rätt så jag härmade det
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();