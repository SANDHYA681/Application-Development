// Create a List<string> containing 3 fruits
List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

// Add a new fruit
fruits.Add("Orange");

// Remove one fruit
fruits.Remove("Banana");

// Print all fruits
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Create a Dictionary<int, string> for fruit IDs and names
Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Orange" }
};

// Add a new entry
fruitDict.Add(4, "Grapes");

// Print all key-value pair
foreach (var item in fruitDict)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}