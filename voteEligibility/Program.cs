using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voteEligibility
{
    public class IneligibleToVoteException : Exception
    {
        public IneligibleToVoteException(string message) : base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the candidate's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                throw new IneligibleToVoteException("Candidate is not eligible to vote. Minimum age for voting is 18 years.");
            }
            else
            {
                Console.WriteLine("Candidate is eligible to vote.");
            }
        }
    }
}
