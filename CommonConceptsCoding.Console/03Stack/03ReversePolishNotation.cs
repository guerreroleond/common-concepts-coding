namespace CommonConceptsCoding.Console;

/// <summary>
/// 03Stack-03ReversePolishNotation [Medium]
/// Evaluates arithmetic expressions written in Reverse Polish Notation.
/// </summary>
public class ReversePolishNotation
{
    /// <summary>
    /// 03Stack-03ReversePolishNotation [Medium]
    /// Evaluates a Reverse Polish Notation expression.
    /// </summary>
    /// <param name="tokens">The operands and operators (+, -, *, /) of the expression.</param>
    /// <returns>The integer result of the expression.</returns>
    /// <exception cref="NotImplementedException">The operation has not been implemented.</exception>
    public static int Evaluate(string[] tokens)
    {
        var stack = new Stack<int>();

		foreach(var token in tokens)
		{
            if(token == "+" || token == "-" || token == "*" || token == "/")
            {
                var right = stack.Pop();
                var left = stack.Pop();
                var result = token switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => left / right,
                    _ => throw new InvalidOperationException()
                };
                stack.Push(result);
            }
            else
                stack.Push(int.Parse(token));
		}
		
		return stack.Pop();
    }
}
