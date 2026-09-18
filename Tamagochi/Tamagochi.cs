using System;
using System.Data;
using Microsoft.Win32.SafeHandles;
public class Tamagochi
{
    private int _Hunger;
    private int _Boredom;
    private List<string> Words;
    private bool _isAlive = true;
    public string Name;

    public void Feed()
    {
        _Hunger -=2; // hunger minskar med 1 för varje tick öknar hunger med 1 så nu när det är minus 2 så förlorar man 1 hunger om man väljer att mata sin tamogochi
        Console.WriteLine($"You feed your Tamagochi its current hunger is {_Hunger}");

        if(_Hunger <= -5)
        {
            Console.WriteLine("your Tamogashi dies because of over eating");
            _isAlive = false;
        }
        else if(_Hunger < 0)
        {
            Console.WriteLine($"You over feed your Tamagochi, stop before it affects your tamogochis health");
        }

        Console.ReadLine();
        Console. Clear();
    }

    public void Hi()
    {
        
    }

    public void Teach(string Word)
    {
        Console.WriteLine($"{Name} learns: {Word}");
        Words.Add(Word);
        ReduceBoredom();
    }

    public void Tick()
    {
        _Hunger ++; //jag tänker att hunger ökar med 1 varje tick
        _Boredom += 2;// iställer att boredom ökar med 1 varje gång ökar den med 2 istället varje tick för att göra det svårare

        if(_Boredom <= 10 && _Hunger <= 10)
        {
            _isAlive = true;
        }
        else
        {
            _isAlive = false;

        }
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

    public bool GetAlive() => _isAlive; //Micke visa något coolt

    private void ReduceBoredom()
    {
        _Boredom -=3; //samma tanke här som på att sänka hunger men här efter varje tick och om man väljer att sänka boredom så minskar den med 2 efter varje tick.
    }
}
