using System.Threading.Channels;

        Console.WriteLine("Enter numbers separated by spaces (e.g., 1 2 3 4 5 or 8 2 3):");
        string input = Console.ReadLine();

        string[] stringArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(stringArray, Convert.ToInt32);

        int totalScore = 0;

        foreach (int num in numbers)
        {
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
        Console.WriteLine($"\nTotal Score: {totalScore}");
    



