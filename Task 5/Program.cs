

class Program
{
    public static void Main()
    {
        DateTime birthDate = new DateTime(1995, 8, 20); 

        
        DateTime currentDate = DateTime.Now;
        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.TotalDays / 365.25); // Approximate age in years

        //  Printing birthdate, current date, and age
        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
        Console.WriteLine($"Age: {ageInYears} years");
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");
    }
}
