namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-04GroupAnagrams [Medium]
/// Given an array of strings strs, group all anagrams together and return them as a list of groups.
/// </summary>
public class GroupAnagrams
{
    /// <summary>
    /// 01Arrays&amp;Hashing-04GroupAnagrams [Medium] — Constrained: O(m * n) time using fixed-size char frequency key.
    /// </summary>
    /// <param name="strs">Array of input strings to group.</param>
    /// <returns>A list of groups where each group contains strings that are anagrams of each other.</returns>
    public static IList<IList<string>> ConstrainedSolve(string[] strs)
    {
        ArgumentNullException.ThrowIfNull(strs);

        var groups = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var charCounts = new int[26];

            foreach (var c in word)
                charCounts[c - 'a']++;

            // Create a key with the frecuency signature.
            var key = string.Join('#', charCounts);

            if (!groups.TryGetValue(key, out var group))
            {// if key not found, create a new group.
                group = [];
                groups[key] = group;
            }

            group.Add(word);
        }

        return groups.Values.Cast<IList<string>>().ToList();
    }

    /// <summary>
    /// 01Arrays&amp;Hashing-04GroupAnagrams [Medium]
    /// </summary>
    /// <param name="strs">Array of input strings to group.</param>
    /// <returns>A list of groups where each group contains strings that are anagrams of each other.</returns>
    public static List<List<string>> Solve(string[] strs)
    {
        ArgumentNullException.ThrowIfNull(strs);

        List<List<string>> groupedAnagrams = [];

        foreach (var s in strs)
        {
            var anagramFound = false;
            foreach (var ga in groupedAnagrams)
            {
                if (ValidAnagram.Solve(ga[0], s))
                {
                    ga.Add(s);
                    anagramFound = true;
                }
            }

            if (!anagramFound) groupedAnagrams.Add([s]);
        }

        return groupedAnagrams;
    }
}
