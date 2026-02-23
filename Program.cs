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
        StudyTask task1 = new StudyTask("Read Chapter", 15, true);
        StudyTask task2 = new StudyTask("Annotate Chapter", 20, true);
        StudyTask task3 = new StudyTask("Review Notes", 30, false);
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
                case 1:
                    Console.WriteLine();
                    task1.DisplayTask(1);
                    task2.DisplayTask(2);
                    task3.DisplayTask(3);
                    break;
                case 2:
                    Console.Write("Select item to update (1-3): ");
                    int itemChoice = int.Parse(Console.ReadLine());
                    switch (itemChoice)
                    {
                        case 1:
                            task1.ToggleCompleted();
                            Console.WriteLine("Updated Item 1");
                            break;
                        case 2:
                            task2.ToggleCompleted();
                            Console.WriteLine("Updated Item 2");
                            break;
                        case 3:
                            task3.ToggleCompleted();
                            Console.WriteLine("Updated Item 3");
                            break;
                    }
                    break;
                case 3:
                    running = false;
                    Console.WriteLine("Program Ended");
                    break;
            }
        }
    }
}