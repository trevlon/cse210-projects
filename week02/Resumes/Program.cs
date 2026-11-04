using System;
using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        // Create variable (miInfo) and link it to the Job class from file Job.cs
        Job myInfo = new Job();
        // Then use that variable and dot notation to call the method JobInfo() which is also in Job.cs file to call it to main
        // myInfo.JobInfo();
      
        // Create a new job instance
        Job job1 = new Job();
        // Adding attributes (member variables) from the Job class to job1
        job1._jobTitle = "Programmer";
        job1._company = "Republic Bank";
        job1._startYear = 2025;
        job1._endYear = 2026;
        // display company name from job1
        // Console.WriteLine(job1._company);
        // job1.Display();

        // Create a new job instance
        Job job2 = new Job();
        // Adding attributes (member variables) from the Job class to job2
        job2._jobTitle = "Salesman";
        job2._company = "Porche";
        job2._startYear = 2020;
        job2._endYear = 2024;
        // display company name from job2
        // Console.WriteLine(job2._company);
        // job2.Display();

        Resume myResume = new Resume();
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);
        myResume.DisplayResume();
        // Console.WriteLine($"{myResume.jobs[0]._jobTitle} ({myResume.jobs[0]._company}) {myResume.jobs[0]._startYear} - {myResume.jobs[0]._endYear}");
        // Console.WriteLine($"{myResume.jobs[1]._jobTitle} ({myResume.jobs[1]._company}) {myResume.jobs[1]._startYear} - {myResume.jobs[1]._endYear}");
    }
}

