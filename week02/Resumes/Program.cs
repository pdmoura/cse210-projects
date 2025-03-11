using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Provide Media";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Console.WriteLine(job1._company);
        job1.Display();

        Job job2 = new Job();
        job2._company = "Bloom";
        job2._jobTitle = "Web Frontend Developer";
        job2._startYear = 2022;
        job2._endYear = 2029;
        Console.WriteLine(job2._company);
        job2.Display();
    }
}