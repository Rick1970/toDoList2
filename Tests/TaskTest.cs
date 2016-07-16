using System;
using System.Collections.Generic;
using ToDoList.Objects;
using Xunit;

namespace ToDoList
{
  public class TaskTest
  {
    // public void Dispose()
    // {
    //   Task.DeleteAll();
    // }

    [Fact]
    public void ReturnDescription_GetDescription_ReturnsDescription()
    {
      // Arrange
      string description01 = "Walk the dog";
      Task testTask = new Task(description01);
      List<Task> firstList = new List<Task> {testTask};

      // Act
      string testString = testTask.GetDescription();
      foreach (Task thisTask in firstList)
      {
        Console.WriteLine("Output Test1: " + thisTask.GetDescription());
      }

      // Assert
      Assert.Equal(description01, testString);
    }

    [Fact]
    public void GetAll_ReturnAllTasks_ReturnsAllTasks()
    {
      // Arrange
      string description01 = "Walk the dog";
      string description02 = "Do the shopping";
      Task testTask1 = new Task(description01);
      Task testTask2 = new Task(description02);
      List<Task> testList = new List<Task> { testTask1, testTask2 };

      // Act
      List<Task> resultList = Task.GetAll();
      foreach (Task thisTask in resultList)
      {
        Console.WriteLine("Output Test2: " + thisTask.GetDescription());
      }

      // Assert
      Assert.Equal(testList, resultList);
    }
  }

}
