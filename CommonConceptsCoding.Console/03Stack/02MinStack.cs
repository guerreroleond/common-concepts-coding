namespace CommonConceptsCoding.Console;

/// <summary>
/// 03Stack-02MinStack [Medium]
/// Provides stack operations with constant-time access to the minimum value.
/// </summary>
public class MinStack
{
    private Stack<(int val, int min)> _minStack = new();


    /// <summary>
    /// 03Stack-02MinStack [Medium]
    /// Pushes a value onto the stack.
    /// </summary>
    /// <param name="val">The value to push.</param>
    public void Push(int val)
    {
        int min = _minStack.Count == 0 ? val
                    : Math.Min(_minStack.Peek().min, val);

        _minStack.Push((val, min));
    }

    /// <summary>
    /// 03Stack-02MinStack [Medium]
    /// Removes the value at the top of the stack.
    /// </summary>
    public void Pop()
    {
        _minStack.Pop();
    }

    /// <summary>
    /// 03Stack-02MinStack [Medium]
    /// Returns the value at the top of the stack without removing it.
    /// </summary>
    /// <returns>The value at the top of the stack.</returns>
    public int Top()
    {
        return _minStack.Peek().val;
    }

    /// <summary>
    /// 03Stack-02MinStack [Medium]
    /// Returns the minimum value in the stack.
    /// </summary>
    /// <returns>The minimum value in the stack.</returns>
    public int GetMin()
    {
        return _minStack.Peek().min;
    }
}
