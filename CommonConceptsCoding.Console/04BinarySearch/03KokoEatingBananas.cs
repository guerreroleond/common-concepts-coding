namespace CommonConceptsCoding.Console;

/// <summary>
/// 04BinarySearch-03KokoEatingBananas [Medium]
/// Determines the slowest eating speed that lets Koko finish all banana piles in time.
/// </summary>
public class KokoEatingBananas
{
    /// <summary>
    /// 04BinarySearch-03KokoEatingBananas [Medium]
    /// Finds the minimum integer eating speed (bananas per hour) that finishes all piles within the given hours,
    /// using binary search over the speed range from 1 to the largest pile.
    /// </summary>
    /// <param name="piles">The number of bananas in each pile.</param>
    /// <param name="h">The number of hours available.</param>
    /// <returns>The minimum eating speed that allows all piles to be eaten within <paramref name="h"/> hours.</returns>
    public static int GetMinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();
        int answer = right;                 // max speed always works

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            long hours = 0;
            foreach (var p in piles)
                hours += (p + mid - 1) / mid;   // ceil(p / mid)

            if (hours <= h)
            {
                answer = mid;               // 🏁 valid, save it...
                right = mid - 1;            // ...but try slower
            }
            else
            {
                left = mid + 1;             // ❌ too slow, speed up
            }
        }

        return answer;
    }


    /// <summary>
    /// 04BinarySearch-03KokoEatingBananas [Medium]
    /// Finds the minimum integer eating speed (bananas per hour) that finishes all piles within the given hours.
    /// </summary>
    /// <param name="piles">The number of bananas in each pile.</param>
    /// <param name="h">The number of hours available.</param>
    /// <returns>The minimum eating speed that allows all piles to be eaten within <paramref name="h"/> hours.</returns>
    /// <exception cref="NotImplementedException">The operation has not been implemented.</exception>
    public static int GetMinEatingSpeed_Wrong(int[] piles, int h)
    {
		// We need the searching range.
		int left = int.MaxValue;
		int right = 0;
        foreach (var p in piles)
        {
            if (p < left) left = p;
            if (p > right) right = p;
        }
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int hours = 0;

            foreach (var p in piles)
            {
                hours += (int)Math.Ceiling((double)p / mid);
            }

            if (hours == h)
                // Min speed found!
                return mid;
            else if (hours > h)
                // We need a faster speed, take right half.
                left = mid + 1;
            else
                // We need a slower speed, take left half.
                right = mid - 1;
        }

        return -1;
    }
}
