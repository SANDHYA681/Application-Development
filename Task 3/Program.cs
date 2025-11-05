

class Program
{
    public static void Main()
    {
   
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 100000;
        long myLong = 10000000000;
        float myFloat = 3.14f;
        double myDouble = 3.14159;
        decimal myDecimal = 1000.50m;
        char myChar = 'A';
        bool myBool = true;

        // converting
        int number = 42;
        string numberAsString = number.ToString();       // int to string
        string piString = "3.14";
        double piAsDouble = Convert.ToDouble(piString);  // string to double

        // printing values
        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"bool: {myBool}");
        Console.WriteLine($"Converted int to string: {numberAsString}");
        Console.WriteLine($"Converted string to double: {piAsDouble}");
    }
}
