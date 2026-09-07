using System;
using System.Data;
public class Tamagochi
{
    private int _Hunger;
    private int _Boredom;
    private List<string> Words;
    private bool _isAlive = true;
    public string Name;

    public void Feed()
    {
        
    }

    public void Hi()
    {
        
    }

    public void Teach(string Word)
    {
        
    }

    public void Tick()
    {
        
    }

    public void PrintStat()
    {
        Console.WriteLine($"Hunger: {_Hunger}");
        Console.WriteLine($"Boredom: {_Boredom}");

        if(_isAlive == true)
        {
            Console.WriteLine("Your Tamogochi is alive and well");
        }

        else if (_isAlive == false)
        {
            Console.WriteLine("Your Tamagochi died because of your hands");
        }

        Console.ReadLine();
        Console.Clear();
    }

    public bool GetAlive()
    {
       return true; 
    }

    private void ReduceBoredom()
    {
        
    }
}
