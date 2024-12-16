using System;
using CoffeeMachine2;
public class Program
{
    static void Main(string[] args)
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();
        coffeeMachine.ShowCoffeeMenu();
        
        Console.WriteLine("Пожалуйста, выберите напиток:");
        int userCoffeeChoice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Пожалуйста, выберите количество сахара:");
        int userSugarChoice = int.Parse(Console.ReadLine());
        coffeeMachine.MakeCoffee(userCoffeeChoice, userSugarChoice);
    }
}

