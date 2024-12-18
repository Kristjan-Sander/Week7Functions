string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fish", "hamsters" };
string[] caracters = { "Harry", "Ron" };

PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(caracters);
static void PrintArrayElements(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {someArray[i]}");
    }
}