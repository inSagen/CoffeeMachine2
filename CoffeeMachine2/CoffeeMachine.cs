namespace CoffeeMachine2;

public class CoffeeMachine
{
    enum CoffeeMenuEnum
    {
        Latte = 1,
        Espresso,
        Americano,
        Cappuccino,
        Mocha
    }

    private string[] CoffeeTypes = {"Латте", "Эспрессо", "Американо", "Капучино", "Мокко"};

    public void ShowCoffeeMenu()
    {
        for (int i = 0; i < CoffeeTypes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {CoffeeTypes[i]}");
        }
    }

    public virtual void MakeCoffee(int userCoffeeChoice, int userSugarChoice)
    {
        Console.WriteLine("Готовим кофе, добавляем сахар...");
    }
}