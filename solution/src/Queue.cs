using System;
using System.Collections.Generic;
using System.Linq;
// First In First Out
public class Queue<T>
{

    #region Attributes
    private LinkedList<T> queueList;
    public int size {
                get
                {
                    return queueList.Count;
                }
         }
    #endregion
    public Queue()
    {
        queueList = new LinkedList<T>();
    }
    // O(1)
    public void enqueue(T v)
    {
        queueList.AddFirst(v);
    }
    // O(1)
    public void dequeue()
    {
        queueList.RemoveLast();
    }

    public T peek()
    {
        return queueList.Last();
    }
}
