public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text) {
    // We use a HashSet to store letters we've already seen.
    // This gives us O(n) efficiency because we only traverse the text once.
    var seen = new HashSet<char>();

    foreach (var letter in text) {
        // If the letter is already in the set, we found a duplicate
        if (seen.Contains(letter)) {
            return false;
        }
        // If it's not in the set, we add it and continue
        seen.Add(letter);
    }

    // If we reach this point, all letters are unique
    return true;
}
}