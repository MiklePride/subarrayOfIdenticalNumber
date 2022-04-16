class Program
{
    static void Main(string[] args)
    {
        int[] arrayOfIntegers = new int[30];
        int indexArrayOfIntegers;
        Random random = new Random();
        int minimumRandomNumber = 1;
        int maximumRandomNumber = 5;
        int repeatingNumber = 0;
        int repeatCounter = 1;
        int repeatCounterDefault = 1;
        int repeatCounterBuffer = 0;
        int comparisonRepeatCounter = 0;



        for (indexArrayOfIntegers = 0; indexArrayOfIntegers < arrayOfIntegers.Length; indexArrayOfIntegers++)
        {
            arrayOfIntegers[indexArrayOfIntegers] = random.Next(minimumRandomNumber, maximumRandomNumber);
            Console.Write(arrayOfIntegers[indexArrayOfIntegers] + " ");
        }

        for (indexArrayOfIntegers = 0; indexArrayOfIntegers < arrayOfIntegers.Length - 1; indexArrayOfIntegers++)
        {
            if (arrayOfIntegers[indexArrayOfIntegers] == arrayOfIntegers[indexArrayOfIntegers + 1])
            {
                repeatCounter++;
            }
            else
            {
                repeatCounterBuffer = repeatCounter;
                repeatCounter = repeatCounterDefault;
            }

            if (repeatCounter > comparisonRepeatCounter)
            {
                comparisonRepeatCounter = repeatCounter;
                repeatingNumber = arrayOfIntegers[indexArrayOfIntegers];
            }
        }
        Console.WriteLine($"\nЧисло {repeatingNumber} повторяется {comparisonRepeatCounter} раз.");
    }
}