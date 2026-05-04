public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create a fixed array with capacity of length
        // Iterate from index 0 to length - 1.
        // For each iteration multiply the number by the current position + 1, and store computed value in the array at the current index.
        // Finally return the array.
        double [] multiples = new double[length];
        for(int x = 0; x < length; x++)
        {
            multiples[x] = (x + 1) * number;
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Copy last amount items from the list
        // Remove those last amount items from the original list
        // Insert the copied elements at the beginning of the list
        if( amount <0 || amount > data.Count) return;
        List<int> copiedItems = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, copiedItems);
        foreach(var item in data)
        {
            Console.WriteLine(item);
        }
        
    }
}
