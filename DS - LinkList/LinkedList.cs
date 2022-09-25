


public class LinkedList
{
    public Node First { get; set; }
    public void insertAtFirst(int data)
    {
        //Created new Node
        Node node = new Node();

        //Put data into new node
        node.Data = data;

        //Put old node into Next
        node.Next = First;
        
        //Make the first new node
        First = node;
    }

    public void insertAtLast(int data)
    {
        Node current = First;

        while(current.Next != null)
        {
            current = current.Next;
        }
        //Create new node
        Node NewNode = new Node();

        //put the into new node
        NewNode.Data = data;
        current.Next = NewNode;
    }

    public void insertAtAny(Node previous_node, int data)
    {
        if(previous_node != null)
        {
            Node NewNode = new Node();
            NewNode.Data = data;

            NewNode.Next = previous_node.Next;
            previous_node.Next = NewNode;
        }
    }


    public void showList()
    {
        Node current = First;
        Console.WriteLine("Iterating thru...");

        while (current != null)
        {
            current.showList();
            current = current.Next;
        }
    }
}