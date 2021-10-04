using NUnit.Framework;
using System;

[TestFixture()]
public class Test
{
    [Test()]
    // [TestCase(new int[] { 4, 6, 1, -3 }, 3, new int[] { 6, -3 })]
    public void TestCase()
    {

        //GIVEN | ARRANGE

        int[] input = new int[] { 5, 7, 1, 1, 2, 3, 22 };
        int expected = 20;


        // WHEN | ACT

        var actual =  Program.NonConstructibleChange(input);

        //THEN | ASSERT
        Assert.True(expected == actual);


    }
}

