using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;

    // list of jobs
    public List<Job> _jobs = new List<Job>();

    // Resume details
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
