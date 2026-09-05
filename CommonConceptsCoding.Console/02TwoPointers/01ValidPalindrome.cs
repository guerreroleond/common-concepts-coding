namespace CommonConceptsCoding.Console;

/// <summary>
/// 02TwoPointers-01ValidPalindrome [Easy]
/// Determine whether a string is a palindrome after converting uppercase letters to lowercase and removing non-alphanumeric characters.
/// </summary>
public class ValidPalindrome
{
    /// <summary>
    /// 02TwoPointers-01ValidPalindrome [Easy]
    /// </summary>
    /// <param name="s">String to evaluate.</param>
    /// <returns>True if the string is a palindrome; otherwise, false.</returns>
    public static bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            // Discard non-alphanumeric chars.
            while (left < right
            && !char.IsLetterOrDigit(s[left]))
                left++;
            while (right > left
            && !char.IsLetterOrDigit(s[right]))
                right--;

            if (char.ToLowerInvariant(s[left])
            != char.ToLowerInvariant(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
