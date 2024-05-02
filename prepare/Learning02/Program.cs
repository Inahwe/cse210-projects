using System;


class Program
{
    static void Main(string[] args)
    {
        // Create job1 instance
        Job job1 = new Job();

        // Set member variables for job1
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";
        // Display the company of job1
        
        

        // Create job2 instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";
        // Set member variables for job2
        // Display the company of job2
         // Output: Product Manager (Apple) 2020-2023

        Resume _myresume = new Resume();
        _myresume._name = "Willie Inah";
        _myresume._jobs.Add(job1);
        _myresume._jobs.Add(job2);

        _myresume.Display();


    }
}