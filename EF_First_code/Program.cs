using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_First_code
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "Matteo" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();

                var query = from b in ctx.Students
                            orderby b.StudentName
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
        }
    }
}
