using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public enum ListPriceOfMeal { 1.99, 2.99, 3.49, 4.99, 19.99 }
public enum ListByMealNumber { 1, 2, 3, 4, 5 }


namespace CafeRepository
{
    private readonly List<MenuItems>_MenuItems = new List<MenuItems>();

public class MenuItems()

    {
        Seed();
    }

    //Create
    public bool AddMenuItems(MenuItems content)
    {
        int startingCount = _MenuItems.Count;

        _contentDirectory.Add(content);

        bool wasAdded = _contentDirectory.Count;

        return wasAdded;
    }

    //Okay now we READ this time...
    public List<MenuItems> GetMenuItems()
    {
        return _contentDirectory;
    }

    public MenuItems GetContentByMenuItems(string MenuItems)
    {
        foreach (MenuItems content in _contentDirectory)
        {
            if(content.MenuItems.ToLower() == MenuItems.ToLower())
            {
                return content;
            }
        }

        return default;
    }
//We update stuff here...

public bool UpdateExistingContent(string MenuItems, listByMealName, ListByMealDescription, ListByMealNumber, ListPriceOfMeal, ListByMealIngredients)
{
    MenuItems oldContent = GetContentByMenuItems(MenuItems);

    if (oldcontent != default)
    {
        oldContent.MenuItems = newContent.MenuItems;
        oldContent.ListByMealName = newContent.ListByMealName;
        oldContent.ListByMealDescription = newContent.ListByMealDescription;
        oldContent.ListByMealNumber = newContent.ListByMealNumber;
        oldContent.ListPriceOfMeal = newContent.ListPriceOfMeal;
        oldContent.ListByMealIngredients = newContent.ListByMealIngredients;

        return true;
            }
            else
            {
                return false;
            }
        
    }
}

//...And finally we delete stuff here.

public bool DeleteExistingContent(string)
{
    MenuItems contentToDelete = GetMenuItems;

    if (contentToDelete != default)
    {
        bool deleteResult = _contentDirectory.Remove(MenuItems);
        return deleteResult;
    }
    else
    {
        return false
    }
}

    public class MenuItems
    {
        public string = "egg";
        public string = "egg and spam"; 
        public string = "egg sausage and spam";
        public string = "spam egg bacon and spam"; 
        public string = "spam spam spam tomato and spam";
        public string = "Lobster Thermidor a Crevette with a mornay sauce served in a Provencale manner with shallots and aubergines garnished with truffle pate brandy and with a fried egg on top and spam";
    }
        if 
    {
        switch MenuItems(ListByMealNumber)
        {
            case ListByMealNumber = "1";
                Console.WriteLine("egg");
                break;
            case ListByMealNumber = "2";
                Console.WriteLine("egg and spam")
                break;
            case ListByMealNumber = "3";
                Console.WriteLine("egg,sausage, and Spam")
                break;
            case ListByMealNumber = "4";
                Console.WriteLine("Spam, egg, bacon, and Spam")
                break;
            case ListByMealNumber = "5";
                Console.WriteLine("Lobster Thermidor a Crevette with a mornay sauce served in a Provencale manner with shallots and aubergines garnished with truffle pate brandy and with a fried egg on top and spam")
                break;
    }
}       
        
