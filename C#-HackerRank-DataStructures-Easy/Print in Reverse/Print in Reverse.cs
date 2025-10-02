class Result
{

    /*
     * Complete the 'reversePrint' function below.
     *
     * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

    public static void reversePrint(SinglyLinkedListNode llist)
    
    {
        if (llist == null)
        {
            return;
        }
        reversePrint(llist.next);
        Console.WriteLine(llist.data);
    }

}
