﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTime3
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "shagun" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!");
                Console.ReadLine();
            }
        }
    }
}
