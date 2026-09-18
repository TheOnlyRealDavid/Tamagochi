Tamagochi MyTama = new Tamagochi();
bool game = true;


while(game = true)
{
MyTama.Tick();
MyTama.PrintStat();
Console.WriteLine("what do you want to do?");
Console.WriteLine("1. Feed");
Console.WriteLine("2. End");
string choice = Console.ReadLine();

int.TryParse(choice, out int TheChoice);

if(TheChoice == 1)
{
  MyTama.Feed();
}

else if(TheChoice == 2)
{
  break;
}
}



