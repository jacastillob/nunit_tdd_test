﻿using NUnit.Framework;
using System;

[TestFixture()]
public class Test
{
    [Test()]
    public void TestCase()
    {

        //GIVEN | ARRANGE


        // WHEN | ACT
        int[] output = Program.TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

        //THEN | ASSERT



        Assert.True(output.Length == 2);
        Assert.True(Array.Exists(output, e => e == -1));
        Assert.True(Array.Exists(output, e => e == -1));

    }
}
