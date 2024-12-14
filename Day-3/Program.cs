namespace Day_3;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());
        string result = (n % 2 != 0 || (n % 2 == 0 && n >= 6 && n <= 20)) ? "Weird" : "Not Weird";
        Console.WriteLine(result);
    }
}