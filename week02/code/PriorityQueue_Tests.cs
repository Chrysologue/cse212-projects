using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add A(5), B(2), C(10)
    // Expected Result: "C" should be returned because it has the highest priority (10).
    // Defect(s) Found: 

    // FAILED:
    // The loop used to find the highest priority item excluded the last element
    // in the queue (used Count - 1), which could cause the highest priority item
    // to be missed if it is located at the end of the list.
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
    // Scenario: Add A(7), B(5)
    // Expected Result: "A" should be returned because it has the highest priority (7).
    // Defect(s) Found: 

    // FAILED:
    // The loop used to determine the highest priority item did not include
    // the last element in the queue (used Count - 1), which could cause
    // incorrect selection of the highest priority item when it appears at the end.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("A", 7);
        priorityQueue.Enqueue("B", 5);

        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Add A(5), B(5), and C(2)
    // the item closest to the front of the queue is removed first.
    // Expected Result: "A" should be returned because A and B have the same priority,
    // and A was enqueued first.
    // Defect(s) Found: 

    // FAILED:
    // The queue handled equal priorities incorrectly.
    // Using >= caused later items with the same priority to replace earlier ones.
    // This broke FIFO order when priorities were equal.

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found:

    // No defects found. The queue correctly throws an exception when empty
    // and matches the expected behavior.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}