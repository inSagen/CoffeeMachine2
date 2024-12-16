using System.Diagnostics;

namespace CoffeeMachine2;

public class CoffeeMachine
{
    public string[] CoffeeTypes = {"Латте", "Эспрессо", "Американо", "Капучино", "Мокко"};

    public void ShowCoffeeMenu()
    {
        Console.WriteLine("Меню:");
        for (int i = 0; i < CoffeeTypes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {CoffeeTypes[i]}");
        }
    }
    public virtual void MakeCoffee(int userCoffeeChoice, int userSugarChoice)
    {
        Console.WriteLine("Готовим кофе, добавляем сахар...");
    }

    public void CookCoffee(int userCoffeeChoice, int userSugarChoice) //В классах кофе нет записи "Готовим Латте/ Готовим Капучино", вместо этого решил немного усложнить, передавать ввод пользователя в метод и отображать нужный тип из массива. 
    {                                                                 //из-за этого по сути получилось дублирование кода во всех классах коффе. По идее можно вместо 5 классов оставить один, но решил +- так как было на уроке, по классу на кофе. К тому же нет самого рецепта, методов готовки. Я думаю такое лучше в своём классе прописать. 
        switch (CoffeeTypes[userCoffeeChoice - 1])                    //на счёт поддержки данного кода хз, вроде не тяжело, при желании можно добавить новый тип кофе в массив и switch. Единственное, при этом нужно лезть в исходный класс, а не делать всё в новом. Это, наверное, минус
        {
            case "Латте":
                var latte = new Latte();
                latte.MakeCoffee(userCoffeeChoice, userSugarChoice);
                break;
            
            case "Эспрессо":
                var espresso = new Espresso();
                espresso.MakeCoffee(userCoffeeChoice, userSugarChoice);
                break;
            
            case "Американо":
                var americano = new Americano();
                americano.MakeCoffee(userCoffeeChoice, userSugarChoice);
                break;
            
            case "Капучино":
                var cappuccino = new Cappuccino();
                cappuccino.MakeCoffee(userCoffeeChoice, userSugarChoice);
                break;
            
            case "Мокко":
                var mocha = new Mocha();
                mocha.MakeCoffee(userCoffeeChoice, userSugarChoice);
                break;
        }
    }


}