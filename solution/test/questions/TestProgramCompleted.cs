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
    [TestCase(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10)]
    [TestCase(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, -1)]
    public void TestCase(int[] inp,int sum )
    {
        //GIVEN
        int[] output = Program.TwoNumberSum(inp, sum);

        //THEN
        Assert.True(output.Length == 2);
        Assert.True(Array.Exists(output, e => e == -1));
        Assert.True(Array.Exists(output, e => e == -1));

    }



    [Test]
    public void TestCase1()
    {
        //GIVEN
        List<int> array = new List<int> {
            5, 1, 22, 25, 6, -1, 8, 10
        };
        List<int> sequence = new List<int> {
            15, 1, 22, 25, 6, -1, 8, 10
        };
        //THEN
        Assert.True(ProgramCompleted.IsValidSubsequence(array, sequence));
    }

    [Test]
    public void TestCase2()
    {
        //GIVEN
        List<int> array = new List<int> {
            1, 1, 1, 1, 1
        };
        List<int> sequence = new List<int> {
            1, 1, 1
        };
        //THEN
        Assert.True(ProgramCompleted.IsValidSubsequenceBetterOn(array, sequence));
    }
}

