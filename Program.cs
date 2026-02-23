namespace COMP003A.Assignment6;

using System;

public class StudyTask
{
    public string title;
    public int plannedMinutes;
    public bool completed;

    public StudyTask(string title, int plannedMinutes, bool completed)
    {
        this.title = title;
        this.plannedMinutes = plannedMinutes;
        this.completed = completed;
    }

    public void DisplayTask(int itemNumber)
    {
        Console.WriteLine($"Item: " + itemNumber + ": Title: " + title +
                          ", PlannedMinutes: " + plannedMinutes + " Completed: " + completed);
    }
    public void ToggleCompleted()
    {
        completed = !completed;
        
    }
}
public class Program
{
    public static void Main(string [] args)
    {
        
    }
}