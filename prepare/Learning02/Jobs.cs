using System;

public class Job
{

    public string _company;
 
    public string _jobTitle;
   
    public int _startYear;
 
    public int _endYear;
 
    public Job(string companyName, string title, int start, int end){
        _company = companyName;
        _jobTitle = title;
        _startYear = start;
        _endYear = end;
    }
   
    public void Display()
    {
        // Software Engineer (Miscrosoft) 2019-2022
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
 
// _ tells the developer that this is a private variable