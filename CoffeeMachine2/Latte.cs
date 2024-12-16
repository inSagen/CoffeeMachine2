namespace CoffeeMachine2;

public class Latte : CoffeeMachine
{
    public override void MakeCoffee(int userCoffeeChoice, int userSugarChoice)
    {
        Console.WriteLine($"Готовим {CoffeeTypes[userCoffeeChoice - 1]}, добавляем кубков сахара - {userSugarChoice}...");
        Console.WriteLine($"{CoffeeTypes[userCoffeeChoice - 1]} готов, приятного аппетита!");
    }
}