/*
Console.WriteLine("-------------------------------");
Console.WriteLine("PRODUCT LIST MANAGER - LEVEL 1");
Console.WriteLine("-------------------------------");

Console.WriteLine("Enter product names.\nType 'exit' to finish.");
Console.WriteLine();

List<string> product = new List<string>(); //Creating Empty List


while(true)
{
    Console.Write("Product:");

    string? data = Console.ReadLine();

    if (data == "exit")
    {
        break;
    }
    product.Add(data); //Adding data to the List.
    
}

Console.WriteLine();
Console.WriteLine("Products entered:");

foreach(string name in product)
{
    Console.WriteLine(name); //Listing all user entered product names
}

*/
//-------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------
/*

Console.WriteLine("-------------------------------");
Console.WriteLine("PRODUCT LIST MANAGER - LEVEL 2");
Console.WriteLine("-------------------------------");

Console.WriteLine("Enter product names.\nType 'exit' to finish.");
Console.WriteLine();

List<string> product = new List<string>(); //Creating Empty List


while (true)
{
    Console.Write("Product:");

    string? data = Console.ReadLine();

    if(data.Trim().ToLower() == "exit")
    {
        break;
    }
    product.Add(data); //Adding data to the List.

}

product.Sort(); //Sort products in ascending order

Console.WriteLine();
Console.WriteLine("Sorted product list:");

foreach (string name in product)
{
    Console.WriteLine(name); //Listing all user entered product names
}

*/
//-------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------



Console.WriteLine("-------------------------------");
Console.WriteLine("PRODUCT LIST MANAGER - LEVEL 3");
Console.WriteLine("-------------------------------");

Console.WriteLine("Enter product names.\nType 'exit' to finish.");
Console.WriteLine();

List<string> product = new List<string>(); //Creating Empty List


while (true)
{
    Console.Write("Product:");

    string? data = Console.ReadLine();

    if (data.Trim().ToLower() == "exit")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(data))
    {
        Console.WriteLine("ERROR: Input cannot be empty.");
        continue;
    }

    if (!data.Contains("-"))
    {
        Console.WriteLine("ERROR: Product must contain a dash (-).");
        continue;
    }

    //Checking Valid examples

    string[] parts  = data.Split('-');
    string leftside = parts[0];
    string rightside = parts[1];

    //Checking left side contains letters only

    bool lettersOnly = true;

    foreach (char character in leftside)

    {

        if (!char.IsLetter(character))
        {
            lettersOnly = false;
            break;
        }

    }

    if (!lettersOnly || leftside.Length == 0)
    {
        Console.WriteLine("ERROR: The left side must contain letters only.");
        continue;
    }

    //Checking right side contains numbers only

    if (!int.TryParse(rightside, out int number))
    {
        Console.WriteLine("ERROR: The right side must contain numbers only.");
        continue;
    }

    if (number < 200 || number > 500)
    {
        Console.WriteLine("ERROR: The numeric part must be between 200 and 500.");
        continue;
    }

  
    product.Add(data); //Adding data to the List.

}

product.Sort(); //Sort products in ascending order

Console.WriteLine();
Console.WriteLine("Sorted valid products:");

foreach (string name in product)
{
    Console.WriteLine(name); //Listing all user entered product names
}



//-------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------

/*
using ProductListManager;
Console.WriteLine("-------------------------------");
Console.WriteLine("PRODUCT LIST MANAGER - LEVEL 4");
Console.WriteLine("-------------------------------");


Console.WriteLine("1. Add Product");
Console.WriteLine("2. View Products");
Console.WriteLine("3. Search Product");
Console.WriteLine("4. Delete Product");
Console.WriteLine("5. Statistics");
Console.WriteLine("6. Exit");

Console.WriteLine();

Console.Write("Select option: ");

string userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        //Console.Write("Enter product: ");
        Functions.AddProduct();
        break;
    case "2":
        Functions.ViewProduct();
        break;
    case "3":
        
        Functions.SearchProduct();
        break;
    case "4":
        Functions.DeleteProduct();
        break;
    case "5":
        Functions.Statistics();
        break;
    case "6":
        Console.WriteLine("Saving products...");
        Console.WriteLine("Application closed.");
        return;
    default:
        Console.WriteLine("Invalid option.");
        break;
}
*/