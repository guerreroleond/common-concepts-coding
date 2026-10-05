using System.Text.RegularExpressions;

namespace CommonConceptsCoding.Console;

/// <summary>
/// 03Stack-01ValidParenthesis [Easy]
/// Determines whether a string of parentheses is valid.
/// </summary>
public class ValidParentheses
{
    /// <summary>
    /// 03Stack-01ValidParenthesis [Easy]
    /// Determines whether the brackets in the input string are properly matched and nested.
    /// </summary>
    /// <param name="s">The string containing brackets to validate.</param>
    /// <returns><see langword="true"/> if the brackets are valid; otherwise, <see langword="false"/>.</returns>
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
                continue;
            }

            // If closing bracket and no opennings in the stack.
            if (stack.Count == 0) return false;

            var opening = stack.Pop();

            if ((c == ')' && opening != '(')
            || (c == '}' && opening != '{')
            || (c == '[' && opening != ']'))
                return false;
        }

        return stack.Count == 0;
    }

    /// <summary>
    /// 03Stack-01ValidParenthesis [Easy]
    /// Determines whether every opening bracket has a matching closing bracket in the correct order.
    /// </summary>
    /// <param name="s">The string containing parentheses to validate.</param>
    /// <returns><see langword="true"/> if the parentheses are valid; otherwise, <see langword="false"/>.</returns>
    public static bool IsValidWronng(string s)
    {
        var closingMatches = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']'},
            { '{', '}'}
        };

        Stack<char> charStack = new();
        for (var i = s.Length / 2; i < s.Length; i++)
        {
            charStack.Push(s[i]);
        }

        for (var i = 0; i < s.Length / 2; i++)
        {
            var pop = charStack.Pop();
            if (closingMatches.TryGetValue(s[i], out char match))
            {
                if (pop != match) return false;
            }
            else
                return false;
        }

        if (charStack.Count > 0) return false;

        return true;
    }
}
