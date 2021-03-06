using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///Contains(System.Object)
/// </summary>
public class ListIListContains
{
    public static int Main()
    {
        ListIListContains ListIListContains = new ListIListContains();
        TestLibrary.TestFramework.BeginTestCase("ListIListContains");
        if (ListIListContains.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling Contains method of IList,T is Value type.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            int[] expectValue = new int[10];
            IList myIList = ((IList)myList);
            object element = null;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myIList.Add(element);
                expectValue[i - 1] = (int)element;
            }
            if (!myIList.Contains(element))
            {
                TestLibrary.TestFramework.LogError("001.1", " calling Contains method should return true.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling Contains method of IList,T is reference type.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            string[] expectValue = new string[10];
            object element = null;
            IList myIList = ((IList)myList);
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myIList.Add(element);
                expectValue[i - 1] = element.ToString();
            }
            if (!myIList.Contains(element))
            {
                TestLibrary.TestFramework.LogError("002.1", " calling Contains method should return true.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

   

}

