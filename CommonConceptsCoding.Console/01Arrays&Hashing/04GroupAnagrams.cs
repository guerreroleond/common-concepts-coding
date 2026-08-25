namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-04GroupAnagrams [Medium]
/// Given an array of strings strs, group all anagrams together and return them as a list of groups.
/// </summary>
public class GroupAnagrams
{
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
