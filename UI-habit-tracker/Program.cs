// CRUD APP - Project No.1
Console.WriteLine("Welcome to the Habit Tracker Console Application\n");

Console.WriteLine("MAIN MENU\n");


public void GetUserInput() 
{
    Console.Clear();
    Console.WriteLine("What would you like to do? Please choose from the options below:");

    string select = Console.ReadLine();

    bool close = false;

    while (close == false)
    {
        
        switch (Convert.ToInt32(select))
        {
            case 0:
                CloseApp("Thank you for your time!");
                break;
            case 1:
                ViewRecord("Enter 1 - To View All Records");
                break;
            case 2:
                CreateRecord("Enter 2 - To Create/Insert Habit Record");
                break;
            case 3:
                UpdateRecord("Enter 3 - To Update Habit Record");
                break;
            case 4:
                DeleteRecord("Enter 4 - To Delete Habit Record");
                break;
            default:
                Console.WriteLine("Your input should be valid");
                break;
        }
    }
}





void CloseApp(string message)
{
    Console.WriteLine(message);
    close = true;
}
void ViewRecord(string message)
{
    Console.WriteLine(message);
}

// INSERT RECORD
void CreateRecord(string message)
{
    Console.WriteLine(message);
}
void UpdateRecord(string message)
{
    Console.WriteLine(message);
}
void DeleteRecord(string message)
{
    Console.WriteLine(message);
}

private static void GetDateInput() 
{
    Console.WriteLine("Input your date format:(mm-dd-yyyy). Type 0 to return to main menu");

    string date = Console.ReadLine();

    if (date == "0") GetUserInput();

}

// GET QUANTITY OF Water drink glass wkwk
private static void GetNumberInput()
{
    Console.WriteLine("Input the quantity of glasses of water you drank for the day");
    string quantity = Console.ReadLine();

    if (date == "0") GetUserInput();

    int finalQuantity = Convert.ToInt32(quantity);
    return finalQuantity;

}