using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Target", "Front end Cashier,cart collector", 2018, 2019);
   
        Job job2 = new Job("Noble Craftmenship","Aprentice Carpenter",2021,2022);
   
        Resume Tyber = new Resume();
        Tyber._name = "Tyber Buchheit";
        Tyber._jobs.Add(job1);
        Tyber._jobs.Add(job2);
        Tyber.Display();
    }
 
}