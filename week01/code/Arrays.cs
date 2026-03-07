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
        // Plan:
        // 1. Initialize a new array of doubles with the specified length.
        // 2. Loop through the array from index 0 to length - 1.
        // 3. For each index 'i', calculate the multiple by multiplying 'number' by (i + 1).
        // 4. Assign the calculated multiple to the current index of the array.
        // 5. Return the completed array.

        double[] multiples = new double[length]; // Step 1

        for (int i = 0; i < length; i++) // Step 2
        {
            multiples[i] = number * (i + 1); // Step 3 & 4
        }

        return multiples; // Step 5
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
        // Plan:
        // 1. Determine the starting index of the segment to be moved (List length minus amount).
        // 2. Use GetRange to extract the sub-list that will be shifted to the front.
        // 3. Use RemoveRange to delete those elements from their original position at the end.
        // 4. Use InsertRange to place the extracted sub-list at index 0 (the beginning).

        // Calculate the start position for the split
        int splitIndex = data.Count - amount; // Step 1

        // Get the part that needs to move to the front
        List<int> endPart = data.GetRange(splitIndex, amount); // Step 2

        // Remove that part from the end of the original list
        data.RemoveRange(splitIndex, amount); // Step 3

        // Insert the extracted part at the very beginning
        data.InsertRange(0, endPart); // Step 4
    }
}
