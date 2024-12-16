namespace CoffeeMachine2;

public class Cappuccino : CoffeeMachine
{
    public override void MakeCoffee(int userCoffeeChoice, int userSugarChoice)
    {
        Console.WriteLine($"Готовим {CoffeeTypes[userCoffeeChoice - 1]}, добавляем {userSugarChoice} ложек сахара...");
        Console.WriteLine($"{CoffeeTypes[userCoffeeChoice - 1]} готов, приятного аппетита!");
    }
}