namespace Day_7;
internal static class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arrTemp = Console.ReadLine()!.Split(' ');
        int[] arr = Array.ConvertAll(arrTemp,int.Parse);
        Array.Reverse(arr);
        foreach(var i in arr) Console.Write(i+" ");
    }
}