while (true)
{
    Console.WriteLine("Enter numbers separated by spaces (e.g., 1 2 3 4 5 or 8 2 3):");

    string input = Console.ReadLine();

    string[] stringArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int totalScore = 0;
    bool validInput = true;

    foreach (string item in stringArray)
    {
        if (!int.TryParse(item, out int num))
        {
            Console.WriteLine($"'{item}' is not a valid number. Please try again.");
            validInput = false;
            break;
        }

        if (num == 8)
        {
            totalScore += 5;
        }
        else if (num % 2 == 0)
        {
            totalScore += 1;
        }
        else
        {
            totalScore += 3;
        }
    }

    if (validInput)
    {
        Console.WriteLine($"\nTotal Score: {totalScore}");
        break;
    }
}