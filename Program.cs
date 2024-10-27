// David 10/26/24
Console.Clear();
int result = AskForNumber("What is your favorite Number");
Console.WriteLine($"{result} is a good number");
int result2 = AskForNumberInRange("What is a number between 5 and 55?", 5, 55);
Console.WriteLine($"{result2} is a number between 5 and 55.");

int AskForNumber(string text)
{
    int holder;
    while(true)
    {
        Console.Write($"{text} ");
        string num = Console.ReadLine();

        bool isNum = int.TryParse(num, out holder);
        if(isNum == false) // Checks if the user put in a number
        {
            Console.WriteLine("That was not a number silly");
        }else
        {
            int number = Convert.ToInt32(num);
            return number;
        }
    }
}

int AskForNumberInRange(string text, int min, int max)
{
    int someNumber;
    int number = 0;
    while (true)
    {
        Console.Write($"{text} ");
        string input = Console.ReadLine();

        bool isNum = int.TryParse(input, out someNumber);
        if(isNum == false)
        {
        Console.WriteLine("That is not a number try again");
        }else if(isNum == true)
        {
            number = Convert.ToInt32(input);

            if(number > max || number < min)
            {
            Console.WriteLine("That number is not in the Range");
            }else if(number < max && number > min)
            {
            return number;
            }
        }
    }
}