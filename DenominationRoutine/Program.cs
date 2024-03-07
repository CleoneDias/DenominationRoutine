using System.Linq;

static void FindCombinations(List<int> numbers, int target, List<int> combination, int startIndex)
{
    if (target == 0)
    {
        Console.WriteLine(string.Join(",", combination));
        return;
    }

    for (int i = startIndex; i < numbers.Count; i++)
    {
        if (numbers[i] <= target) 
        {
            combination.Add(numbers[i]);
            FindCombinations(numbers, target - numbers[i], combination, i);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
var numbers = new List<int>() { 10, 50, 100 };
Console.WriteLine("Please enter one of thies numbers: 30, 50, 60, 80, 140, 230, 370, 610, 980");
var validNumbers = new List<int>() { 30,50,60,80,140,230,370,610,980};
var target = Convert.ToInt32(Console.ReadLine());
if (!validNumbers.Contains(target))
{
    Console.WriteLine("Invalid number.");
}
Console.WriteLine();
FindCombinations(numbers, target, new List<int>(), 0);