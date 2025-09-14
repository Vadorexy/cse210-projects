using System;

class Program
{
    static void Main(string[] args)
    {
          // First job
            Job job1 = new Job();
            job1._jobTitle = "Junior Software Engineer";
            job1._company = "HiiT PLC";
            job1._startYear = 2020;
            job1._endYear = 2022;

            // Second job
            Job job2 = new Job();
            job2._jobTitle = "DevOps Engineer";
            job2._company = "Google";
            job2._startYear = 2022;
            job2._endYear = 2025;

            // Create Resume
            Resume myResume = new Resume();
            myResume._name = "Wisdom Ikechi";
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            // Display Resume
            myResume.DisplayResume();
     }
}