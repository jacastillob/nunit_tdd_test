using System;
using NUnit.Framework;

[TestFixture()]
public class TestQueue
{
    
    [Test]
    public void enqueue()
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
        Assert.True(myQueue.size==4);
        Assert.True(value == 5);
    }
    [Test]
    public void dequeue()
    {
        //GIVEN
        Queue<int> myQueue = new Queue<int>();
        //WHEN
        myQueue.enqueue(5);
        myQueue.enqueue(15);
        myQueue.enqueue(25);
        myQueue.enqueue(35);
        myQueue.dequeue();
        int value = myQueue.peek();
        //THEN
        Assert.True(myQueue.size == 3);
        Assert.True(value == 15);
    }
    [Test]
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

