
bool runProgram = true;

while (runProgram)
{

    int input = 0;
    while (input <= 0)
    {
        Console.WriteLine("Enter a valid non negative integer");
        input = int.Parse(Console.ReadLine());
    }

    Console.WriteLine(string.Format("{0, 15} {1,15} {2,15}", "Number", "Squared", "Cubed"));

    for (int i1 = 1; i1 <= input; i1++)
    {
        int squarer = i1 * i1;
        int cuber = i1 * i1 * i1;
        Console.WriteLine(string.Format("{0, 15} {1,15} {2,15}", i1, squarer, cuber));
    }
   
    while(true)
    {
    Console.WriteLine("Do you want to continue? y/n");
    string choice = Console.ReadLine().Trim().ToLower();

    if (choice == "y")
    {
        runProgram= true;
        break;

    }
    else if (choice == "n")
    {
        runProgram = false;
        break;

    }
}
    
}





