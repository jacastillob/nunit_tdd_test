using System;
using System.Collections.Generic;

// Last In First Out -> LIFO
public class Stack<T>
    {
    #region Attributes
    private  List<T> StackList;
    public int Size { get; set; }
    #endregion

    public Stack()
    {
        StackList = new List<T>();
    }
    // O(1)
    public void Push(T Value)
    {
        StackList[Size++] = Value;
    }
    // O(1)
    public T Pop()
    {
        return StackList[--Size];
    }
    // O(n)
    public bool Search(T v)
    {
        return StackList.Exists(x=>x.Equals(v));
    }
    //O(1)
    public T Peek()
    {
        return StackList[Size];
    }
}

