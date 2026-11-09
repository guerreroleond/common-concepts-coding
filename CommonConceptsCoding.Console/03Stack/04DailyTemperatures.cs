using System.Globalization;

namespace CommonConceptsCoding.Console;

/// <summary>
/// 03Stack-04DailyTemperatures [Medium]
/// Calculates how many days each day must wait for a warmer temperature.
/// </summary>
public class DailyTemperatures
{
    /// <summary>
    /// 03Stack-04DailyTemperatures [Medium]
    /// Returns, for each day, the number of days until a warmer temperature occurs.
    /// </summary>
    /// <param name="temperatures">The daily temperatures.</param>
    /// <returns>An array where each element is the days to wait for a warmer day, or 0 if none exists.</returns>
    /// Input: temperatures = [73,74,75,71,69,72,76,73]
    /// Output:               [ 1, 1, 4, 2, 1, 1, 0, 0]
    public static int[] GetDaysUntilWarmer(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        var daysStack = new Stack<int>();

        for (int j = 0; j < temperatures.Length; j++)
        {
            while (daysStack.Count > 0
            && temperatures[j] > temperatures[daysStack.Peek()])
            {
                var i = daysStack.Pop();
                answer[i] = j - i;
            }
            daysStack.Push(j);
        }

        return answer;
    }
}
