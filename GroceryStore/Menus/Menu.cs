﻿namespace GroceryStore.Menus;

internal class Menu
{
    private readonly ProductMenu productMenu = new ProductMenu();
    public void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Välkommen till produktkatalogen för matbutiken Frossa");
        Console.WriteLine("1. Visa alla produkter");
        Console.WriteLine("2. Skapa en produkt");
        Console.WriteLine("3. Ta bort en produkt");
        Console.WriteLine("4. Avsluta");
        Console.Write("Välj ett av ovanstående alternativ (1-4):");

        var input = Console.ReadLine();

        switch (input)
        {
            case "1":

                break;

            case "2":

                break;

            case "3":
                break;

            case "4":
                break;

            default:
                Console.WriteLine("\nFelaktigt val, försök igen");
                Console.ReadKey();
                break;
        }

    }
}
