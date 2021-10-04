using System;
using NUnit.Framework;

    [TestFixture()]
    public class TestStack
    {  
        [Test]
        public void PushElement()
        {
            //GIVEN
            Stack<int> mystack = new Stack<int>();
            //WHEN

            mystack.Push(1);
            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(15);
            int value = mystack.Peek();
        
            //THEN
            Assert.True(mystack.Size==4);
            Assert.True(value == 15);
    }
        [Test]
        public void PopElement()
        {
            //GIVEN
            Stack<int> mystack = new Stack<int>();
            //WHEN

            mystack.Push(1);
            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(15);
            int value = mystack.Pop();

            //THEN
            Assert.True(mystack.Size == 3);
            Assert.True(value == 15);
        }   
        [Test]
        public void PeekingElement()
        {
        //GIVEN
        Stack<int> mystack = new Stack<int>();
        //WHEN

        mystack.Push(1);
        mystack.Push(20);
        mystack.Push(30);
        mystack.Push(15);
        int value = mystack.Peek();

        //THEN
        Assert.True(mystack.Size == 4);
        Assert.True(value == 15);

    }
        [Test]
        public void SearchElement()
        {
            //GIVEN
            Stack<int> mystack = new Stack<int>();
            //WHEN
            mystack.Push(1);
            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(15);
            //THEN
           // Assert.False(mystack.Search(35));
            Assert.True(mystack.Search(30));

        }

    }

