using System.Dynamic;
public class ProgramUI;
{
    private readonly MenuItems _repo = new MenuItems();
    public void Run()
    {
       Seed();
       RunMenu();
    }

// The Menu goes HERE...
public void RunMenu()
{
    bool continueToRun = true;
    do
    {
        Console.Clear();
        Console.WriteLine(
            "Menu:\n" + 
            "1. List Menu Item By Meal Number"
            "2. List By Meal Name"
            "3. List by Meal Description"
            "4. List Of Meal Ingredients"
            "5. Meal Price"
            "6. Enter new menu items"
            "7. Exit"
        );
        
        string selection = Console.ReadLine()?? "";

        switch (selection)
        {
            case "1";
                ListByMealNumber();
                break;
            case "2";
                ListByMealName();
                break;
            case"3";
                ListByMealDescription();
                break;
            case "4";
                ListByMealIngredients();
                break;
            case "5";
                ListPriceOfMeal();
                break;
            case "6";
                CreateNewMenuItem();
            case "7";
                continueToRun = false;
                break;
            default:
            Console.Writeline("Please enter a selection that's valid.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        }
    }while (continueToRun);
}

public void ListByMealNumber();
    {
    Console.Clear();
    
    Console.WriteLine("Please enter the Meal by its Number: ");
    Console.ReadLine();

    }


public void ListByMealName();
    {
    Console.Clear();

    Console.WriteLine("Please enter the name of the meal: ");
    Console.ReadLine();
    }

public void ListByMealDescription();
    {
    Console.Clear();

    Console.WriteLine("Please enter a short description of meal:");
    Console.ReadLine();
    }
public void ListByMealIngredients();
    {
    Console.Clear();

    Console.WriteLine("Please enter the meal ingredients: ");
    Console.ReadLine();

    }

public void ListPriceOfMeal();
    {
    Console.WriteLine("Please enter the price in dollars of the meal: ");
    Console.ReadLine();
    }

public void CreateNewMenuItem();
    {
    Console.Clear();
    string title = CreateNewMenuItem();
    Console.WriteLine("Please enter a menu item: ");
    Console.ReadLine();
    }

//Helper Methods go here...
private void PauseAndWaitForKeypress()
    {
        Console.WriteLine("Press any Key to continue...");
        ConsoleReadKey();
    }
}
