// CRUD APP - Project No.1
Console.WriteLine("Welcome to the Habit Tracker Console Application\n");

Console.WriteLine("MAIN MENU\n");

Console.WriteLine("What would you like to do? Please choose from the options below:");
var select = Console.ReadLine();

if (select == null)
{
    Console.WriteLine("Please type a valid input");
    Console.ReadLine();
}
switch (int.Parse(select.Trim()))
{
    case "0":
        CloseApp("Thank you for your time!");
    case "1":
        ViewRecord("Enter 1 - To View All Records");
    case "2":
        CreateRecord("Enter 2 - To Create/Insert Habit Record");
    case "3":
        UpdateRecord("Enter 3 - To Update Habit Record");
    case "4":
        DeleteRecord("Enter 4 - To Delete Habit Record");
    default:
        Console.WriteLine("Your input should be valid");
}




void CloseApp(string message)
{
    Console.WriteLine(message);
    Console.ReadLine();
    Environment.Exit(1);
}
void ViewRecord(string message)
{
    Console.WriteLine(message);
    Console.ReadLine();
}
void CreateRecord(string message)
{
    Console.WriteLine(message);
    Console.ReadLine();
}
void UpdateRecord(string message)
{
    Console.WriteLine(message);
    Console.ReadLine();
}
void DeleteRecord(string message)
{
    Console.WriteLine(message);
    Console.ReadLine();
}