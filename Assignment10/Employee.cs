using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{

    public class Employee
    {
        public int Leaves { get; private set; } = 10; 

      
        public delegate void LeaveAppliedEventHandler(int requestedLeaves);


        public event LeaveAppliedEventHandler LeaveApplied;

   
        public void ApplyForLeave(int requestedLeaves)
        {
            if (requestedLeaves <= Leaves)
            {
                Leaves -= requestedLeaves;
                OnLeaveApplied(requestedLeaves);
                Console.WriteLine($"Leave request approved for {requestedLeaves} days.");
                Console.WriteLine($"Remaining leaves: {Leaves} days.");
            }
            else
            {
                Console.WriteLine("Leave request denied. Insufficient leaves.");
            }
        }

     
        protected virtual void OnLeaveApplied(int requestedLeaves)
        {
            LeaveApplied?.Invoke(requestedLeaves);
        }
    }

}
