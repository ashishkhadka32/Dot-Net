using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    string Name, Location, College;
    static void Main(string[] args)
    {
        List<Student> Std = new List<Student>(){
         new Student{Name = "Ashis", Location="Kathmandu",  College ="KCT"},
         new Student{Name = "Hikmat", Location="Kathmandu", College ="Samriddhi"},
         new Student{Name = "Ashok", Location="Kathmandu", College="KCT"},
    };
       var result = Std.FindAll(x => x.Location == "Kathmandu" &&
       x.College == "KCT");
        foreach (var x in result)
        {
            Console.WriteLine($"{x.Name}\t\t {x.Location}\t\t {x.College}");
        }
    }
}
