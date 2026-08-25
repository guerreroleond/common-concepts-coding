namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-02ValidAnagram [Easy]
/// Given two strings wordA and wordB, return true if wordB is an anagram of wordA, false otherwise.
/// </summary>
public class ValidAnagram
{

    /// <summary>
    /// 01Arrays&amp;Hashing-02ValidAnagram [Easy] — Constrained: O(1) space (only lowercase English letters).
    /// </summary>
    /// <param name="wordA">First input string.</param>
    /// <param name="wordB">Second input string to compare against wordA.</param>
    /// <returns>True if wordA is an anagram of wordB; otherwise, false.</returns>
    public static bool ConstrainedSolve(string wordA, string wordB)
    {
        ArgumentNullException.ThrowIfNull(wordA);
		ArgumentNullException.ThrowIfNull(wordB);

        // Not anagrams if lengths are different.
        if (wordA.Length != wordB.Length) return false;

        var charCounts = new int[28];

        foreach (char c in wordA)
            charCounts[c - 'a']++;

        foreach (char c in wordB)
        {
            charCounts[c - 'a']--;

            if (charCounts[c - 'a'] < 0) 
                return false;
        }

        return true;
    }

    /// <summary>
    /// 01Arrays&amp;Hashing-02ValidAnagram [Easy]
    /// </summary>
    /// <param name="wordA">First input string.</param>
    /// <param name="wordB">Second input string to compare against wordA.</param>
    /// <returns>True if wordA is an anagram of wordB; otherwise, false.</returns>
    public static bool Solve(string wordA, string wordB)
    {
        ArgumentNullException.ThrowIfNull(wordA);
		ArgumentNullException.ThrowIfNull(wordB);
		
		// Not anagrams if lengths are different.
		if(wordA.Length != wordB.Length) return false;
		
		Dictionary<char, int> charCounts = [];
		
		foreach(char c in wordA)
            charCounts[c] = charCounts.GetValueOrDefault(c) + 1;
		
		foreach(char c in wordB)
		{
            if(!charCounts.TryGetValue(c, out int count))
            // If char not present; NOT anagrams.
                return false;
                
            if(count == 1)
                charCounts.Remove(c);
            else
                charCounts[c] = count - 1;
		}
		
		return charCounts.Count == 0;
    }
}
