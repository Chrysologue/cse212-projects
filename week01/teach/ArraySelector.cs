public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int list1Pointer = 0;
        int list2pointer = 0;
        int index = 0;
        int [] results = new int [select.Length];
        foreach(var item in select)
        {
            if(item == 1)
            {
                results[index] = list1[list1Pointer];
                list1Pointer++;
            }
            else if(item == 2)
            {
                results[index] = list2[list2pointer];
                list2pointer++;
            }
            index++;
        }
        return results;
    }
}