using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> MyList = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            MyList.Add(i);
        }
        Console.WriteLine(MyList.Count);
        foreach (var item in MyList)
        {
            Console.Write(item + ",");
        }
        Console.WriteLine("");
        //xoa phan tu so 5
        MyList.RemoveAt(5);
        foreach (var item in MyList)
        {
            Console.Write(item + " ");
        }
    }
}