using System;
using System.Diagnostics;

namespace DefaultNamespace;

public class Entry
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Task Manager :-");

        GetTasks();
    }

    private static void GetTasks()
    {
        // Get all processes currently running
        Process[] processes = Process.GetProcesses();

        foreach (Process p in processes)
        {
            if ((p.WorkingSet64 / 1024) == 0) { p.Kill(); continue; }
            Console.WriteLine($"{p.ProcessName} (ID: {p.Id}) takes -> {p.WorkingSet64 / 1024} bytes -> with {p.Threads.Count} threads");
        }
    }
}
