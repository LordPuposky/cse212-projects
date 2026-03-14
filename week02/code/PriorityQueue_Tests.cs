using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities: Item1 (2), Item2 (5), Item3 (3).
    // Expected Result: Item2, Item3, Item1
    // Defect(s) Found: The Dequeue method does not remove the item from the list, causing 
    // it to return the same item repeatedly. Also, the loop skips the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 3);

        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items where some have the same highest priority: ItemA (5), ItemB (2), ItemC (5).
    // Expected Result: ItemA, ItemC, ItemB (FIFO rule for priorities 5 and 5)
    // Defect(s) Found: The use of '>=' in the comparison picks the last item added with
    // the highest priority instead of the first one, violating the FIFO requirement.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("ItemA", 5);
        priorityQueue.Enqueue("ItemB", 2);
        priorityQueue.Enqueue("ItemC", 5);

        Assert.AreEqual("ItemA", priorityQueue.Dequeue());
        Assert.AreEqual("ItemC", priorityQueue.Dequeue());
        Assert.AreEqual("ItemB", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: Exception should be thrown with message "The queue is empty."
    // Defect(s) Found: None. The exception is thrown correctly with the appropriate message.
    public void TestPriorityQueue_Empty()
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