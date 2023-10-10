using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class leaves
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

           
            employee.LeaveApplied += (requestedLeaves) =>
            {
                Console.WriteLine($"Leave application successful for {requestedLeaves} days.");
            };

       
            employee.ApplyForLeave(6);
            employee.ApplyForLeave(4);

            Console.ReadLine();
        }
    }

}
