namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-05TopKFrequentElements [Medium]
/// Given an integer array nums and an integer k, return the k most frequent elements.
/// </summary>
public class TopKFrequentElements
{
    /// <summary>
    /// 01Arrays&amp;Hashing-05TopKFrequentElements [Medium] — Bucket Sort approach.
    /// </summary>
    /// <param name="nums">Input integer array.</param>
    /// <param name="k">Number of top frequent elements to return.</param>
    /// <returns>The k most frequent elements.</returns>
    public static int[] Solve(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfLessThan(k, 1);

        Dictionary<int, int> numFrequencies = [];

        foreach (var num in nums)
            numFrequencies[num] = numFrequencies.GetValueOrDefault(num) + 1;

        // Index = frequency.
        // Value = List of numbers having that frequency.
        var buckets = new List<int>[nums.Length + 1];

        foreach (var (num, frequency) in numFrequencies)
        {
            buckets[frequency] ??= [];
            buckets[frequency].Add(num);
        }

        var result = new int[k];
        int index = 0;

        // Start with the highest possible frequency.
        for (var frequency = buckets.Length - 1;
            frequency >= 1 && index < k;
            frequency--)
        {
            if (buckets[frequency] is null) continue;

            foreach(var num in buckets[frequency])
            {
                result[index++] = num;

                if (index == k) break;
            }
        }

        return result;
    }


    /// <summary>
    /// 01Arrays&amp;Hashing-05TopKFrequentElements [Medium]
    /// </summary>
    /// <param name="nums">Input integer array.</param>
    /// <param name="k">Number of top frequent elements to return.</param>
    /// <returns>The k most frequent elements.</returns>
    public static int[] SortingSolve(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfLessThan<int>(k, 1);

        Dictionary<int, int> numsCount = [];

        foreach (var num in nums)
            numsCount[num] = numsCount.GetValueOrDefault(num) + 1;

        return numsCount.OrderByDescending(n => n.Value).Take(k).Select(n => n.Key).ToArray();
    }
}
