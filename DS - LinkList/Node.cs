
public class Node
{
    public int Data { get; set; }

    public Node? Next { get; set; }

    public void showList()
    {
        Console.WriteLine(Data);
    }
}