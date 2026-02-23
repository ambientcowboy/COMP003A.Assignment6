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
        StudyTask task1 = new StudyTask("Title", 5, true);
        StudyTask task2 = new StudyTask("Title", 5, false);
        StudyTask task3 = new StudyTask("Title", 5, false);
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Display All Study Tasks");
            Console.WriteLine("2. Update Study Task");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                
            }
        }
    }
}