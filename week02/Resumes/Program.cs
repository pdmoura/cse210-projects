using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating the classes and assigning values to the attributes
        Job job1 = new Job();
        job1._company = "Provide Media";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Bloom";
        job2._jobTitle = "Web Frontend Developer";
        job2._startYear = 2022;
        job2._endYear = 2029;

        Resume myResume = new Resume();
        myResume._personName = "Pedro Alves";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        // Calling the method
        myResume.DisplayResume();

    }
}