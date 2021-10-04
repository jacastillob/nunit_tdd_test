using algo.src.questions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture()]
public class TestProgramCompleted
{  
    [SetUp]

    public void init()
    {
    }

    [Test()]
    [TestCase(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10,new int[] {-1,11 })]
    [TestCase(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10, new int[] { 11, -1 })]
    [TestCase(new int[] { 4, 6, 1, -3 }, 3, new int[] { 6, -3 })]
    // [TestCase(new int[] { 4, 6, 1, -3 }, 30, new int[] { -1, 11 }, ExpectedResult = false)]
    // [Parallelizable(ParallelScope.All)]

    public void TestTwoNumberSum(int[] inp,int sum,int[] expected )
    {
        //GIVEN | ARRANGE


        // WHEN | ACT
        int[] output = ProgramCompleted.TwoNumberSum(inp, sum);

        //THEN | ASSERT
        Assert.True(output.Length == 2);
        Assert.True(expected.Length == 2);
        Assert.True(Array.Exists(output, e => e == expected[0]));
        Assert.True(Array.Exists(output, e => e == expected[1]));

    }
    [Test()]
    public void TestTwoNumberSumOld()
    {
        //GIVEN | ARRANGE
        int[] inp = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        int[] expected = new int[] { -1, 11 };
        int sum = 10;

        // WHEN | ACT
        int[] output = ProgramCompleted.TwoNumberSum(inp, sum);

        //THEN | ASSERT
        //Assert.Throws<Exception>(() => ProgramCompleted.breakingAction(sum));
        Assert.True(output.Length == 2);
        Assert.True(expected.Length == 2);
        Assert.True(Array.Exists(output, e => e == expected[0]));
        Assert.True(Array.Exists(output, e => e == expected[1]));
       
    }
    /// <summary>
    /// Once a assert fails, the remaining assert never go through,
    /// assert multiple enable the test to continue and even trigger exception to record what's happened
    /// it is also good to eval objects or lists (track values)
    /// </summary>
    [Test()]
    public void TestTwoNumberSumThrowException()
    {
        //GIVEN | ARRANGE
        int[] inp = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        int[] expected = new int[] { -1, 11 };
        int sum = 10;

        // WHEN | ACT
        int[] output = ProgramCompleted.TwoNumberSum(inp, sum);

        //THEN | ASSERT

        Assert.Multiple(() =>
        {
            Assert.Throws<Exception>(() => ProgramCompleted.breakingAction( sum));
            Assert.True(output.Length == 2);
            Assert.True(expected.Length == 2);
            Assert.True(Array.Exists(output, e => e == expected[0]));
            Assert.True(Array.Exists(output, e => e == expected[1]));
        });
    }

    [Test]
    public void TestIsValidSubsequence()
    {
        //GIVEN | ARRANGE
        List<int> array = new List<int> {
            5, 1, 22, 25, 6, -1, 8, 10
        };
        List<int> sequence = new List<int> {
          5, 1, 22, 6, -1, 8, 10
        };

        // WHEN | ACT

        //THEN | ASSERT
        Assert.True(ProgramCompleted.IsValidSubsequence(array, sequence));
    }

    [Test]
    public void TestSortedSquaredArray()
    {
        //GIVEN | ARRANGE
        var input = new int[] { 1, 2, 3, 5, 6, 8, 9 };
        var expected = new int[] { 1, 4, 9, 25, 36, 64, 81 };

        // WHEN | ACT
        var actual = ProgramCompleted.SortedSquaredArray(input);
        //THEN | ASSERT
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.True(expected[i] == actual[i]);
        }
    }

    [Test()]
    public void TestNonConstructibleChange()
    {

        //GIVEN | ARRANGE

        int[] input = new int[] { 5, 7, 1, 1, 2, 3, 22 };
        int expected = 20;


        // WHEN | ACT

        var actual = ProgramCompleted.NonConstructibleChange(input);

        //THEN | ASSERT
        Assert.True(expected == actual);


    }



    [TearDown]
    public void Cleanup()
    {
        //Let's clean the mess
    }
}

