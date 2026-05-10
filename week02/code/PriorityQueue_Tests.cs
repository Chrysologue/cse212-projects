using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 10);
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("A", 7);
        priorityQueue.Enqueue("B", 5);

        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}