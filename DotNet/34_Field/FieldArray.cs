using System;

class Schedule
{
    private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    public void PrintWeeksDays()
    {
        foreach ( var day in weekDays)
        {
            Console.WriteLine($"{day}\t");
        }
        Console.WriteLine();
    }
}

class FieldArray
{
    static void Main()
    {
        Schedule schedule = new Schedule();
        schedule.PrintWeeksDays();
    }
}