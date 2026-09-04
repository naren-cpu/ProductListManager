
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

Console.WriteLine(); //Empty Line
Console.WriteLine("Products entered:");

foreach(string name in product)
{
    Console.WriteLine(name); //Listing all user entered product names
}



