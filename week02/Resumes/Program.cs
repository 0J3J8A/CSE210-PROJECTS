using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");


        // JOB CLASS INSTANCE
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Data Scientist";
        job2._company = "Asus";
        job2._startYear = 2022;
        job2._endYear = 2024;

        //RESUME CLASS INSTANCE
        Resume myResume = new Resume();
        myResume._personName = "Juan Jose Aguirre";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }



}