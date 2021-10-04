using System;
using NUnit.Framework;

[TestFixture()]
public class TestQueue
{
    

    public void enqueue()
    {
        //GIVEN
        Queue<int> myQueue = new Queue<int>();
        //WHEN
        myQueue.enqueue(5);
        myQueue.enqueue(15);
        myQueue.enqueue(25);
        myQueue.enqueue(35);
        //THEN
        Assert.True(myQueue.size==4);
    }

    public void dequeue()
    {
        //GIVEN
        Queue<int> myQueue = new Queue<int>();
        //WHEN
        myQueue.enqueue(5);
        myQueue.enqueue(15);
        myQueue.enqueue(25);
        myQueue.enqueue(35);
        //THEN

    }

    public void peek()
    {
        //GIVEN
        Queue<int> myQueue = new Queue<int>();
        //WHEN
        myQueue.enqueue(5);
        myQueue.enqueue(15);
        myQueue.enqueue(25);
        myQueue.enqueue(35);
        int value = myQueue.peek();
        //THEN
        Assert.True(value==5);
        Assert.True(myQueue.size == 4);


    }


}

