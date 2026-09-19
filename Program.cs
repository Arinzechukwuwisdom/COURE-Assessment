using System.Threading.Channels;

//int[] ints = new int[10];Do I need to specify how many indexies needed [10]
//int[] ints1 = [1, 2, 3];
//int ints2 = Convert.ToInt32(Console.ReadLine());
//if (ints2 / 2 == 0) 
//{
//    Console.WriteLine([i]);
//}
//ints.Select(i => i);
//int[] ints = [1,2,3,4,5,6,7,8];
// even ints = [2,4,6,8]
// old ints = [1, 3, 5,7] 
// Add 1point if ints = [2,4,6,8]
//  Add 3points if ints =[1, 3, 5,7] 
// Add 5 points for every time you encounter an 8 in the array
//Console.WriteLine("Enter numbers separated by spaces (e.g., 1 2 3 4 5):");
//string input = Console.ReadLine();

//// 1. Split the string by spaces into an array of smaller strings
//string[] stringArray = input.Split(' ');

//// 2. Convert each string into an integer and put it in a new int array
//int[] intArray = Array.ConvertAll(stringArray, Convert.ToInt32);

//// Your array is ready to use!
//Console.WriteLine($"You entered {intArray.Length} numbers.");

//int[] numbers = { 1, 2, 3, 4, 5 }; // Your input array
//int totalScore = 0;                 // Your scoreboard starting at 0

//foreach (int num in numbers)
//{
//    // Special rule first: Check if the number is exactly 8
//    if (num == 8)
//    {
//        totalScore += 5; // Add 5 points
//    }
//    // Separation: Check if the number is even
//    else if (num % 2 == 0)
//    {
//        totalScore += 1; // Add 1 point for even numbers
//    }
//    // Separation: If it's not 8 and not even, it must be odd
//    else
//    {
//        totalScore += 3; // Add 3 points for odd numbers
//    }
//}

//Console.WriteLine($"Final Score: {totalScore}"); // This will print 11



        // 1. Get the array input from the console
        Console.WriteLine("Enter numbers separated by spaces (e.g., 1 2 3 4 5 or 8 2 3):");
        string input = Console.ReadLine();

        // Convert the input string into an integer array
        string[] stringArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(stringArray, Convert.ToInt32);

        // 2. Initialize the scoreboard
        int totalScore = 0;

        // 3. Process each number using your rules
        foreach (int num in numbers)
        {
            // Rule C: Highest priority rule (check for 8 first)
            if (num == 8)
            {
                totalScore += 5;
            }
            // Rule A: Check if the number is even
            else if (num % 2 == 0)
            {
                totalScore += 1;
            }
            // Rule B: If it's not 8 and not even, it must be odd
            else
            {
                totalScore += 3;
            }
        }

        // 4. Output the final scoreboard result
        Console.WriteLine($"\nTotal Score: {totalScore}");
    



