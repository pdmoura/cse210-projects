using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating the classes and assigning values to the attributes
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._personName = "Pedro Alves";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        // Calling the method
        myResume.DisplayResume();

    }
}